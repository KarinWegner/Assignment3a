using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Övning_3a;

namespace Övning_3a
{
    internal class PersonHandler
    {
        public static Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            SetAge(person, age);
            SetFName(person, fname);
            SetLName(person, lname);
            SetHeight(person, height);
            SetWeight(person, weight);

            return person;
        }
        public static void SetAge (Person pers, int age)
        {
            pers.Age = age;
        }
        public static void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }
        public static void SetLName(Person pers, string lname) 
        {
            pers.LName=lname;
        }
        public static void SetHeight(Person pers, double height) 
        {
            pers.Height = height;
        }
        public static void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
