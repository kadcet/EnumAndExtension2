using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        OgrenciModel model = new OgrenciModel();
        model.AdSoyad = "Ali Uçar";
        model.Ders1 = 5;
        model.Ders2 = 6;
        model.Ders3 = 7;


        OrtalamaAl(model);
        TryCatch();
        
        
    }

    public static void TryCatch()
    {
        try
        {
            Console.WriteLine("Kod Çalıştı");

            var ogrenciler = new List<OgrenciModel>();

            ogrenciler.Add(new OgrenciModel { AdSoyad = "Kadir Çetin", Ders1 = 4, Ders2 = 5, Ders3 = 3 });
            ogrenciler.Add(new OgrenciModel { AdSoyad = "Umut Ergün", Ders1 = 5, Ders2 = 2, Ders3 = 3 });
            ogrenciler.Add(new OgrenciModel { AdSoyad = "Ali Uçar", Ders1 = 2, Ders2 = 2, Ders3 = 5 });
            ogrenciler.Add(new OgrenciModel { AdSoyad = "Veli kaçar", Ders1 = 2, Ders2 = 2, Ders3 = 2 });

            foreach (var ogrenci in ogrenciler)
            {
                //var ort = OrtalamaAl(ogrenci);
                //Console.WriteLine($"{ogrenci.AdSoyad} Kayıt Edildi Ders Notu Ortalaması :{ort}");
                Console.WriteLine($"kayıtlar:{ogrenci.AdSoyad}");
            }



        }
        catch (Exception e)
        {

            Console.WriteLine("kod hataya düştü hata kodu :" + e);
        }
        finally
        {
            Console.WriteLine("finally bloğuna uğradı ve bitirdi");
        }


    }

    private static int OrtalamaAl(OgrenciModel ogrenci)
    {
        try
        {
            return (ogrenci.Ders1 + ogrenci.Ders2 + ogrenci.Ders3) / (ogrenci.AdSoyad=="Ali Uçar" ? 0:3);
        }
        catch (Exception e)
        {
            throw new Exception(e.ToString());  // TryCatch metodunun Catch bloğuna düşecek
        }
        
    }

    public class OgrenciModel
    {
        public string AdSoyad { get; set; }

        public int Ders1 { get; set; }

        public int Ders2 { get; set; }

        public int Ders3 { get; set; }
    }
}