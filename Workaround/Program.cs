using Business.Concrete;
using Business.Abstract;
using System;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            SelamVer();

            Person person = new Person();
            person.FirstName = "Enes";
            person.LastName = "Dönmez";
            person.NationalIdentity = 123;
            person.DayOfBirthYear = 2002;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
        
            Console.ReadLine();
        }

        static void SelamVer()
        {
            Console.WriteLine("Selamlar");
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi= false;

            string ad = "Enes";
            string soyad = "Dönmez";
        }

        

        

        // Pascal Casing
        //public class Vatandas
        //{
        //    public string Ad { get; set; }
        //    public string Soyad { get; set; }
        //    public int DogumYili { get; set; }
        //    public long TcNo { get; set; } = 10;
        //}
    } 
}
