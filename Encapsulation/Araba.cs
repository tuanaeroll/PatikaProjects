using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba
    {
        private string _marka { get; set; }
        private string _model { get; set; }
        private string _renk { get; set; }
        private int _kapiSayisi;

        public Araba(string marka, string model, string renk)
        {
            _marka = marka;
            _model = model;
            _renk = renk;
        }

        public int KapiSayisi
        {
            get { return _kapiSayisi; }

            set
            {
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4 olabilir. Lütfen bu değerlerden birini giriniz.");
                    _kapiSayisi = -1;
                }
            }
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Arabamız {_marka} {_model} {_renk} renkte olup {_kapiSayisi} kapılıdır.");
        }
    }
}
