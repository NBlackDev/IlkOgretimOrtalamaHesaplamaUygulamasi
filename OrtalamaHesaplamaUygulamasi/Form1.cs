using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesaplamaUygulamasi
{
    public partial class Form1 : Form
    {
        int Sinav1, Sinav2, Performans1, Performans2, ToplamaİslemiSonuc, islemSonuc;
        string Dersismi;
        public Form1()
        {
            InitializeComponent();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hesaplabutton_Click_1(object sender, EventArgs e)
        {
            Sinav1 = int.Parse(sinavgiris1.Text);
            Sinav2 = int.Parse(sinavgiris2.Text);
            if (performansgiris1.Text.Length > 0)
            {
                Performans1 = int.Parse(performansgiris1.Text);
            }
            if (performansgiris2.Text.Length > 0)
            {
                Performans2 = int.Parse(performansgiris2.Text);
            }
            if (Ders_ismi_giris.Text.Length > 0)
            {
                Dersismi = Ders_ismi_giris.Text;
            }
            else
            {
                Dersismi = "(Ders ismi girilmedi)";
            }
            if (Performans1 > 0 && Performans2 > 0)
            {
                ToplamaİslemiSonuc = Sinav1 + Sinav2 + Performans1 + Performans2;
                islemSonuc = ToplamaİslemiSonuc / 4;
                if (islemSonuc >= 50)
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Geçtiniz :)";
                }
                else
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Kaldınız :(";
                }
            }
            else if (Performans1 == 0 && Performans2 == 0)
            {
                ToplamaİslemiSonuc = Sinav1 + Sinav2;
                islemSonuc = ToplamaİslemiSonuc / 2;
                if (islemSonuc >= 50)
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Geçtiniz :)";
                }
                else
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Kaldınız :(";
                }
            }

            else if (Performans1 > 0 && Performans2 == 0)
            {
                ToplamaİslemiSonuc = Sinav1 + Sinav2 + Performans1;
                islemSonuc = ToplamaİslemiSonuc / 3;
                if (islemSonuc >= 50)
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Geçtiniz :)";
                }
                else
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Kaldınız :(";
                }
            }
            else if (Performans1 == 0 && Performans2 > 0)
            {
                ToplamaİslemiSonuc = Sinav1 + Sinav2 + Performans2;
                islemSonuc = ToplamaİslemiSonuc / 3;
                if (islemSonuc >= 50)
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Geçtiniz :)";
                }
                else
                {
                    sonuc_yazi.Text = Dersismi + " Dersinden " + islemSonuc + " Ortalama İle Kaldınız :(";
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
