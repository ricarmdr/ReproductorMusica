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

      
        public Reproductor(Playlist1 playlist)
        {
            this.playlist = playlist;
            this.cola = new ColaReproduccion();
            this.historial = new Historial();
            this.actual = null;
        }


        public void ReproducirCancion(Cancion c)
        {
            try
            {
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
                    return;
                }


                audio = new AudioFileReader(rutaCompleta);
                output = new WaveOutEvent();
                output.Init(audio);


                output.PlaybackStopped += Output_PlaybackStopped;


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

       
        public void DetenerCancion()
        {
            output?.Stop();
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


        public void AgregarACola(Cancion c)
        {
            cola.Encolar(c);
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

        public string ObtenerHistorialTexto()
        {
            NodoCancion actual = historial.Cima;
            string texto = "=== Historial ===\n";

            while (actual != null)
            {
                texto += actual.Dato.Nombre + " - " + actual.Dato.Artista + "\n";
                actual = actual.Siguiente;
            }

            return texto;
        }

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

        public event Action<int> OnCancionCambiada;
    }
}
