using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "BELLIL",
                FirstName = "Nabil",
                DateOfBirth = new DateTime(1986,11,24)
            };

            GetAge age = new GetAge();

            Console.WriteLine("Nom: {0}, Prénom: {1}, Age: {2} ans", student.Name, student.FirstName, age.Age(student));

            Console.ReadLine();
        }
    }
}
