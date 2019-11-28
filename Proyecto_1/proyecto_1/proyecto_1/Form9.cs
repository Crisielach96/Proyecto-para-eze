using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void FullScreenImage(Image imageToShow)
        {
            Form fullScreenForm = new Form()
            {
                WindowState = FormWindowState.Maximized,
                FormBorderStyle = FormBorderStyle.None,
                BackgroundImage = imageToShow,
                BackgroundImageLayout = ImageLayout.Zoom
            };

            fullScreenForm.Click += fullScreen_Click;

            fullScreenForm.ShowDialog();
        }

        private void fullScreen_Click(object sender, EventArgs e)
        {
            ((Form)sender).Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            FullScreenImage(((PictureBox)sender).Image);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
