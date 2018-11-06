using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoStudent
{
    public sealed class Student : IStudent
    {
        private string name;
        private string firstName;

        public string Name { get => name; set => name = value; }

        public string FirstName { get => firstName; set => firstName = value; }

        public DateTime DateOfBirth { get; set; }

        public int dateOfBirth()
        {
            return (DateTime.Now.Year - DateOfBirth.Year);
        }

        public string GetfullName()
        {
            return string.Format("{0} {1}",FirstName, Name);
        }

        public enum Matiere : int
        {
            Anglais = 0,
            Mathematique = 1,
            Histoire = 2,
            Physique = 3,
        }

        public struct SchoolBook
        {
            public int BookID;
            public string BookTitle;
            public decimal BookPrice;
        }
    }
}
