using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

	#endif
namespace Reproductor_mp3
{
    public partial class Form1 : Form
    {
        //Objeto que se encargara de reproducir el audio
        private WindowsMediaPlayer reproductor;

        //Guardamos la ruta del archivo seleccionado
        private string archivoSeleccionado = "";


        public Form1()
        {
            InitializeComponent();

            //Creamos el reproductor
            reproductor = new WindowsMediaPlayer();

            //Evita que se reproduzca el audio solo
            reproductor,settings.autoStart = false;

            //Configuramos el OpenFileDialog
            openFileDialog1.Filter =
                "Archivos de audio (*.mp3)|*.mp3";

            openFileDialog1.Title =
                "Selecciona un archivo MP3";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblArchivo_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(archivoSeleccionado))
                {
                    DialogResult resultado = openFileDialog1.ShowDialog();

                    //El usuario cancelo la seleccion
                    if(resultado != DialogResult.OK)
                    {
                        return;
                    }

                    //Guardar la ruta del archivo
                    archivoSeleccionado = openFileDialog1.FileName;

                    //Mostramos el nombre del archivo en el label
                    lblArchivo.Text = Path.GetFileName(archivoSeleccionado);
                }

                //Indicamos al reproductor que reproduzca el archivo 
                reproductor.URL = archivoSeleccionado;

                //Reproducimos el audio
                reproductor.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el archivo: " + ex.Message);
            }
        }
    }
}
