using Odev2;
using Odev2.Extensions;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {
        //OdevBir();
        OdevIki();
    }

    public static void OdevBir()
    {
        var arry1 = new int[20];
        var liste = new List<int>();
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(arry1[i] = i);// 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19
        }
        for (int j = 0; j < arry1.Length; j++)
        {
            if (arry1[j] == 0)
            {
                liste.Add(j);
                continue;
            }
            liste.Add(arry1[j - 1] + j);//1+0=1 / 
        }
        foreach (int i in liste)
        {
            Console.WriteLine(i);
        }
    }



    public static void OdevIki()
    {
        var liste = new List<Kisi>()
        {
            new Kisi{Ad="Kadir",Soyad="Çetin",Telefon="05324774486 "},
            new Kisi{Ad="Umut",Soyad="Ergün",Telefon="5324158236"},
            new Kisi{Ad="Serkan",Soyad="Aydın",Telefon="053245 8565"},
            new Kisi{Ad="Hakan",Soyad="Turan",Telefon="5254712134"},
            new Kisi{Ad="Samet",Soyad="Türk",Telefon="04171475289"},
            new Kisi{Ad="Engin",Soyad="Sancar",Telefon="525 474512"},

        };

        Console.WriteLine("Telefon Numarasının İlk 5 hanesini Girin");
        string telefon = Console.ReadLine().TelefonFormat();
        if (telefon.Length > 5)
        {
            Console.WriteLine("Hatalı Format");
            return;
        }
        Console.WriteLine("doğru format");
        var kisiTelefon = liste.Where(x => x.Telefon.TelefonFormat().Substring(0,4) == telefon.Substring(0,4)).ToList();
        foreach (var item in kisiTelefon)
        {
            Console.WriteLine($"Ad:{item.Ad}Soyad:{item.Soyad} Telefon:{item.Telefon}");
        }
    }
}

//Soru 1 : Bir tane 20 eleman alabilecek kadar kapasitesi olan array tanımlayalım(içi boş olacak).
//Sonra bir döngü yaparak arrayın tüm elemanlarını döngüden gelen değer ile dolduralım(array full dolu olacak arrayin ilk elemanı 0 olabilir).
//Sonra bir boş bir liste tanımlayalım.
//Arrayin içi dolduktan sonra array for ile dönelim.
//Array döngüsü içinde listeyi arrayin bir önceki elemanın değeri ile o anda dönen değerinin toplamı ile dolduralım

//Soru 2 : Bir model tanımlayalım ve modelin propertylerinden biri telefon numarası olsun. Bir liste içinde bu modeli kullanalım ve içine bir kaç kayıt girelim (uydurma kayıtlar) kullanıcıdan bir telefon muarasının ilk 5 hanesini isteyelim ve bu liste içinde lambda kullanarak arama yaptırıp ilk 5 hanesi ile eşleşen numaralaı ekrana yazdıralım(dikkat telefon numarasında boşlukları temizlemeyi başında sıfır kontrolü yapmayı unutma)

// 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19 arry
// 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19 list

//0,1,3.......