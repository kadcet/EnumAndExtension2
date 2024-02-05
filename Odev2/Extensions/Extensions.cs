using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2.Extensions
{
    public static class Extensions
    {
        public static string TelefonFormat(this string telefon)
        {
            if (!telefon.StartsWith("0"))
            {
                telefon= "0" + telefon;

                return telefon.Replace(" ","");
            }
            return telefon.Replace(" ", "");
        }

       
    }
}
