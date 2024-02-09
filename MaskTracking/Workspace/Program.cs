
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {

            SelamVer(isim:"Onder");
            int sonuc = Topla(5, 3);

            Console.ReadLine();
        }
        static void SelamVer(string isim  ) {

            Console.WriteLine("Merhaba"+isim);
        }
        static int Topla(int s1,int s2) {
            int sonuc =s1+s2;
            Console.WriteLine("Sonuc:" + sonuc);
            return sonuc;
        }


    }
    public class Vatandas
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DoğumYili { get; set; }
        public  long TcNo { get; set; }


    }
}
