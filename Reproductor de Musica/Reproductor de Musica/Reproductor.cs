using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Reproductor_de_Musica
{
    public class Reproductor
    {
        private Playlist1 playlist;
        private ColaReproduccion cola;
        private Historial historial;

        private NodoCancion actual;
        private bool cambioManual = false;
        private WaveOutEvent output;
        private AudioFileReader audio;

        //Expone la posicion actual de la cancion (tiempo en el que esta)
        public TimeSpan Posicion => audio != null ? audio.CurrentTime : TimeSpan.Zero;

        //Expone el timepo total de la cancion actual
        public TimeSpan Duracion => audio != null ? audio.TotalTime : TimeSpan.Zero;

        //Expone la cancionn actual
        public Cancion CancionActual => actual?.Dato;

        //Estado de reproduccion
        public PlaybackState EstadoReproduccion => output?.PlaybackState ?? PlaybackState.Stopped;

        // Volumen del audio (de 0 a 100)
        private float _volumenActual = 1.0f;

        // Metodo Constructor
        public Reproductor(Playlist1 playlist)
        {
            this.playlist = playlist;
            this.cola = new ColaReproduccion();
            this.historial = new Historial();
            this.actual = null;
        }

        //Metdo para reproducir una cancion
        public void ReproducirCancion(Cancion c)
        {
            try
            {
                
                if (actual != null && actual.Dato.Id == c.Id && output != null)
                {
                    PausarCancion();
                    return;
                }

                cambioManual = true;

                if (output != null)
                {
                    output.PlaybackStopped -= Output_PlaybackStopped;
                    output.Stop();
                    output.Dispose();
                    output = null;
                }

                if (audio != null)
                {
                    audio.Dispose();
                    audio = null;
                }

                string rutaCompleta = Path.Combine(Application.StartupPath, c.RutaArchivo);
                if (!File.Exists(rutaCompleta))
                {
                    MessageBox.Show("Archivo no encontrado: " + rutaCompleta);
                    cambioManual = false;
                    return;
                }

                audio = new AudioFileReader(rutaCompleta);
                output = new WaveOutEvent();
                output.Init(audio);
                output.PlaybackStopped += Output_PlaybackStopped;
                audio.Volume = _volumenActual;
                output.Play();

                actual = BuscarNodo(c.Id);
                historial.Push(c);
                OnCancionCambiada?.Invoke(c.Id);
                cambioManual = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir: " + ex.Message);
                cambioManual = false;
            }
        }


        public void PausarCancion()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                    output.Pause();
                else
                    output.Play();
            }
        }


     
        public void SiguienteCancion()
        {
            // Prioridad: cola
            if (!cola.EstaVacia())
            {
                Cancion siguiente = cola.Desencolar();
                ReproducirCancion(siguiente);
                return;
            }

            if (actual != null && actual.Siguiente != null)
            {
                ReproducirCancion(actual.Siguiente.Dato);
            }
        }


        public void CancionAnterior()
        {
            if (actual != null && actual.Anterior != null)
            {
                ReproducirCancion(actual.Anterior.Dato);
            }
        }


       
        private NodoCancion BuscarNodo(int id)
        {
            NodoCancion temp = playlist.inicio;

            while (temp != null)
            {
                if (temp.Dato.Id == id)
                    return temp;

                temp = temp.Siguiente;
            }

            return null;
        }

        //Historial
        public NodoCancion ObtenerHistorial()
        {
            return historial.Cima;
        }

        //Diferenciacion de cambio autoatico o manual
        private void Output_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (cambioManual)
            {
                cambioManual = false;
                return;
            }
           
            if (e.Exception != null)
                return;


            SiguienteCancion();
        }

        //Determina poscion del tiempod de la cancion
        public void DetPosicion(TimeSpan tiempo)
        {
            if (audio != null && tiempo <= audio.TotalTime)
                audio.CurrentTime = tiempo;
        }

        //Control de volumen 

        public void CambiarVolumen(int valor)
        {
            _volumenActual = valor / 100f;
            if (audio != null)
                audio.Volume = _volumenActual;
        }

        public event Action<int> OnCancionCambiada;
    }
}
