using Odev;

class Program
{
    public static void Main(string[] args)
    {
        //SoruBir();

        //SoruIki();

        //SoruUc();
        //SoruBes();
        SoruAlti();
    }

    public static void SoruBir()
    {
        var arry = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var list = new List<string> { "Ahmet", "Mehmet", "Ali", "Tayfun", "Polat", "Hasan", "Sabri", "Cengiz", "Mahmut", "Salih" };

        Console.WriteLine("Array-List Yazdırma");
        for (int i = 0; i < arry.Length; i++)
        {
            var arryDonen = arry[i];
            if (arryDonen == 10)
            {
                continue;
            }
            Console.WriteLine($"{arry[i]} {list[arryDonen]}");


        }

    }

    public static int SoruIki()
    {
        try
        {
            var list = new List<string> { "Ahmet", "Mehmet", "Ali", "Tayfun", "Polat", "Hasan", "Sabri", "Cengiz", "Mahmut", "Salih" };
            Console.WriteLine("1 ile 10 arasında 2 sayıyı gir"); // 2,3,4,5,6,7,8,9
            Console.WriteLine("Sayı 1 giriniz:");
            int gelenDeger1 = Convert.ToInt32(Console.ReadLine()); //8    //3
            Console.WriteLine("Sayı 2 giriniz:");
            int gelenDeger2 = Convert.ToInt32(Console.ReadLine()); //2    //7

            if (gelenDeger1 >= 10 || gelenDeger1 <= 1) return 0;

            if (gelenDeger2 >= 10 || gelenDeger2 <= 1) return 0;

            int sonuc = gelenDeger2 - gelenDeger1;// 2-8=-6               // 7-3=4

            if (gelenDeger1 > gelenDeger2) // true                        // false  
            {
                sonuc = gelenDeger1 - gelenDeger2;  //8-2=6
            }

            Console.WriteLine(list[sonuc]);  // list[6]=Sabri
            return sonuc; // çıkış 6


        }
        catch (Exception)
        {
            return 0;
        }
    }

    public static void SoruUc()
    {
        var arry = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var list = new List<string> { "Ahmet", "Mehmet", "Ali", "Tayfun", "Polat", "Hasan", "Sabri", "Cengiz", "Mahmut", "Salih" };

        Console.WriteLine("20 ile 40 arasında 1 sayı gir");
        Console.WriteLine("Sayıyı giriniz:");
        int gelenDeger = Convert.ToInt32(Console.ReadLine());

        if (gelenDeger <= 20 || gelenDeger >= 40)  // 21,22,23,....37,38,39
        {
            Console.WriteLine("Girilen Değer 20 ile 40 arasında olmalıdır");
            return;
        }
        var toplamElemanSayisi = list.Count + arry.Length; // 20 

        var fark = gelenDeger - toplamElemanSayisi; // min=21-20=1 , Max=39-20=19

        //fark olasılıkları = 1,2,3,4,5,6,7,8,9,   10,11,12,13,14,15,16,17,18,19

        if (fark < list.Count)
        {
            Console.WriteLine($"Fark:{fark} Liste elemanı:{list[fark]}");
            return;
        }
        Console.WriteLine($"Fark:{fark} Liste elemanı Bulunamadı");
    }

    public static void SoruDort()
    {
        var arry = new int[] { 1, 6, 2, 4, 9, 6, 10, 21 }; //8
        var list = new List<string> { "Ahmet", "Mehmet", "Ali", "Tayfun", "Polat", "Hasan", "Sabri", "Cengiz", "Mahmut", "Salih", "Kadir", "Üzeyir", "Cevahir", "Zakir", "Seyfi" };//15

        Console.WriteLine("23 ile 50 arasında 1 sayı gir"); //24,25,26,......46,47,48,49 beklenen aralık
        Console.WriteLine("Sayıyı giriniz:");
        int gelenDeger = Convert.ToInt32(Console.ReadLine()); //49

        if (gelenDeger <= 23 || gelenDeger >= 50)//false         
        {
            Console.WriteLine("Girilen Değer 23 ile 50 arasında olmalıdır");
            return;
        }

        var fark = gelenDeger - (arry.Length + list.Count);//49-23=26

        if (fark <= list.Count) // false
        {
            Console.WriteLine(list[fark]); // girmedi
            return;
        }
        Console.WriteLine(fark);//26

    }

    public static void SoruBes()
    {
        var kisiListesi = new List<SoruFive>()
        {
            new SoruFive{AdSoyad="Umut Ergün",DogumTarihi=new DateTime(1985,05,15),Telefon="05354052585"},
            new SoruFive{AdSoyad="Kadir Çetin",DogumTarihi=new DateTime(1988,07,05),Telefon="05464123296"},
            new SoruFive{AdSoyad="Ali Uçar",DogumTarihi=new DateTime(1965,05,15),Telefon="05354052585"},
            new SoruFive{AdSoyad="Veli Kaçar",DogumTarihi=new DateTime(1985,05,15),Telefon="05354052585"},
            new SoruFive{AdSoyad="Mehmet Aydın",DogumTarihi=new DateTime(1985,05,15),Telefon="05354052585"},


        };

        Console.WriteLine("0 dahil 9 a kadar değer girin");
        var gelenDeger = Convert.ToInt32(Console.ReadLine());// 2
        if (gelenDeger < 0 || gelenDeger > 8)                                       // 0,1,2,3,4,5,6,7,8
        {
            Console.WriteLine("Girilen Değer 0 ile 9 arasında olmalıdır");
            return;
        }
        var listeMaxIndex = kisiListesi.Count() - 1; //4
        if (gelenDeger <= listeMaxIndex)
        {
            for (int i = gelenDeger; i < kisiListesi.Count; i++)
            {
                Console.WriteLine($"AdSoyad:{kisiListesi[i].AdSoyad}");

            }
            return;
        }
        Console.WriteLine("Aranan değerde kayıt bulunamamıştır");
        return;

        // model :  SoruFive isimli bir model içindeki prop lar adsoyad,telefon,dogumtarihi
        // model tipinde bir listemiz olsun ve bu liste 5 elemanı olsun
        // kullanıcıdan 0 dahil 0 dan 9 a kadar bir değer isteyelim 0 dahil 9 hariç
        //girilen değer listenin maksimum indexinden küçük eşit ise  listenin o indexinden başlayarak kalan elemanlarının adsoyadı ekrana yazsın değil ise aranan değerde kayıt bulunamamaıştır uyarısı versin.

    }


    public static void SoruAlti()
    {
        var kisiListesi = new List<SoruFive>()
        {
            new SoruFive{KayitNo=10, AdSoyad="Umut Ergün",DogumTarihi=new DateTime(1985,05,15),Telefon="05354052585"},
            new SoruFive{KayitNo=12,AdSoyad="Kadir Çetin",DogumTarihi=new DateTime(1988,07,05),Telefon="05464123296"},
            new SoruFive{KayitNo=13,AdSoyad="Ali Uçar",DogumTarihi=new DateTime(1965,05,15),Telefon="05354052585"},
            new SoruFive{KayitNo=14,AdSoyad="Veli Kaçar",DogumTarihi=new DateTime(1985,05,15),Telefon="05354052585"},
            new SoruFive{KayitNo=15,AdSoyad="Mehmet Aydın",DogumTarihi=new DateTime(1985,05,15),Telefon="05354052585"},


        };

        Console.WriteLine("Lütfen Kişi Kayıt Numarasını Giriniz");
        var gelenDeger = Convert.ToInt32(Console.ReadLine());//2


        /* LAMBDa kullanımı */
        var kisi = kisiListesi.FirstOrDefault(x => x.KayitNo == gelenDeger); //where 
        Console.WriteLine(kisi?.AdSoyad);


        /* LAMBDa kullanımı */

        /* UZUN KULLANIM ŞEKLİ */
        for (int i = 0; i < kisiListesi.Count; i++)
        {
            if (gelenDeger == kisiListesi[i].KayitNo )
            {
                Console.WriteLine($"AdSoyad:{kisiListesi[i].AdSoyad}");
                return;
            }
            
        }

        Console.WriteLine("Girilen Kayıt numarası bulunamadı");

        /* UZUN KULLANIM ŞEKLİ */

        //girilen kayıt numarasına ait kişi kartını ekrana yazdırın


        
         

    }


}