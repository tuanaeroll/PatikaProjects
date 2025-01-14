using WeekFourProject;

bool devam = true;

while (devam)
{
    Console.WriteLine("Telefon üretmek için 1'e, bilgisayar üretmek için 2'ye basınız.");
    string secim = Console.ReadLine();

    if (secim == "1")
    {
        
        Console.WriteLine("Telefon adı:");
        string telefonAd = Console.ReadLine();

        Console.WriteLine("Telefon açıklaması:");
        string telefonAciklama = Console.ReadLine();

        Console.WriteLine("İşletim Sistemi:");
        string telefonIsletimSistemi = Console.ReadLine();

        Console.WriteLine("Seri Numarası:");
        int telefonSeriNumarasi = int.Parse(Console.ReadLine());

        Console.WriteLine("TR Lisanslı mı? (Evet/Hayır):");
        bool trLisansli = Console.ReadLine().ToLower() == "evet";

        Telefon telefon = new Telefon(telefonAd, telefonAciklama, telefonIsletimSistemi, telefonSeriNumarasi, trLisansli);

        telefon.BilgileriYazdir();
        telefon.UrunAdiGetir();
        Console.WriteLine("Telefon başarıyla üretildi!");
    }
    else if (secim == "2")
    {
        Console.WriteLine("Bilgisayar adı:");
        string bilgisayarAd = Console.ReadLine();

        Console.WriteLine("Bilgisayar açıklaması:");
        string bilgisayarAciklama = Console.ReadLine();

        Console.WriteLine("İşletim Sistemi:");
        string bilgisayarIsletimSistemi = Console.ReadLine();

        Console.WriteLine("Seri Numarası:");
        int bilgisayarSeriNumarasi = int.Parse(Console.ReadLine());

        Console.WriteLine("USB giriş sayısını (2 veya 4):");
        int bilgisayarUsbGirisSayisi = int.Parse(Console.ReadLine());

        Console.WriteLine("Bluetooth var mı? (Evet/Hayır):");
        bool bilgisayarBluetooth = Console.ReadLine().ToLower() == "evet";

        Bilgisayar bilgisayar = new Bilgisayar(bilgisayarAd, bilgisayarAciklama, bilgisayarIsletimSistemi, bilgisayarSeriNumarasi, bilgisayarUsbGirisSayisi, bilgisayarBluetooth);

        bilgisayar.BilgileriYazdir();
        bilgisayar.UrunAdiGetir();
        Console.WriteLine("Bilgisayar başarıyla üretildi!");
    }
    else
    {
        Console.WriteLine("Geçersiz seçim.");
        continue;
    }

    Console.WriteLine("Başka bir ürün üretmek ister misiniz? (Evet/Hayır):");
    string devamSecim = Console.ReadLine().ToLower();
    if (devamSecim == "hayır")
    {
        devam = false;
        Console.WriteLine("İyi günler!");
    }
}