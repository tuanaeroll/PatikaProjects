using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    // Bebek sınıfını tanımlıyoruz.
    public class Bebek
    {
        // Bebek sınıfının özelliklerini tanımlıyoruz. Bunlara erişilmesi için get ve set metodlarını ekliyoruz. 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; private set; }

        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            Dogum();
        }

        public Bebek() 
        {
            Dogum();
        }

        public void Dogum ()  
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaaa");
            Console.WriteLine($"{Ad} {Soyad} bebek, {DogumTarihi}'nde dünyaya geldi.");
        }

    }
}
