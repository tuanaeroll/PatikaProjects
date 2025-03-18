using DependencyInjection.Service;

public class Teacher : IOgretmen
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Teacher()
    {
        FirstName = "Ahmet";
        LastName = "Yılmaz";
    }

    public string GetInfo()
    {
        return $"Öğretmen: {FirstName} {LastName}";
    }
}