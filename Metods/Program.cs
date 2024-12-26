// Geriye Değer Döndürmeyen Bir void metot.Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
static void GetSongLyrics()
{
    Console.WriteLine("Yaşamak dediğin üç beş kısa mutlu andan ibaret");
}
GetSongLyrics();

// Geriye Tamsayı Döndüren Bir metot.Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
static int GetRandomNumber()
{
    Random rnd = new Random();
    return rnd.Next(1, 100) % 2;
}
Console.WriteLine(GetRandomNumber());

// Parametre Alan ve Geriye Değer Döndüren Bir Metot.Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
static int Multiply(int number1, int number2)
{
    return number1 * number2;
}
Console.WriteLine(Multiply(5, 6));

// Parametre Alan ve Geriye Değer Döndürmeyen bir Metot.Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
static void WelcomeMessage(string name, string surname)
{
    Console.WriteLine($"Hoş Geldiniz {name} {surname}");
}
WelcomeMessage("Can", "kuşum");