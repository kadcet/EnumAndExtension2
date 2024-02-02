class Program
{
    public static void Main(string[] args)
    {
        //SoruBir();

        //SoruIki();
       
        //SoruUc();
    }

    public static void SoruBir()
    {
        var arry = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var list = new List<string> { "Ahmet", "Mehmet", "Ali", "Tayfun", "Polat", "Hasan", "Sabri", "Cengiz", "Mahmut", "Salih" };

        Console.WriteLine("Array-List Yazdırma");
        for (int i = 0; i < arry.Length; i++)
        {
            for(int j = i; j ==i; j++)
            {
                Console.WriteLine($"{arry[i]} {list[j]}");
            }
           
        }

    }

    public static int SoruIki()
    {
        try
        {
            var list = new List<string> { "Ahmet", "Mehmet", "Ali", "Tayfun", "Polat", "Hasan", "Sabri", "Cengiz", "Mahmut", "Salih" };
            Console.WriteLine("1 ile 10 arasında 2 sayıyı gir");
            Console.WriteLine("Sayı 1 giriniz:");
            int gelenDeger1 = Convert.ToInt32(Console.ReadLine());
            int sayi1;
            Console.WriteLine("Sayı 2 giriniz:");
            int gelenDeger2 = Convert.ToInt32(Console.ReadLine());
            int sayi2;
            int sonuc;
            if (gelenDeger1<= 10 && gelenDeger1 >= 0 && gelenDeger2 <= 10 && gelenDeger2 >= 0)
            {
                sayi1 = gelenDeger1;
                sayi2 = gelenDeger2;
               
                if (sayi1 > sayi2)
                {
                    sonuc = sayi1 - sayi2;
                    for(int i = 0; i < list.Count; i++)
                    {
                        if (i == sonuc)
                        {
                            Console.WriteLine($"Cevap:{sonuc} sonucun listeye karşılık gelen değeri :{list[sonuc - 1]}");
                        }
                       
                    }
                }
                else if (sayi1==sayi2 || sayi2==sayi1)
                {
                    int sonuc2 = sayi1 - sayi2;
                    Console.WriteLine($"sonucun Listeye karşılık gelen değeri {sonuc2} olduğu için karşılığı yoktur");
                }
                else
                {
                    sonuc = sayi2 - sayi1;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i == sonuc)
                        {
                            Console.WriteLine($"Cevap:{sonuc} sonucun listeye karşılık gelen değeri :{list[sonuc - 1]}");
                        }
                        
                    }

                    return sayi1;
                }
                return 0;
            }
            else
            {
                Console.WriteLine("girilen her 2 değer 1 ile 10 arasında olmalıdır");
                return 0;
            }
          
        }
        catch (Exception )
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
        var limit = arry.Length + list.Count;
        var fark = gelenDeger - limit;
        if(fark<=10 && fark>0)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (i == fark - 1)
                {
                    Console.WriteLine($"Fark:{fark} Liste elemanı:{list[fark - 1]}");
                }
                
            }
        }
        else if (fark==0)
        {
            Console.WriteLine($"Fark:{fark} Liste elemanı Bulunamadı");
        }
        else
        {
            Console.WriteLine($"Fark:{fark } Liste elemanı Bulunamadı");
        }

    }
}