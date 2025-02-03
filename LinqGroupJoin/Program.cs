using LinqGroupJoin;

var students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ahmet", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Su", ClassId = 2 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
            new Student { StudentId = 4, StudentName = "Derin", ClassId = 3 },
            new Student { StudentId = 5, StudentName = "Hande", ClassId = 2 }
        };

var classes = new List<Class>
        {
            new Class { ClassId = 1, ClassName = "Matematik" },
            new Class { ClassId = 2, ClassName = "Türkçe" },
            new Class { ClassId = 3, ClassName = "Kimya" }
        };

var query = from @class in classes
            join student in students
            on @class.ClassId equals student.ClassId
            into studentGroup
            select new
            {
                ClassName = @class.ClassName,
                Students = studentGroup
            };

foreach (var item in query)
{
    Console.WriteLine($"Sınıf: {item.ClassName}");
    foreach (var student in item.Students)
    {
        Console.WriteLine($"  Öğrenci: {student.StudentName}");
    }
}
