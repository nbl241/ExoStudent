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

            Console.WriteLine("{0} {1} ans", student.GetfullName(), student.dateOfBirth());

            Console.ReadLine();
        }
    }
}
