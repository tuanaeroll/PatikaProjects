using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review.InheritanceModels
{
    // BaseKatilimci -> Özelliklerin aktarıldığı Base Class - Miras Veren - Main Class
    // Oyunucu -> BaseKatilimci sınıfından miras alan sınıf - Miras Alan - Derived Class - Türetilmiş Class
    internal class Oyuncu : BaseKatilimci
    {
        public string OynamaktaOlduguProje { get; set; }

        public void RolYap()
        {
            Console.WriteLine(Ad + " " + Soyad + " rol yapıyor..");
        }

    }
}
