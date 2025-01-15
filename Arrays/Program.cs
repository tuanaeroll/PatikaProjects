// 10 tamsayı içeren bir Array oluşturuyoruz.
int[] tamSayilar = new int[10];
// Dizinin içini dolduruyoruz.
for ( int i = 1; i < tamSayilar.Length + 1; i++)
{
    tamSayilar[i-1] = i;
}
// Dizinin içeriğini yazdırıyoruz.
foreach (int sayi in tamSayilar)
{
    Console.WriteLine(sayi);
}
// Kullaıcıdan alınan değeri diziye ekleyecek kodu yazıyoruz.
Console.WriteLine("Diziye eklemek istediğiniz yeni bir tamsayı değeri giriniz:");
int yeniSayi = Convert.ToInt32(Console.ReadLine());
// Array.Resize ile diziyi genişletiyoruz
Array.Resize(ref tamSayilar, tamSayilar.Length + 1);
tamSayilar[tamSayilar.Length - 1] = yeniSayi;
// foreach ile yeni diziyi yazdırıyoruz.
foreach (int sayi in tamSayilar)
{
    Console.WriteLine(sayi);
}

// Diziyi sıralama
Console.WriteLine("---------------------------------");
// Sort metodu ile küçükten büyüğe sıralama yapabiliriz.
Array.Sort(tamSayilar);
// Reverse metodu ile tersine çevirerek büyükten küçüğe sıralama yapabiliriz.
Array.Reverse(tamSayilar);
// foreach ile sıralanmış diziyi yazdırıyoruz.
foreach (int sayi in tamSayilar)
{
    Console.WriteLine(sayi);
}