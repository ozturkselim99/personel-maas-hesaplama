/*********************************************************************************************************************************************************************************
**                                       SAKARYA ÜNİVERSİTESİ BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                       BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                                           2018-2019 BAHAR DÖNEMİ
**                                             ÖDEV NUMARASI:1
**                                             ÖĞRENCİ ADI:AHMET SELİM ÖZTÜRK
**                                             ÖĞRENCİ NUMARASI:G181210082
**                                             DERS GRUBU:2B
***********************************************************************************************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class ÖDEV : Form
    {
        Personel personel = new Personel();

        public ÖDEV()
        {

            InitializeComponent();

        }
        private void dosyasec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //Bir dialog ekranı ile text dosyası seçtik.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                listView1.Items.Clear();

                using (StreamReader sr = File.OpenText(openFileDialog.FileName))
                {
                    string line;
                    //while döngüsü içerisinde sr.ReadLine() ile her bir satırı line değişkenine atıyoruz ve bu değişken boş olmadığı sürece bu döngünün tekrar etmesini sağlıyoruz.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //personel bilgilerini ayrıştırıyoruz ve listeye ekliyoruz.
                        listView1.Items.Add(new ListViewItem(line.Split(' ')));

                    }
                }
            }


        }
        private void ÖDEV_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC", 90);
            listView1.Columns.Add("Adi", 60);
            listView1.Columns.Add("Soyadi", 55);
            listView1.Columns.Add("Yas", 30);
            listView1.Columns.Add("Çalışma Süresi", 80);
            listView1.Columns.Add("Evlilik Durumu", 80);
            listView1.Columns.Add("Eşi Çalışıyormu", 85);
            listView1.Columns.Add("Çocuk Sayısı", 80);
            listView1.Columns.Add("Taban Maaş", 80);
            listView1.Columns.Add("Makam Tazminatı", 95);
            listView1.Columns.Add("İdari Görev Tazminatı", 115);
            listView1.Columns.Add("Fazla Mesai Saati", 100);
            listView1.Columns.Add("Fazla Mesai Ücreti", 100);
            listView1.Columns.Add("Vergi Matrahı", 90);
            listView1.Columns.Add("Personel Resim Yolu", 110);
        }
        private void tctextbox_TextChanged(object sender, EventArgs e)
        {
            //bir personelin maaş hesaplamalarını yaptıktan sonra tekrar yeni bir maaş hesabı yapmak için önceki hesaplanan verileri siliyoruz.
            if (tctextbox.Text.Length < 11)
            {

                maas.Text = " ";
                brütsonuclbl.Text = " ";
                damgavergisisonuclbl.Text = " ";
                gelirvergisisonuclbl.Text = " ";
                emeklikesintisisonuclbl.Text = " ";
                pictureBox1.Image = null;

            }
        }
        //sadece rakam girişi
        private void tctextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void maashesaplabtn_Click(object sender, EventArgs e)
        {

            //textbox içi boşssa uyarı verir.
            if (tctextbox.Text == "")
            {

                MessageBox.Show("LÜTFEN T.C. KİMLİK NO GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            //11 den az rakam girilirse t.c. kimlik no kabul edilmez hata verir.
            if (tctextbox.Text.Length < 11)
            {

                MessageBox.Show("GEÇERLİ BİR T.C. KİMLİK NO GİRİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                maas.Text = " ";

            }
            //listede,satır sayısı kadar dönen bir for döngüsü yazdım.
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                //textboxa girilen t.c. ile 0.sütunumuzdaki satırları karşılaştırıyoruz.girilen t.c. ile listedeki t.c. birbirine eşit olunca gerekli dönüşümleri yapıyoruz.
                if (listView1.Items[i].SubItems[0].Text == tctextbox.Text)
                    
                {
               
                    personel.tc = listView1.Items[i].SubItems[0].Text;
                    personel.ad = listView1.Items[i].SubItems[1].Text;
                    personel.soyadi = listView1.Items[i].SubItems[2].Text;
                    personel.yas = Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
                    personel.calısmasuresi = Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
                    personel.evlilikdurumu = Convert.ToChar(listView1.Items[i].SubItems[5].Text);
                    personel.esicalısıyormu = Convert.ToChar(listView1.Items[i].SubItems[6].Text);
                    personel.cocuksayisi = Convert.ToInt32(listView1.Items[i].SubItems[7].Text);
                    personel.tabanmaas = Convert.ToDouble(listView1.Items[i].SubItems[8].Text);
                    personel.makamtazminatı = Convert.ToDouble(listView1.Items[i].SubItems[9].Text);
                    personel.idarigörevtazminati = Convert.ToDouble(listView1.Items[i].SubItems[10].Text);
                    personel.fazlamesaisaati = Convert.ToDouble(listView1.Items[i].SubItems[11].Text);
                    personel.fazlamesaisaatiücreti = Convert.ToDouble(listView1.Items[i].SubItems[12].Text);
                    personel.vergimatrahı = Convert.ToDouble(listView1.Items[i].SubItems[13].Text);
                    string personelresmi = Convert.ToString(listView1.Items[i].SubItems[14].Text);
                    pictureBox1.ImageLocation = personelresmi;
                    
                    

                    personel.brütmaashesapla();
                    personel.gelirvegisihesapla();
                    personel.damgavergisihesapla();
                    personel.emeklikesintisihesaplama();
                    personel.netmaashesaplama();

                    maas.Text = Convert.ToString(personel.netmaas + " ₺ ");
                    brütsonuclbl.Text = Convert.ToString(personel.brütmaas);
                    damgavergisisonuclbl.Text = Convert.ToString(personel.damgavergisi);
                    gelirvergisisonuclbl.Text = Convert.ToString(personel.gelirvergisi);
                    emeklikesintisisonuclbl.Text = Convert.ToString(personel.emeklikesintisi);


                }

            }

        }


    }
}