using System;
using System.IO;
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
    public partial class Form2 : Form
    {
        
        public static int[] arrayLit;
        public static List<string> arrayLitereSelectate = new List<string>();
        public static string[] arrayCompara = new string[1];
        public static int cont, rund=1, scor2 = Form1.scor;
        public static string locatie3;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lbRunda.Refresh();

            label1.Hide(); // pentru test - solutie

            if (scor2 == Form1.nr)
            {
                MessageBox.Show("BRAVO! Ai finalizat jocul, ești cel mai tare!\n\nRepornește programul.");
                File.Delete(Form1.locatie1);
                Environment.Exit(1);
            }

            Form1.varInchide = 1;
            picEroare.Hide();

            int nvl = scor2 + 1;
            lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
            lbRunda.Text = "Nivelul " + nvl;

            cont = 0;
            WindowState = FormWindowState.Maximized;
            Form1.numarArrayCuv++;
            Random rnd = new Random();
            int j;
            arrayLit = Enumerable.Repeat(-1, 5).ToArray();
            //if (numarArrayCuv == Form1.nr) { MessageBox.Show("Ai terminat toate cuvintele din lista! Adauga cuvinte in lista sau reporneste sesiunea."); this.Hide(); }
            do
            {
                j = 0;
                int nrLitera = rnd.Next(0, 5);
                int ok = 1;
                for (int i = 0; i < 5; i++)
                    if (arrayLit[i] == nrLitera) { ok = 0; nrLitera = rnd.Next(0, 5); break; }
                if (ok == 1)
                    for (int i = 0; i < 5; i++)
                        if (arrayLit[i] == -1) { arrayLit[i] = nrLitera; break; }
                for (int i = 0; i < 5; i++)
                    if (arrayLit[i] == -1) j = 1;
            } while (j == 1);
            
               
           lbLitera1.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[0]]);
           lbLitera2.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[1]]);
           lbLitera3.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[2]]);
           lbLitera4.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[3]]);
           lbLitera5.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[4]]);
           label1.Text = Form1.stringArray[scor2];

           lb1Lit.Hide();
           lb2Lit.Hide();
           lb3Lit.Hide();
           lb4Lit.Hide();
           lb5Lit.Hide();
        }

        private void btnAcasa_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            if (Form1.varInchide == 0)
            {
                this.Close();
            }

        }

        private void lbLitera1_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera1.Text);
                cont++;
            }
            if (cont == 1) { 
                             btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                             lb1Lit.Show();
                             lb1Lit.Text = lbLitera1.Text;
                             lbLitera1.Enabled = false;
                             picCasutaRosie1.Enabled = false;
                            }
            if (cont == 2)
                            {
                             btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                             lb2Lit.Show();
                             lb2Lit.Text = lbLitera1.Text;
                             lbLitera1.Enabled = false;
                             picCasutaRosie1.Enabled = false;
                            }
            if (cont == 3)
                            {
                             btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                             lb3Lit.Show();
                             lb3Lit.Text = lbLitera1.Text;
                             lbLitera1.Enabled = false;
                             picCasutaRosie1.Enabled = false;
                            }
            if (cont == 4)
                            {
                             btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                             lb4Lit.Show();
                             lb4Lit.Text = lbLitera1.Text;
                             lbLitera1.Enabled = false;
                             picCasutaRosie1.Enabled = false;
                            }
            if (cont == 5)
                            {
                             btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                             lb5Lit.Show();
                             lb5Lit.Text = lbLitera1.Text;
                             lbLitera1.Enabled = false;
                             picCasutaRosie1.Enabled = false;

                             arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                             if (arrayCompara[0] == Form1.stringArray[scor2])
                             {
                                 Form1.monede = Form1.monede + 3;
                                 scor2++;
                                 File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                                     System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                                     using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                                     {
                                         scrie.WriteLine(Convert.ToString(scor2));
                                         scrie.WriteLine(Convert.ToString(Form1.monede));
                                     }
                                     File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                                 rund++;
                                 Form6 f6 = new Form6();
                                 f6.ShowDialog();

                                 if (Form1.varInchide == 1)
                                 {
                                     Form2 f2 = new Form2();
                                     f2.Show();
                                     lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                                 }
                                 this.Close();

                             }
                             else picEroare.Show();
                             arrayLitereSelectate.Clear();
                            }
        }

        private void lbLitera2_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera2.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();

                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void lbLitera3_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera3.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();
                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void lbLitera4_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera4.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();

                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void lbLitera5_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera5.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();

                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {

              //  arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
              //  MessageBox.Show(Convert.ToString(arrayCompara[0]));
              //  arrayLitereSelectate.Clear();
                
                lbLitera1.Enabled = true;
                lbLitera2.Enabled = true;
                lbLitera3.Enabled = true;
                lbLitera4.Enabled = true;
                lbLitera5.Enabled = true;
                picCasutaRosie1.Enabled = true;
                picCasutaRosie2.Enabled = true;
                picCasutaRosie3.Enabled = true;
                picCasutaRosie4.Enabled = true;
                picCasutaRosie5.Enabled = true;
                cont = 0;
                lb1Lit.Hide();
                lb2Lit.Hide();
                lb3Lit.Hide();
                lb4Lit.Hide();
                lb5Lit.Hide();
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
                picEroare.Hide();
                arrayLitereSelectate.Clear();
        }

        private void picIntrebare_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
            File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
            System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
            using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
            {
                scrie.WriteLine(Convert.ToString(scor2));
                scrie.WriteLine(Convert.ToString(Form1.monede));
            }
            File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            arrayLit = Enumerable.Repeat(-1, 5).ToArray();
            Random rnd = new Random();
            int j;
            do
            {
                j = 0;
                int nrLitera = rnd.Next(0, 5);
                int ok = 1;
                for (int i = 0; i < 5; i++)
                    if (arrayLit[i] == nrLitera) { ok = 0; nrLitera = rnd.Next(0, 5); break; }
                if (ok == 1)
                    for (int i = 0; i < 5; i++)
                        if (arrayLit[i] == -1) { arrayLit[i] = nrLitera; break; }
                for (int i = 0; i < 5; i++)
                    if (arrayLit[i] == -1) j = 1;
            } while (j == 1);

            cont = 0;
            lb1Lit.Hide();
            lb2Lit.Hide();
            lb3Lit.Hide();
            lb4Lit.Hide();
            lb5Lit.Hide();
            btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
            btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
            btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
            btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;
            btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.btnGol;

            lbLitera1.Enabled = true;
            lbLitera2.Enabled = true;
            lbLitera3.Enabled = true;
            lbLitera4.Enabled = true;
            lbLitera5.Enabled = true;
            picCasutaRosie1.Enabled = true;
            picCasutaRosie2.Enabled = true;
            picCasutaRosie3.Enabled = true;
            picCasutaRosie4.Enabled = true;
            picCasutaRosie5.Enabled = true;
            lbLitera1.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[0]]);
            lbLitera2.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[1]]);
            lbLitera3.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[2]]);
            lbLitera4.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[3]]);
            lbLitera5.Text = Convert.ToString(Form1.stringArray[scor2][arrayLit[4]]);

            picEroare.Hide();
            arrayLitereSelectate.Clear();
            this.Refresh();
        }

        private void picCasutaRosie1_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera1.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera1.Text;
                lbLitera1.Enabled = false;
                picCasutaRosie1.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera1.Text;
                lbLitera1.Enabled = false;
                picCasutaRosie1.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera1.Text;
                lbLitera1.Enabled = false;
                picCasutaRosie1.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera1.Text;
                lbLitera1.Enabled = false;
                picCasutaRosie1.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera1.Text;
                lbLitera1.Enabled = false;
                picCasutaRosie1.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();

                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();

                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void picCasutaRosie2_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera2.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera2.Text;
                lbLitera2.Enabled = false;
                picCasutaRosie2.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();

                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void picCasutaRosie3_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera3.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera3.Text;
                lbLitera3.Enabled = false;
                picCasutaRosie3.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();
                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void picCasutaRosie4_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera4.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera4.Text;
                lbLitera4.Enabled = false;
                picCasutaRosie4.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();

                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        private void picCasutaRosie5_Click(object sender, EventArgs e)
        {
            if (cont < 5)
            {
                arrayLitereSelectate.Add(lbLitera5.Text);
                cont++;
            }
            if (cont == 1)
            {
                btnLit1.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb1Lit.Show();
                lb1Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 2)
            {
                btnLit2.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb2Lit.Show();
                lb2Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 3)
            {
                btnLit3.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb3Lit.Show();
                lb3Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 4)
            {
                btnLit4.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb4Lit.Show();
                lb4Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;
            }
            if (cont == 5)
            {
                btnLit5.BackgroundImage = global::Cuvintel.Properties.Resources.butonrosu;
                lb5Lit.Show();
                lb5Lit.Text = lbLitera5.Text;
                lbLitera5.Enabled = false;
                picCasutaRosie5.Enabled = false;

                arrayCompara[0] = string.Join("", arrayLitereSelectate).ToString();
                if (arrayCompara[0] == Form1.stringArray[scor2])
                {
                    Form1.monede = Form1.monede + 3;
                    scor2++;
                    File.SetAttributes(Form1.locatie1, FileAttributes.Normal);
                    System.IO.File.WriteAllBytes(Form1.locatie1, new byte[0]);
                    using (StreamWriter scrie = new StreamWriter(Form1.locatie1))
                    {
                        scrie.WriteLine(Convert.ToString(scor2));
                        scrie.WriteLine(Convert.ToString(Form1.monede));
                    }
                    File.SetAttributes(Form1.locatie1, File.GetAttributes(Form1.locatie1) | FileAttributes.Hidden);
                    rund++;
                    Form6 f6 = new Form6();
                    f6.ShowDialog();
                    if (Form1.varInchide == 1)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        lbBani.Text = "monede: " + Convert.ToString(Form1.monede);
                    }
                    this.Close();

                }
                else picEroare.Show();
                arrayLitereSelectate.Clear();
            }
        }

        
    }
}
