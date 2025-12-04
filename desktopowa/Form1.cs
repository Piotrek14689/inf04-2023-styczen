using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopowa
{
    public partial class Form1 : Form
    {
        string haslo = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            haslo = string.Empty;
            int iloscZnakow = int.Parse(numericUpDown1.Text);
            string maleLitery = "abcdefghijklmnopqrstuvwxyz";
            string duzeLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string liczby = "0123456789";
            string znakiSpecjalne = "!@#$%^&*()_+-=";
            

            Random generator = new Random();

            bool czyMaleLitery = checkBox4.Checked;
            bool czyDuzeLitery = checkBox1.Checked;
            bool czyCyfry = checkBox2.Checked;
            bool czyZnakiSpecjalne = checkBox3.Checked;
            int flag;


            if(!czyMaleLitery && !czyDuzeLitery && !czyCyfry && !czyZnakiSpecjalne)
            {
                MessageBox.Show("Zaznacz przynajmniej jedną opcję.");
                return;
            }

            if(iloscZnakow<=0)
            {
                MessageBox.Show("Liczba znaków musi być większa od 0.");
                return;
            }


            for (int i = 0; i < iloscZnakow; i++)
            {
                flag = generator.Next(0, 5);
                switch (flag)
                {
                    case 0:
                        {
                            if (czyMaleLitery)
                            {
                                int liczba = generator.Next(maleLitery.Length);
                                haslo += maleLitery[liczba];

                            }
                            else
                            {
                                i--;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (czyDuzeLitery)
                            {
                                int liczba = generator.Next(duzeLitery.Length);
                                haslo += duzeLitery[liczba];
                            }
                            else
                            {
                                i--;
                            }   
                            break;
                        }
                    case 2:
                        {
                            if (czyCyfry)
                            {
                                int liczba = generator.Next(liczby.Length);
                                haslo += liczby[liczba];
                            }
                            else
                            {
                                i--;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (czyZnakiSpecjalne)
                            {
                                int liczba = generator.Next(znakiSpecjalne.Length);
                                haslo += znakiSpecjalne[liczba];
                            }
                            else
                            {
                                i--;
                            }
                            break;
                        }


                }

            }
            MessageBox.Show(haslo);


        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string dane = "Dane pracownika: " + textBox1.Text + " " + textBox2.Text + " " + comboBox1.Text + " ";
            MessageBox.Show(dane + "Hasło: " + haslo);
        }
    }
}
