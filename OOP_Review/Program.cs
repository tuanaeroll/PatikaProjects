using OOP_Review;
using OOP_Review.Concrete;
using OOP_Review.InheritanceModels;

// İçine öğrenci tipinde bir nesne oluşturabilirsin. Tıpkı string, int gibi Ogrenci de bir class. Yani bir tip.

// Bir Class ı New'lemek:

<<<<<<< HEAD
Ogrenci ogrenci1 = new Ogrenci();
=======
Ogrenci ogrenci1 = new Ogrenci(); 
>>>>>>> 484f76f2c474c95b3428624a26f1b44398b89055

ogrenci1.Isim = "Ajda";
ogrenci1.Soyisim = "Pekkan";
ogrenci1.Yas = 28;
ogrenci1.Hobi = "Sahne almak";
ogrenci1.GozlukluMu = false;

// Property'ye değer atarken set metodu tetiklenir.

// Newleyip değer atamanın farklı bir yolu:

<<<<<<< HEAD
Ogrenci ogrenci2 = new Ogrenci
{
    Isim = "Hande",
    Soyisim = "Yener",
=======
Ogrenci ogrenci2 = new Ogrenci 
{
    Isim = "Hande",
    Soyisim= "Yener",
>>>>>>> 484f76f2c474c95b3428624a26f1b44398b89055
    Hobi = "Dans",
    Yas = 26,
    GozlukluMu = true,
};


Console.WriteLine("----------------------------------------");

Ogrenci ogrenci3 = new Ogrenci("Hadise", 26);

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

ogrenci1.KendiniTanit();
ogrenci2.KendiniTanit();
ogrenci3.KendiniTanit();

Console.WriteLine("---------------------------------");

Hesap hesap = new Hesap();
hesap.Bakiye = 1000;
Console.WriteLine(hesap.Bakiye);
hesap.Bakiye = -1000;

Console.WriteLine("---------------------------");

Oyuncu oyuncu = new Oyuncu();
oyuncu.Ad = "Cem";
oyuncu.Soyad = "Yılmaz";
oyuncu.OynamaktaOlduguProje = "Kardeşim Benim";

oyuncu.RoportajVer();
oyuncu.RolYap();

Console.WriteLine("------------------------------");

Sarkici sarkici = new Sarkici();
sarkici.Ad = "Tarkan";
sarkici.Soyad = "Tevetoğlu";
sarkici.SonAlbum = "Yolla";

sarkici.RoportajVer();
sarkici.SarkiSoyle();

Console.WriteLine("-------------------------------");

Halk halk = new Halk();
halk.Ad = "Ali";
halk.Soyad = "Veli";

halk.RoportajVer();

Console.WriteLine("--------------------------------");

Kedi yeniKedi = new Kedi()
{
    Ad = "Pamuk",
    Tur = "British"
};

Kopek yeniKopek = new Kopek()
{
    Ad = "Hera",
    Tur = "Frenchie"
};

yeniKedi.SesCikar();
yeniKopek.SesCikar();

yeniKedi.YemekYe();
yeniKopek.YemekYe();

yeniKedi.Uyu();
yeniKopek.Uyu();

Sahip sahip = new Sahip();

Console.WriteLine("-----İlk Durum ----");
sahip.HayvanlariListele();

sahip.HayvanEkle(yeniKedi);
sahip.HayvanEkle(yeniKopek);

Console.WriteLine("--------Son Durum ----");
sahip.HayvanlariListele();
