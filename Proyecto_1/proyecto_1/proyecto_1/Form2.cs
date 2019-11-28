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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txbApellido.Text != "" && this.txbNombre.Text != "" && this.txbDni.Text != "" && this.cmbMorir.Text != "" && this.cmbReligion.Text != "" && this.txbEdad.Text != "")
            {
                if (this.rbFemenino.Checked == true || this.rbMasculino.Checked == true || this.rbOtros.Checked == true)
                {
                    Form3 form3 = new Form3();

                    form3.lblApellido21.Text = this.txbApellido.Text;
                    form3.lblNombre21.Text = this.txbNombre.Text;
                    form3.lblDni21.Text = this.txbDni.Text;
                    form3.lblMorir21.Text = this.cmbMorir.Text;
                    form3.lblRelogiosa21.Text = this.cmbReligion.Text;
                    form3.lblEdad21.Text = this.txbEdad.Text + " años";

                    if (this.rbMasculino.Checked == true)
                    {
                        form3.lblSexo21.Text = this.rbMasculino.Text;
                    }

                    if (this.rbFemenino.Checked == true)
                    {
                        form3.lblSexo21.Text = this.rbFemenino.Text;
                    }

                    if (this.rbOtros.Checked == true)
                    {
                        form3.lblSexo21.Text = this.rbOtros.Text;
                    }

                    this.Hide();
                    form3.ShowDialog();
                    this.Show();

                }

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

