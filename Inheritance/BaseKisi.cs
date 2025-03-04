
namespace Inheritance
{
    public class BaseKisi
    {
        public string _ad { get; set; }
        public string _soyad { get; set; }

        public BaseKisi(string ad, string soyad)
        {
            _ad = ad;
            _soyad = soyad;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Kişinin adı ve soyadı -> {_ad} {_soyad}");
        }
    }

    public class Ogrenci : BaseKisi
    {
        public int OgrenciNumarasi;

        public Ogrenci(string ad, string soyad, int ogrenciNumarasi) : base(ad, soyad)
        {
            OgrenciNumarasi = ogrenciNumarasi;
        }

        public void NumaraYazdir()
        {
            BilgileriYazdir();
            Console.WriteLine($"Öğrenci numarası -> {OgrenciNumarasi}");
        }

    }

    public class Ogretmen : BaseKisi
    {
        public double _maas;

        public Ogretmen(string ad, string soyad, double maas) : base(ad, soyad)
        {
            _maas = maas;
        }

        public void MaasYazdir()
        {
            BilgileriYazdir();
            Console.WriteLine($"Öğretmenin maaşı -> {_maas:N0}");
        }
    }
}
