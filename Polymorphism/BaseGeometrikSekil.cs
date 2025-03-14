namespace Polymorphism
{

    // Base class ımızı tanımlıyoruz.
    public class BaseGeometrikSekil
    {
        // Base class ımızın propertylerini tanımlıyoruz.
        public int Yukseklik { get; set; }
        public int Genislik { get; set; }

        // Base class ımızın virtual alan hesaplama metodu. Bunu dikdörtgen ve kare için kullanacağız.
        public virtual void AlanHesapla()
        {
            int alan = Yukseklik * Genislik;
            Console.WriteLine($"Alan -> {alan}");
        }
    }

    // Kare sınıfımızı tanımlıyoruz. BaseGeometrikSekil sınıfından miras alıyoruz.
    public class Kare : BaseGeometrikSekil
    {
        // Kare sınıfımızın constructor ını tanımlıyoruz.
        public Kare(int yukseklik, int genislik)
        {
            Yukseklik = yukseklik;
            Genislik = genislik;
        }
    }

    // Dikdörtgen sınıfımızı tanımlıyoruz. BaseGeometrikSekil sınıfından miras alıyoruz.
    public class Dikdortgen : BaseGeometrikSekil
    {
        // Dikdörtgen sınıfımızın constructor ını tanımlıyoruz.
        public Dikdortgen(int yukseklik, int genislik)
        {
            Yukseklik = yukseklik;
            Genislik = genislik;
        }
    }

    // Dik üçgen sınıfımızı tanımlıyoruz. BaseGeometrikSekil sınıfından miras alıyoruz.
    public class DikUcgen : BaseGeometrikSekil
    {
        // Dik üçgen sınıfımızın constructor ını tanımlıyoruz.
        public DikUcgen(int yukseklik, int genislik)
        {
            Yukseklik = yukseklik;
            Genislik = genislik;
        }
        // BaseGeometrikSekil sınıfındaki virtual alan hesapla metodunu override ediyoruz.
        public override void AlanHesapla()
        {
            double alan = (double)(Yukseklik * Genislik) / 2;
            Console.WriteLine($"Alan -> {alan}");
        }
    }
}
