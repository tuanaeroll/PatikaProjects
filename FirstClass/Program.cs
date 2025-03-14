using FirstClass;

Person student1 = new Person
{
    Name = "Phoebe",
    Surname = "Buffay",
    BirthYear = 1970
};

Person student2 = new Person
{
    Name = "Ross",
    Surname = "Geller",
    BirthYear = 1967
};

Person student3 = new Person
{
    Name = "Monica",
    Surname = "Geller",
    BirthYear = 1969
};

Person teacher1 = new Person
{
    Name = "Chandler",
    Surname = "Bing",
    BirthYear = 1965
};

Person teacher2 = new Person
{
    Name = "Joey",
    Surname = "Tribiane",
    BirthYear = 1969
};

Person teacher3 = new Person
{
    Name = "Rachel",
    Surname = "Green",
    BirthYear = 1969
};

Console.WriteLine("Öğrenci Bilgileri:");
student1.PrintInfo();
student2.PrintInfo();
student3.PrintInfo();

Console.WriteLine("\nÖğretmen Bilgileri:");
teacher1.PrintInfo();
teacher2.PrintInfo();
teacher3.PrintInfo();
