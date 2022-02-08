using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclass282022
{
    public class Person : IEquatable<Person>
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get => $"{FirstName} {LastName}"; }


        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public bool Equals(Person other)
        {
           return this.FirstName == other.FirstName && this.LastName == other.LastName;
        }
    }
}
