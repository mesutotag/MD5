using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5_SIFRELEME
{
    public class Md5Sifreleme
    {
        public static string md5(string TxtAlınacak)
        {
            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk
            MD5CryptoServiceProvider md5sifreleme = new MD5CryptoServiceProvider();

            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] bt = Encoding.UTF8.GetBytes(TxtAlınacak);

            // dizinin hash'ini hesaplattık.
            bt = md5sifreleme.ComputeHash(bt);
            
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk
            StringBuilder sb = new StringBuilder();

            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük
            foreach (byte b in bt)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();

        }

    }
}
