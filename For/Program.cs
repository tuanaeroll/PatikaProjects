// For yapısı
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("Kendime inaniyorum, ben bu yazilim isini hallederim");
}

for (int i = 1; i < 21; i++)
{
    Console.WriteLine(i);
}

for (int i = 2; i < 21; i += 2)
{
    Console.WriteLine(i);
}

int sum = 0;
for (int i = 50; i <= 150; i++)
{
    sum += i;
}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {sum}");

int oddSum = 0;
int evenSum = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        evenSum += i;
    }
    else
    {
        oddSum += i;
    }
}

Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {oddSum}");
Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {evenSum}");