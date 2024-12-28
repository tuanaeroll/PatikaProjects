// 1 - Aşağıdaki çıktıyı yazan bir program.
Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın?");

// 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

string text = "Tuana";
int number = 26;
Console.WriteLine($"Ben {text}, yaşım {number}");

// 3 - Rastgele bir sayı üretip , ekrana yazdırınız.

Random rnd = new Random();
int random = rnd.Next(0,100);
Console.WriteLine(random);

// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

Random rnd2 = new Random();
int random2 = rnd.Next(0, 100);
Console.WriteLine(random2%3);

// 5 - Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

Console.WriteLine("Lütfen yaşınızı giriniz:");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}

// 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i+1}-> Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.WriteLine("Bir isim giriniz");
string name1 = Console.ReadLine();
Console.WriteLine("Bir isim daha giriniz");
string name2 = Console.ReadLine();
Console.WriteLine($"İlk isim: {name1}, İkinci isim: {name2}");
// Geçici bir variable tanımlayarak daha sonra name2'ye atayacağımız name1'i tutuyoruz.
string gecici = name1;
name1 = name2;
name2 = gecici;
Console.WriteLine($"Yer değiştirilmiş haliyle İlk isim: {name1}, İkinci isim:  {name2}");

// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int Add(int num1, int num2)
{
    return num1 + num2;
}

// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

Console.WriteLine("Lütfen true ya da false yazınız:");
string input = Console.ReadLine();

string result = BooleanToString(input);
Console.WriteLine(result);
string BooleanToString(string value)
{
    if (value == "true")
    {
        return "Kullanıcı true değeri girdi.";
    }
    else if (value == "false")
    {
        return "Kullanıcı false değeri girdi.";
    }
    else
    {
        return "Geçersiz bir değer girdiniz.";
    }
}

// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.WriteLine("Lütfen 3 kişinin yaşlarını sırayla giriniz:");
int age1 = Convert.ToInt32(Console.ReadLine());
int age2 = Convert.ToInt32(Console.ReadLine());
int age3 = Convert.ToInt32(Console.ReadLine());
int Elder(int age1, int age2, int age3)
{
    return Math.Max(age1, Math.Max(age2, age3));
}

int eldest = Elder(age1, age2, age3);
Console.WriteLine($"En yaşlı kişi {eldest} yaşındadır.");

// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int max = Max();
Console.WriteLine("En büyük sayı: " + max);
    int Max()
{
    int max = int.MinValue;
    while (true)
    {
        Console.WriteLine("Lütfen bir sayı giriniz, çıkmak istiyorsanız 1001 yazınız:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 1001)
        {
            break;
        }
        max = Math.Max(max, number);
    }
    return max;
}

// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

Console.WriteLine("İki tane isim giriniz:");
string isim1 = Console.ReadLine();
string isim2 = Console.ReadLine();
Console.WriteLine($"İlk isim: {isim1}, İkinci isim: {isim2}");
Change(ref isim1,ref isim2);
Console.WriteLine($"Yer değiştirdikten sonra: İlk isim: {isim1}, İkinci isim: {isim2}");
void Change(ref string name1,ref string name2)
{
    string temp = name1;
    name1 = name2;
    name2 = temp;
}

// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

Console.WriteLine("Bir sayı giriniz:");
int number2 = Convert.ToInt32(Console.ReadLine());
bool result2 = TekmiCiftmi(number2);
Console.WriteLine($"Sayınız çift ise true, tek ise false yazısını göreceksiniz:\n{result2}");
bool TekmiCiftmi(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

Console.WriteLine("Hızınızı giriniz:");
int speed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zamanı giriniz:");
int time = Convert.ToInt32(Console.ReadLine());

int distance = Distance(speed, time);
Console.WriteLine($"Gidilen yol: {distance}");
int Distance(int speed, int time)
{
    return speed * time;
}

// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

Console.WriteLine("Dairenin yarıçapını giriniz:");
int radius = Convert.ToInt32(Console.ReadLine());
double area = Area(radius);
Console.WriteLine($"Dairenin alanı: {area}");
double Area(int radius)
{
    return Math.PI * radius * radius;
}

// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string text2 = "Zaman bir GeRi SayIm";
Console.WriteLine(text2.ToUpper());
Console.WriteLine(text2.ToLower());

// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string text3 = "    Selamlar   ";
text3 = text3.Trim();
Console.WriteLine(text3);