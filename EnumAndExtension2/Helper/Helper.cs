using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAndExtension2.Helper
{
    public class Helper
    {
        public DateTime TarihYazdir(int gun,int ay,int yil)
        {
            return new DateTime(yil,ay,gun);
        }

        public int YasHesapla(DateTime dateTime)
        {
            return DateTime.Today.Year - dateTime.Year;
        }
    }
}
