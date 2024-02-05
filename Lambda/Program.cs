using Lambda.Extensions;
using Lambda.Helper;
using Lambda.Model;

public class Program
{
    public static void Main(string[] args)
    {
        KisiKayitlari();
    }
   
    private static void KisiKayitlari()
    {
        var kisilerTablosu = new List<KisiKarti>()
        {
            new KisiKarti {KayitNo=1, Ad="Umut", Soyad="Ergün",Sermaye=500000.50M, Adres="Bursa", DogumGun=20, DogumAyi=9,DogumYili=1983,Email="abc@mail.com", TelefonNo="0506 591 9890",KayitKartTipi=Enums.KartTipi.Aile},
            new KisiKarti {KayitNo=2, Ad="Kadir", Soyad="Çetin",Sermaye=250000.20M, Adres="Bursa", DogumGun=10, DogumAyi=10,DogumYili=1987,Email="kadir@mail.com", TelefonNo="0 507 123 9890",KayitKartTipi=Enums.KartTipi.Diger },
            new KisiKarti {KayitNo=3, Ad="Ahmet", Soyad="Uçar",Sermaye=150000.30M, Adres="İstanbul", DogumGun=5, DogumAyi=2,DogumYili=1990,Email="ahmet@mail.com", TelefonNo=" 0532 321 76 47",KayitKartTipi=Enums.KartTipi.IsArkadaslari },
            new KisiKarti {KayitNo=4, Ad="Mehmet", Soyad="Kaçar",Sermaye=50250, Adres="Ankara", DogumGun=10, DogumAyi=5,DogumYili=1992,Email="mehmet@mail.com", TelefonNo="0531 567 4132",KayitKartTipi=Enums.KartTipi.IsArkadaslari },
            new KisiKarti {KayitNo=5, Ad="Veli", Soyad="Yilmaz",Sermaye=25450, Adres="Ankara", DogumGun=15, DogumAyi=7,DogumYili=1985,Email="veli@mail.com", TelefonNo="05426218524",KayitKartTipi=Enums.KartTipi.IsArkadaslari },
            new KisiKarti {KayitNo=6, Ad="Vural", Soyad="Kaya",Sermaye=11000, Adres="Kocaeli", DogumGun=7, DogumAyi=11,DogumYili=1982,Email="vural@mail.com", TelefonNo="533751 2895",KayitKartTipi=Enums.KartTipi.OkulArkadaslari }
        };

        #region KayıtNumarasınaGöreTümKayıtlarıAlma
        Console.WriteLine("Kişiye Ait Kayıt Numarasını Girin:");
        var girilenKayitNoString = Console.ReadLine();
        var girilenKayitNoInt = Convert.ToInt32(girilenKayitNoString);

        var listedeBulunanKayitNumarasi_ile_eslesenler_listesi = kisilerTablosu.Where(x => x.KayitNo == girilenKayitNoInt);
        // kayıt eşleştirme ve sorgulama dönüş tipi her zaman verdiğimiz liste tipi neyse aynı tipte liste olarak çıktı verir
        foreach (var item in listedeBulunanKayitNumarasi_ile_eslesenler_listesi)
        {
            Console.WriteLine($"Girilen Kayıt Nolar:{item.KayitNo} Bulunan Kayıtlar:{item.Ad}");
        }
        Console.WriteLine($"Etkilenen Kayıt Sayısı:{listedeBulunanKayitNumarasi_ile_eslesenler_listesi.Count()}"); 
        #endregion

        #region KayıtNmarasınaGöreTekKayıtAlma
        var kisiKarti = kisilerTablosu.FirstOrDefault(x => x.KayitNo == girilenKayitNoInt);
        // Tek bir kişi tablosu geldiği için foreach kullanmadık.Zaten 1 tane
        Console.WriteLine($"Girilen Kayıt No:{girilenKayitNoInt} Bulunan Kayıt:{kisiKarti.Ad}"); 
        #endregion

        #region ŞehireGöre
        Console.WriteLine("Hangi İl Kayıtları Gelsin");
        var gelenIl = Console.ReadLine();

        //var illereGore= kisilerTablosu.Where(x => x.Adres == gelenIl && x.KayitNo==girilenKayitNoInt);
        var illereGore = kisilerTablosu.Where(x => x.Adres == gelenIl);

        var hlp = new Helper();
        foreach (var l in illereGore)
        {
            var dogumTarihi = hlp.DogumTarihi(l.DogumYili, l.DogumAyi, l.DogumGun);
            var yas = dogumTarihi.YasHesapla();
            var yaziyiTutaraCevirme = l.Sermaye.ParayiYaziyaCevir();
            Console.WriteLine($"Ad: {l.Ad} Adres:{l.Adres} Doğum tarihi:{dogumTarihi} Yaşı:{yas} Sermaye Tutarı:{l.Sermaye} SermayeYazıyla:{yaziyiTutaraCevirme}");
        }
        Console.WriteLine($"Eşlesen Kayıt Sayısı:{illereGore.Count()}");
        #endregion

        #region SermayeyeGöre
        Console.WriteLine("Sermayesi Kaç Tl üstü olanlar gelsin");
        var gelenSermaye = Convert.ToDecimal(Console.ReadLine());
        var sermayeyeGore = kisilerTablosu.Where(x => x.Sermaye > gelenSermaye);
        foreach (var s in sermayeyeGore)
        {
            var dogumTarihi = hlp.DogumTarihi(s.DogumYili, s.DogumAyi, s.DogumGun);
            var yas = dogumTarihi.YasHesapla();
            var yaziyiTutaraCevirme = s.Sermaye.ParayiYaziyaCevir();
            Console.WriteLine($"Ad: {s.Ad} Adres:{s.Adres} Doğum tarihi:{dogumTarihi} Yaşı:{yas} Sermaye Tutarı:{s.Sermaye} SermayeYazıyla:{yaziyiTutaraCevirme}");
        }
        Console.WriteLine($"Eşleşen Kayıt Sayısı:{sermayeyeGore.Count()}");
        #endregion

       

    }
}
