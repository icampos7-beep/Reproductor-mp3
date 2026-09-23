using WMPLib;
namespace reproductor_MP3
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
            reproductor.settings.autoStart = false;
            //Configuramos el OpenFileDialog
            openFileDialog1.Filter =
            "Archivos de audio (*.mp3)|*.mp3";
            openFileDialog1.Title = "Selecciona un archivo MP3";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(archivoSeleccionado))
                {
                   DialogResult resultado =
                        openFileDialog1.ShowDialog();
                    //El usuario cancelo la selñección
                    if (resultado != DialogResult.OK)
                    {
                        return;
                    }
                    //Guardar la ruta del archivo
                    archivoSeleccionado = 
                        openFileDialog1.FileName;
                    //Mostramos el nombre del archivo de label
                    label2.Text = "Archivo seleccionado: " +
                        Path.GetFileName(archivoSeleccionado);
                }
                //Indicamos al reproductor que reproduzcz el archivo seleccionado
                reproductor.URL = archivoSeleccionado;
                //Reproducir sonido
                reproductor.controls.play();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al repdroducir el archivo: " + ex.Message);
            }
        }
    }
}
