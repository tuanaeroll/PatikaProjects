// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int i = 0;
while (i < 10)
{
    Console.WriteLine("Ben bu yazilim isini hallederim!!!");
    i++;
}
// 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int a = 1;
while (a <= 20)
{
    Console.WriteLine(a);
    a++;
}

// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int b = 1;
while (b < 20)
{
    if (b % 2 == 0)
    {
        Console.WriteLine(b);
    }
    b++;
}

// 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int c = 50;
int sum = 0;

while (c <= 150)
{
    sum += c;
    c++;
}

Console.WriteLine(sum);

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int d = 1;
int sumOdd = 0;
int sumEven = 0;

while (d < 120)
{
    if (d % 2 == 0)
    {
        sumEven += d;
    }
    else
    {
        sumOdd += d;
    }
    d++;
}
Console.WriteLine($"Çift sayıların toplamı:{sumEven}");
Console.WriteLine($"Çift sayıların toplamı:{sumOdd}");