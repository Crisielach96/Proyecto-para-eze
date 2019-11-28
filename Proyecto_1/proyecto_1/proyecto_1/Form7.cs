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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();

            this.Hide();
            form8.ShowDialog();
            this.Show();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.lblError.Text = "ERROR COMMAND NOT FOUND";
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
