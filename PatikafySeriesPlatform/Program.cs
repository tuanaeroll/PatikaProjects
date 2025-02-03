using PatikafySeriesPlatform;

List<Dizi> diziler = new List<Dizi>();
List<KomediDizi> komediDizileri = new List<KomediDizi>();
string devamEt;

Console.WriteLine("Dizi platformuna hoş geldiniz. Lütfen eklemek istediğiniz dizi bilgilerini giriniz..");

do
{
    Console.Write("Dizi Adı: ");
    string diziAdi = Console.ReadLine();

    Console.Write("Dizi Türü: ");
    string diziTuru = Console.ReadLine();

    Console.Write("Yönetmen: ");
    string yonetmen = Console.ReadLine();

    Console.Write("Yıl: ");
    int yil = int.Parse(Console.ReadLine());

    Dizi yeniDizi = new Dizi(diziAdi, diziTuru, yonetmen, yil);
    diziler.Add(yeniDizi);

    if (diziTuru.ToLower() == "komedi")
    {
        KomediDizi komediDizi = new KomediDizi(diziAdi, diziTuru, yonetmen);
        komediDizileri.Add(komediDizi);
    }

    Console.Write("Yeni bir dizi eklemek ister misiniz? (Evet/Hayır): ");
    devamEt = Console.ReadLine();

} while (devamEt.ToLower() == "evet");

var siraliKomediDizileri = komediDizileri.OrderBy(d => d.DiziAdi).ThenBy(d => d.Yonetmen).ToList();

Console.WriteLine("\nSıralanmış Komedi Dizileri:");
foreach (var komediDizi in siraliKomediDizileri)
{
    Console.WriteLine($"Dizi Adı: {komediDizi.DiziAdi}, Türü: {komediDizi.DiziTuru}, Yönetmen: {komediDizi.Yonetmen}");
}