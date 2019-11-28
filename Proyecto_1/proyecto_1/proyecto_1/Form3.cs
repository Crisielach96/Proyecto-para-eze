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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();

            if (this.cbTerminos.Checked == true)
            {
                this.Hide();
                frm4.ShowDialog();
                this.Show();
            }
            else {
                this.lblError.Text = "ACEPTE LOS TÉRMINOS Y CONDICIONES AHORA MISMO";
            }
        }
    }
}
