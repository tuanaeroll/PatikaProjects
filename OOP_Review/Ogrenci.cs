namespace OOP_Review
{
    internal class Ogrenci
    {

        // Constructor -> Yapıcı Metot
        // Geri dönüş tipi yok, void bile değil.
        // Öğrenci demek için hangi özellikler olmalı onu listeleyeceğiz.
        // Class ile aynı isimde olmak zorunda.
        // tek sefer tetiklenir, class newlenirken ve zorunlu olarak.
        // Default Consturctor -> Parametresiz Constructor = her classta başka constructor tanımlamazsak default olarak bu çalışır. Hiçbir parametre almaz.
        // Eğer parametreli bir constructor tanımlıyorsan ama default boş cons da kullanmak istiyorsan artık onu da yazmalısın.


        // Aynı zamanda bu 2 constructor ı yazarken METHOD OVERLOADING işlemi yapıyoruz.
        public Ogrenci()
        {


        }

        public Ogrenci(string isim, int yas)
        {
            Isim = isim;
            Yas = yas;
        }


        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
        public string Hobi { get; set; }
        public bool GozlukluMu { get; set; }

        public void KendiniTanit()
        {
            Console.WriteLine($"Benim adım {Isim} {Soyisim}, {Yas} yaşındayım. Hobilerimden biri {Hobi}. Gozluk takma durumum: {GozlukluMu}");
        }
    }
}
