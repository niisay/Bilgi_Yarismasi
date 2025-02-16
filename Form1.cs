using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması_Tekrardan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, doğru = 0, yanlis = 0;


        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;



            soruno++;//her "Sonraki" butonuna bastığımda "Soru No:" bir bir artsın.
            lblSoruno.Text = soruno.ToString();//lblSoruno nun textine soruno değişkeninden gelen değeri atama
            //"ToStr.ng ifadesi integer soruno değişkenini strin ifadeye dönüştürür.

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında kurulmuştur ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi şehir Ege Bölgesinde bulunmaz ?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir ?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Attila İlhan";
                btnD.Text = "Reşat Nuri Güntekin";
                label4.Text = "Sait Faik Abasıyanık";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;

                MessageBox.Show("Doğru: " + doğru + "\n" + "Yanlış: " + yanlis);
            }

        }


        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;//labrl5 e bütün sorulardaki a butonunu veya şıkkını yani btnA2nın bütün textindeki cevapları aktarıyoruz.
            if (label4.Text == label5.Text)//eğer label 4 deki yani doğru cevap eşitse label 5 teki yani a butonuna
            {
                doğru++;//doğru değişenini bir arttır
                lblDoğru.Text = doğru.ToString();// lblDoğru textine doğru değişkenini stringe dönüşmüş halini aktar
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }


        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lblDoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                doğru++;
                lblDoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }
        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label5.Text == label4.Text)
            {
                doğru++;
                lblDoğru.Text = doğru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }
    }
}
