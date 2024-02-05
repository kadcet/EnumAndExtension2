using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.Helper
{
    public class Helper
    {
        public  DateTime DogumTarihi(int yil,int ay,int gun)
        {
            return new DateTime(yil, ay, gun);
        }
    }
}
