using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Review.Abstract;

namespace OOP_Review.Concrete
{
    internal class Kopek : BaseHayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine(Ad + "Hav hav hav");
        }
    }
}
