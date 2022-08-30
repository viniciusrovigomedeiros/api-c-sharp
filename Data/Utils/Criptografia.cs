using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utils
{
    internal class Criptografia
    {
        public static string Criptografar(string entrada)
        {
            MD5 md5 = MD5.Create();
            byte[] EntradaBytes = Encoding.UTF8.GetBytes(entrada);
            byte[] rash = md5.ComputeHash(EntradaBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rash.Length; i++)
            {
                sb.Append(rash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
