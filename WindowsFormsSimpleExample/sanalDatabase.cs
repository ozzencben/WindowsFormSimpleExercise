using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms2
{
    public class sanalDatabase
    {
        public static List<user> kullaniciTablo = new List<user>();

        static sanalDatabase()
        {
            kullaniciTablo.Add(new user()
            {
                ıd = 1,
                name = "evrim",
                lastname = "dönmezer",
                username = "ozzenc",
                password = "1",
                aciklama = "evrim dönmezer kullanıcı profili"
            });

            kullaniciTablo.Add(new user()
            {
                ıd = 2,
                name = "özenç",
                lastname = "dönmezer",
                username = "ozzenc",
                password = "2",
                aciklama = "özenç dönmezer kullanıcı profili"
            });

            kullaniciTablo.Add(new user()
            {
                ıd = 3,
                name = "yüksel",
                lastname = "dönmezer",
                username = "ozzenc",
                password = "3",
                aciklama = "yüksel dönmezer kullanıcı profili"
            });
        }
    }
}
