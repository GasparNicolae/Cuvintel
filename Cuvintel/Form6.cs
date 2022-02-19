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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void picMaiDeparte_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void picAcasa_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lbRunda.Text = "Ai trecut de nivelul: " + Form2.scor2;
        }
    }
}
