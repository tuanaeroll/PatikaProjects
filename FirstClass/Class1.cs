using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Person
    {
        private string name;
        private string surname;
        private int birthYear;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"İsim-> {name} {surname}\nDoğum Yılı-> {birthYear}");
        }
    }
}
