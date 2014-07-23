﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string fn, string ln, int age)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
        }

        public override string ToString()
        {
            return String.Format("{0}  {1}  {2}", FirstName,LastName, Age);
        }
    }
}
