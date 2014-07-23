﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Person> l1 = new List<Person>();
            l1.Add(new Person("Ann", "Ray", 20));
            l1.Add(new Person("Cary", "I", 12));
            l1.Add(new Person("Helen", "Carr", 19));
            List<Person> l2 = new List<Person>();
            l2.Add(new Person("John", "Doz", 20));
            l2.Add(new Person("Ray", "Smith", 19));
            l2.Add(new Person("Viki", "Ol", 18));
            Group gr1 = new Group(GroupNames.BackEnd, l1);
            Group gr2 = new Group(GroupNames.FrontEnd, l2);
            List<Group> glist = new List<Group>();
            glist.Add(gr1);
            glist.Add(gr2);
            var queryresult = from p in glist select p.Students.Average(s => s.Age);
            foreach (int d in queryresult)
            {
                Console.WriteLine(d.ToString());
            }
            Console.ReadLine();
        }
            
    }
}
