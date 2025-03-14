using OOP_Review.Abstract;
namespace OOP_Review.Concrete
{
    internal class Sahip
    {
        // Generic listler List<T> hangi tipi içine verirsen ona göre çalışır.
        List<BaseHayvan> _hayvanlar = new List<BaseHayvan>();

        public void HayvanEkle(BaseHayvan hayvan)
        {
            _hayvanlar.Add(hayvan);
            Console.WriteLine($"{hayvan.Ad} sahiplenildi.");
        }

        public void HayvanlariListele()
        {
            foreach(var hayvan in _hayvanlar)
            {
                Console.WriteLine("Sahiplenen Hayvanlar");
                Console.WriteLine(hayvan.Ad);
            }
        }
    }
}
