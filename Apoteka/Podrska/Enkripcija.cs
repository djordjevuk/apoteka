using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Podrska
{
    public class Enkripcija
    {
        public static string enkriptujLozinku(string lozinka)
        {
            SHA256Managed kripcija = new SHA256Managed();
            StringBuilder hes = new StringBuilder();
            byte[] kript = kripcija.ComputeHash(Encoding.UTF8.GetBytes(lozinka), 0, Encoding.UTF8.GetByteCount(lozinka));
            foreach (byte b in kript)
            {
                hes.Append(b.ToString("x2"));
            }
            return hes.ToString();
        }
    }
}
