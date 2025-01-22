//Kullanıcıdan bir sayı girmesini isteyen bir program yazın. Kullanıcı geçerli bir sayı girdiğinde bu sayının karesini ekrana yazdırınız. 

//Kullanıcı geçersiz bir giriş yaparsa (sayı yerine harf veya sembol girmesi gibi), "Geçersiz giriş! Lütfen bir sayı giriniz." şeklinde bir hata mesajı gösterini<

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