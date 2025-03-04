Console.WriteLine("Merhaba! Bu uygulamamızda sizden 5 kahve ismi girerek bir liste oluşturmanızı istiyoruz. Uygulama başlıyor...");

List<string> kahveler = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Lütfen bir kahve ismi giriniz.");
    string kahve = Console.ReadLine();
    kahveler.Add(kahve);
}

Console.WriteLine("Kahve İsimleri");
Console.WriteLine("**************");

foreach (string kahve in kahveler)
{
    Console.WriteLine(kahve);
}