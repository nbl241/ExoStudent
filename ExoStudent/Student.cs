using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoStudent
{
    public sealed class Student
    {
        private string name;
        private string firstName;
        private DateTime dateOfBirth;

        public string Name { get => name; set => name = value; }

        public string FirstName { get => firstName; set => firstName = value; }

        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

      
    }
}
