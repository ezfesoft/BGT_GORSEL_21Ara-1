using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGT_GORSEL_21Ara_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


































            int fiyat = Convert.ToInt32(textBox1.Text);
            double toplamTutar;
            double aylikTutar;
            if (radioButton1.Checked==true)
            {
                toplamTutar = fiyat;
                aylikTutar = toplamTutar;
                MessageBox.Show("Toplam:" + toplamTutar+ " - Aylık Tutar:" + aylikTutar);
            }
            else if (radioButton2.Checked==true)
            {
                toplamTutar = fiyat *1.05;
                aylikTutar = toplamTutar / 2;
                MessageBox.Show("Toplam:" + toplamTutar + " - Aylık Tutar:" + aylikTutar);
            }
            else if (radioButton3.Checked == true)
            {
                toplamTutar = fiyat * 1.05;
                aylikTutar = toplamTutar / 3;
                MessageBox.Show("Toplam:" + toplamTutar + " - Aylık Tutar:" + aylikTutar);
            }
            else if (radioButton4.Checked == true)
            {
                toplamTutar = fiyat * 1.15;
                aylikTutar = toplamTutar / 6;
                MessageBox.Show("Toplam:" + toplamTutar + " - Aylık Tutar:" + aylikTutar);
            }
            else if (radioButton5.Checked == true)
            {
                toplamTutar = fiyat * 1.25;
                aylikTutar = toplamTutar / 9;
                MessageBox.Show("Toplam:" + toplamTutar + " - Aylık Tutar:" + aylikTutar);
            }
        }
    }
}
