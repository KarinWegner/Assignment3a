using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Övning_3a;

namespace Övning_3a
{
    internal class Person : IPerson
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set 
            { 
                age = value; 
                if (age < 1)
                {
                    age = 1;
                }
            }
        }
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
              
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
