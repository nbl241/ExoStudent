using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoStudent
{
    public class GetAge
    {
        public int Age(Student s)
        {
            return (DateTime.Now.Year - s.DateOfBirth.Year);
        }
    }
}
