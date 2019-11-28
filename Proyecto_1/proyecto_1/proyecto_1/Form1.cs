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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtContraseña.Text != "" && this.txtUsuario.Text != "") {
                Form formulario2 = new Form2();

                this.Hide();
                formulario2.ShowDialog();
                this.Show();
            } 
        }
    }
}
