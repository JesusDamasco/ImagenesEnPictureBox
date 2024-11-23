namespace ImagenesEnPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImagenesEnPictureBox.Properties.Resources.Primavera;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImagenesEnPictureBox.Properties.Resources.Verano;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImagenesEnPictureBox.Properties.Resources.Otono;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImagenesEnPictureBox.Properties.Resources.Invierno;
        }
    }
}
