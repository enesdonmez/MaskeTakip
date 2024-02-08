using System;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vatandas vatandas = new Vatandas();
            Console.WriteLine(vatandas.TcNo);
        }

        // Pascal Casing
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; } = 10;
        }
    }
}
