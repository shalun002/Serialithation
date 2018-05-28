using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializable
{
    [Serializable]
    public class Person
    {
        public Person()
        {

        }
        public string  Name { get; set; }
        public int Year { get; set; }

        public Person(string Name, int Year)
        {
            this.Name = Name;
            this.Year = Year;
        }
    }
    public class Human : Person
    {
        public Human (string Name, int Year) : base (Name, Year)
        {

        }
    }
}
