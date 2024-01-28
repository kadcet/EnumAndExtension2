using EnumAndExtension2.Model;
using EnumAndExtensionTotarial.Bll.Extensions;
using System.ComponentModel;

class Program
{
    public static void Main(string[] args)
    {
        //VeriTabaniBaglanti(VeriTabaniTipleri.Mysql);
        //KayitOlustur(HesapKodlari.Banka,FaturaTipleri.Alis);
        KisiKayitlari();

    }

    private enum VeriTabaniTipleri
    {
        Mysql,
        Mssql,
        Oracle
    }



    private static void VeriTabaniBaglanti(VeriTabaniTipleri veriTabaniTipleri)
    {
        var connectionString = "";

        switch (veriTabaniTipleri)
        {
            case VeriTabaniTipleri.Mysql:
                connectionString = "Mysql e bağlandı";
                break;
            case VeriTabaniTipleri.Mssql:
                connectionString = "Mysql e bağlandı";
                break;
            case VeriTabaniTipleri.Oracle:
                connectionString = "Mysql e bağlandı";
                break;
        }
        Console.WriteLine(connectionString);
    }

    private enum HesapKodlari
    {
        Kasa = 100,
        Banka = 102,
        AlinanCekler = 101
    }

    private enum FaturaTipleri
    {
        [Description("Alış Faturası")]
        Alis,

        [Description("SAtıs Faturası")]
        Satis,

        [Description("Hizmet Faturası")]
        Hizmet
    }

    private static void KayitOlustur(HesapKodlari hesap, FaturaTipleri fatura)
    {
        Console.WriteLine(hesap);
        Console.WriteLine(Convert.ToInt32(hesap));
        Console.WriteLine(fatura.EnumAciklamasiniGetir());
    }

    private static void KisiKayitlari()
    {

        try
        {
            var kisilerTablosu = new List<KisiKarti>
        {
            new KisiKarti {KayitNo=1, Ad="Umut", Soyad="Ergün",Sermaye=500000, Adres="Bursa", DogumGun=20, DogumAyi=9,DogumYili=1983,Email="abc@mail.com", TelefonNo="0506 591 9890",KayitKartTipi=Enums.KartTipi.Aile},
            new KisiKarti {KayitNo=2, Ad="Kadir", Soyad="Çetin",Sermaye=250000, Adres="Bursa", DogumGun=10, DogumAyi=10,DogumYili=1987,Email="kadir@mail.com", TelefonNo="0 507 123 9890",KayitKartTipi=Enums.KartTipi.Diger },
            new KisiKarti {KayitNo=3, Ad="Ahmet", Soyad="Uçar",Sermaye=150000, Adres="İstanbul", DogumGun=5, DogumAyi=2,DogumYili=1990,Email="ahmet@mail.com", TelefonNo=" 0532 321 76 47",KayitKartTipi=Enums.KartTipi.IsArkadaslari },
            new KisiKarti {KayitNo=4, Ad="Mehmet", Soyad="Kaçar",Sermaye=50250, Adres="Ankara", DogumGun=10, DogumAyi=5,DogumYili=1992,Email="mehmet@mail.com", TelefonNo="0531 567 4132",KayitKartTipi=Enums.KartTipi.IsArkadaslari },
            new KisiKarti {KayitNo=5, Ad="Veli", Soyad="Yilmaz",Sermaye=25450, Adres="Ankara", DogumGun=15, DogumAyi=7,DogumYili=1985,Email="veli@mail.com", TelefonNo="05426218524",KayitKartTipi=Enums.KartTipi.IsArkadaslari },
            new KisiKarti {KayitNo=6, Ad="Vural", Soyad="Kaya",Sermaye=11000, Adres="Kocaeli", DogumGun=7, DogumAyi=11,DogumYili=1982,Email="vural@mail.com", TelefonNo="533751 2895",KayitKartTipi=Enums.KartTipi.OkulArkadaslari }
        };

            Console.WriteLine("Hangi Kayıt no Getirilsin");
            var girilenKayitNoInt = Convert.ToInt32(Console.ReadLine());
            var gelenKayit = kisilerTablosu.Where(x => x.KayitNo == girilenKayitNoInt).FirstOrDefault();
            Console.WriteLine($"Ad: {gelenKayit.Ad} Soyad: {gelenKayit.Soyad} Sermaye Tutarı:{gelenKayit.Sermaye}  Yazı ile:{Convert.ToString(gelenKayit.Sermaye).ParayiYaziyaCevir()}");

            Console.WriteLine("Sermayesi Kaç Lira Üstü olanlar Gelsin");
            var gelenSermaye = Convert.ToInt32(Console.ReadLine());
            var sermayeyeGoreGelen = kisilerTablosu.Where(x => x.Sermaye > gelenSermaye).ToList();

            foreach (var item in sermayeyeGoreGelen)
            {
                Console.WriteLine($"{item.Ad} Soyad:{item.Soyad} Sermaye:{item.Sermaye} Sermaye Yazı İle:{Convert.ToString(item.Sermaye).ParayiYaziyaCevir()}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata Oluştu");
        }

    }


}
