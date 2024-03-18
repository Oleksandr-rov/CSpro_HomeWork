using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; }
        public GenderType Gender { get; set; }

        public User()
        {
            Age = 30;
        }

        public User(string firstName, string lastName, int age, GenderType gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old. I am {Gender}.";
        }
    }
}
