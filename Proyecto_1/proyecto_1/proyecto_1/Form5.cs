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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            this.Hide();
            form6.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
