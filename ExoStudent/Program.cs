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

            var m = (Student.Matiere)1;

            Student.SchoolBook schoolBook = new Student.SchoolBook
            {
                BookID = 1,
                BookTitle = "Clean Code",
                BookPrice = 180
            };

            Console.WriteLine("{0} {1} ans, {2}", student.GetfullName(), student.dateOfBirth(), m);

            Console.WriteLine("{0} {1} {2}", schoolBook.BookID, schoolBook.BookTitle, schoolBook);

            Console.ReadLine();
        }
    }
}
