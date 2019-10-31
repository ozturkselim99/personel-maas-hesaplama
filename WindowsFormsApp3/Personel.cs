using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Personel
    {
        public double brütmaas;
        public double netmaas;
        public double damgavergisi;
        public double gelirvergisi;
        public double emeklikesintisi;
        public string tc;
        public string ad;
        public string soyadi;
        public int yas;
        public double calısmasuresi;
        public char evlilikdurumu;
        public char esicalısıyormu;
        public int cocuksayisi;
        public double tabanmaas;
        public double makamtazminatı;
        public double idarigörevtazminati;
        public double fazlamesaisaati;
        public double fazlamesaisaatiücreti;
        public double vergimatrahı;

        public void brütmaashesapla()
        {
            //bekar.
            if (evlilikdurumu == 'B')
            {
                brütmaas = tabanmaas + makamtazminatı + idarigörevtazminati + (cocuksayisi * 30) + (fazlamesaisaati * fazlamesaisaatiücreti);
            }
            //evli ve eşi çalışıyor.
            if (evlilikdurumu == 'E' && esicalısıyormu == 'E')
            {
                brütmaas = tabanmaas + makamtazminatı + idarigörevtazminati + (cocuksayisi * 30) + (fazlamesaisaati * fazlamesaisaatiücreti);
            }
            //evli ve eşi çalışmıyor.
            if (evlilikdurumu == 'E' && esicalısıyormu == 'H')
            {
                brütmaas = tabanmaas + makamtazminatı + idarigörevtazminati + (cocuksayisi * 30) + (fazlamesaisaati * fazlamesaisaatiücreti) + 200;
            }
        }

        public void gelirvegisihesapla()
        {
            if (brütmaas <= 10000)
            {
                gelirvergisi = brütmaas * 15 / 100;
            }

            if (brütmaas >= 10000 && brütmaas < 20000)
            {
                gelirvergisi = brütmaas * 20 / 100;
            }

            if (brütmaas >= 20000 && brütmaas < 30000)
            {
                gelirvergisi = brütmaas * 25 / 100;
            }

            if (brütmaas >= 30000)
            {
                gelirvergisi = brütmaas * 30 / 100;
            }
        }

        public void damgavergisihesapla()
        {
            damgavergisi = brütmaas * 10 / 100;
        }
        public void emeklikesintisihesaplama()
        {
            emeklikesintisi = brütmaas * 15 / 100;
        }
        public void netmaashesaplama()
        {
            netmaas = brütmaas - (emeklikesintisi + gelirvergisi + damgavergisi);
        }
    }
}
