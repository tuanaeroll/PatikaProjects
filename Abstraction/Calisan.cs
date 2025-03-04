namespace Abstraction
{
    // Abstract bir calışan sınıfı oluşturuldu.
    public abstract class Calisan
    {
        // Calisan sınıfının özellikleri tanımlandı.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        // Calisan sınıfının görevini tanımlayan abstract bir metot oluşturuldu.
        public abstract void Gorev();
    }
    // Calisan sınıfından türetilen Doktor sınıfı oluşturuldu.
    public class Doktor : Calisan
    {
        // Doktor sınıfının özellikleri tanımlandı.
        public Doktor(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }
        // Calisan sınıfından alınan görev metodu Doktor sınıfında uygulandı.
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, {Departman} departmanında doktor olarak çalışıyor.");
        }
    }

    // Calisan sınıfından türetilen Ogretmen sınıfı oluşturuldu.
    public class Ogretmen : Calisan
    {
        // Ogretmen sınıfının özellikleri tanımlandı.
        public Ogretmen(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }
        // Calisan sınıfından alınan görev metodu Ogretmen sınıfında uygulandı.
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, {Departman} departmanında öğretmen olarak çalışıyor.");
        }
    }

    // Calisan sınıfından türetilen Mimar sınıfı oluşturuldu.
    public class Mimar : Calisan
    {
        // Mimar sınıfının özellikleri tanımlandı.
        public Mimar(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        // Calisan sınıfından alınan görev metodu Mimar sınıfında uygulandı.
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}, {Departman} departmanında mimar olarak çalışıyor.");
        }
    }

}
