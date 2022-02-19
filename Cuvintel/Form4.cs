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
    public partial class Form4 : Form
    {
        int ok1 = 1, ok2 = 1, ok3 = 1;
        public Form4()
        {
            InitializeComponent();

        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            int optiunea=0;
            if (radPrima.Checked == true && Form1.monede >= 30 && ok1 == 1) { optiunea = 1; Form1.monede = Form1.monede - 30; ok1 = 0; }
            else if (radPrimaUtima.Checked == true && Form1.monede >= 65 && ok2 == 1) { optiunea = 2; Form1.monede = Form1.monede - 65; ok2 = 0; }
            else if (radPatru.Checked == true && Form1.monede >= 100 && ok3 == 1) { optiunea = 3; Form1.monede = Form1.monede - 100; ok3 = 0; }
            else if (ok1 == 0 && optiunea == 1) { MessageBox.Show("Nu poti cumpăra aceleași litere de două ori!"); }
            else if (ok2 == 0 && optiunea == 2) { MessageBox.Show("Nu poti cumpăra aceleași litere de două ori!"); }
            else if (ok3 == 0 && optiunea == 3) { MessageBox.Show("Nu poti cumpăra aceleași litere de două ori!"); }
            else MessageBox.Show("Nu ai suficiente monede!");

            if (optiunea == 1) { lbCuvant.Text = Convert.ToString(Form1.stringArray[Form2.scor2][0]) + " _ _ _ _"; }
            if (optiunea == 2) { lbCuvant.Text = Convert.ToString(Form1.stringArray[Form2.scor2][0]) + " _ _ _ " + Convert.ToString(Form1.stringArray[Form2.scor2][4]); }
            if (optiunea == 3) { lbCuvant.Text = Convert.ToString(Form1.stringArray[Form2.scor2][0]) + " " + Convert.ToString(Form1.stringArray[Form2.scor2][1]) + " _ " + Convert.ToString(Form1.stringArray[Form2.scor2][3]) + " " + Convert.ToString(Form1.stringArray[Form2.scor2][4]); }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
