using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuvintel
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnDaIesire_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            Form6 f6 = new Form6();
            f6.Close();
            this.Close();
            Form1.varInchide = 0;
        }

        private void btnNuIesire_Click(object sender, EventArgs e)
        {
            Form1.varInchide = 1;
            this.Close();
        }
    }
}
