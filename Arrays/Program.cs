// 10 tamsayı içeren bir Array oluşturuyoruz.
int[] tamSayilar = new int[10];
// Dizinin içini dolduruyoruz.
for ( int i = 1; i < tamSayilar.Length; i++)
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
// Arrayler sabit boyutlu olduğu için yeni bir array oluşturup eski arrayi kopyalayıp yeni değeri ekleyeceğiz.
int[] yeniTamSayilar = new int[tamSayilar.Length + 1];
// Eski arrayin içeriğini yeni arraye kopyalıyoruz.
for (int i = 0; i < tamSayilar.Length; i++)
{
    yeniTamSayilar[i] = tamSayilar[i];
}
// Yeni değeri ekliyoruz.
yeniTamSayilar[tamSayilar.Length] = yeniSayi;
// foreach ile yeni diziyi yazdırıyoruz.
foreach (int sayi in yeniTamSayilar)
{
    Console.WriteLine(sayi);
}

// Diziyi sıralama

// Sort metodu ile küçükten büyüğe sıralama yapabiliriz.
Array.Sort(yeniTamSayilar);
// Reverse metodu ile tersine çevirerek büyükten küçüğe sıralama yapabiliriz.
Array.Reverse(yeniTamSayilar);
// foreach ile sıralanmış diziyi yazdırıyoruz.
foreach (int sayi in yeniTamSayilar)
{
    Console.WriteLine(sayi);
}