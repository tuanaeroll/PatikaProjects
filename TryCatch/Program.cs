bool IsValid = false;

while (!IsValid)
{
    try
    {

        Console.WriteLine("Bir sayı giriniz:");

        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Girdiğiniz sayının karesi: " + number * number);

        IsValid = true;
    }
    catch (Exception)
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }
    finally
    {
        Console.WriteLine("İşlem tamamlandı.");
    }
}
