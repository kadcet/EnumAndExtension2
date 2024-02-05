using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.Extensions
{
    public static class Extensions
    {
        public static int YasHesapla(this DateTime dogumTarihi)
        {
            return DateTime.Today.Year - dogumTarihi.Year;
        }

        public static string ParayiYaziyaCevir(this decimal gelentutar)
        {
            decimal dectutar = Convert.ToDecimal(gelentutar);
            string strTutar = dectutar.ToString("F2").Replace('.', ',');    // Replace('.',',') ondalık ayraç ayracı           
            string lira = strTutar.Substring(0, strTutar.IndexOf(',')); //tutarın lira kısmı
            string kurus = strTutar.Substring(strTutar.IndexOf(',') + 1, 2);
            string yazi = "";
            string[] birler = { "", " BİR", " İKİ", " ÜÇ", " DÖRT", " BEŞ", " ALTI", " YEDİ", " SEKİZ", " DOKUZ" };
            string[] onlar = { "", " ON", " YİRMİ", " OTUZ", " KIRK", " ELLİ", " ALTMIŞ", " YETMİŞ", " SEKSEN", " DOKSAN" };
            string[] binler = { " KATİRİLYON", " TRİLYON", " MİLYAR", " MİLYON", " BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.
            int grupSayisi = 6;
            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.
            string grupDegeri;
            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";
                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + " YÜZ"; //yüzler
                if (grupDegeri == " BİR YÜZ") //biryüz düzeltiliyor.
                    grupDegeri = " YÜZ";
                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar
                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler
                if (grupDegeri != "") //binler
                    grupDegeri += "" + binler[i / 3];
                if (grupDegeri == " BİR BİN") //birbin düzeltiliyor.
                    grupDegeri = " BİN";
                yazi += grupDegeri;
            }
            if (yazi != "")
                yazi += " LİRA ";
            int yaziUzunlugu = yazi.Length;
            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];
            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];
            if (yazi.Length > yaziUzunlugu)
                yazi += " KURUŞ";
            else
                yazi += "";
            return yazi;
        }
    }
}
