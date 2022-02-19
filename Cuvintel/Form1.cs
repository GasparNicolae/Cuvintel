using System.IO;
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
    
    public partial class Form1 : Form
    {
        public static string[] stringArray = new string[1001];
        public static int[] arrayCuv = Enumerable.Repeat(-1, 1001).ToArray();
        public static int numarArrayCuv = -1;
        public static int nr = 0, OK = 1, scor = -1, dim = 1, varInchide = 1, monede;
        public static string locatie1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            label1.Hide(); // pentru test

            int ok = 1;
            string locatie;
            locatie = Application.StartupPath + "\\Cuvintel.cuv";
            locatie1 = Application.StartupPath + "\\.CVDB.cuv";
            if (!File.Exists(locatie1)) { File.Create(locatie1).Close();
                                          using (StreamWriter scrie = new StreamWriter(locatie1))
                                         {
                                           scrie.WriteLine(Convert.ToString("0"));
                                           scrie.WriteLine(Convert.ToString("0"));
                                         }
                                        }
            File.SetAttributes(locatie1, File.GetAttributes(locatie1) | FileAttributes.Hidden);
            string[] db = System.IO.File.ReadAllLines(locatie1);
            scor = Convert.ToInt32(db[0]);
            monede = Convert.ToInt32(db[1]);

            if (!File.Exists(locatie)) ok = 0;
            if (ok == 1)
            {
                File.SetAttributes(locatie, File.GetAttributes(locatie) | FileAttributes.Hidden);
                System.IO.StreamReader fisier = new System.IO.StreamReader(locatie);

            if(OK==1)
                while ((stringArray[nr] = fisier.ReadLine()) != null)
                {
                    int y = 1;
                    for (int i = 0; i < stringArray[nr].Length; i++)
                        if (char.IsLower(stringArray[nr][i])) y = 0;

                    if (stringArray[nr].Length != 5 || nr == 1000 || y==0) { dim = 0; break; }
                   nr++;
                }
            lbCMBS.Text = "Ai ajuns la\nnivelul " + Convert.ToString(scor+1) + " !";
            }
            label1.Text = Convert.ToString(monede);
            if(nr==0 || dim==0)
            {
                MessageBox.Show("Fisierul text 'Cuvintel.cuv', care contine cuvintele necesare jocului,\nnu exista in folderul executabilului sau conține o listă compusă incorect!");
                Environment.Exit(1);
            }
            
            Random rnd = new Random();
            
            OK = 0;
        }

        private void picJoaca_Click(object sender, EventArgs e)
        {
           picJoaca.BackgroundImage = global::Cuvintel.Properties.Resources.btnJoacaApasat;
           Form2.rund = 1;
           Form2 f2 = new Form2();
           Update();
           System.Threading.Thread.Sleep(1000);
           f2.Show();
           this.Hide();
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
