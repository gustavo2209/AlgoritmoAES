using Algoritmos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoAES
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str_encrypted = Aes.Encrypt("Gustavo Chimoy");
            //Console.WriteLine(str_encrypted);

            string str_dencrypt = Aes.Decrypt("5i4caZKiasrlLlZNbthzlw==");
            Console.WriteLine(str_dencrypt);

            Console.ReadKey();
        }
    }
}
