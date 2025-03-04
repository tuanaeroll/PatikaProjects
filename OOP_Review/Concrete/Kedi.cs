using OOP_Review.Abstract;

namespace OOP_Review.Concrete
{
    internal class Kedi : BaseHayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine(Ad + "Meowww");
        }

        public override void YemekYe()
        {
            Console.WriteLine("Balık yiyor..");
        }
    }
}
