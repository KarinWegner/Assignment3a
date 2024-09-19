using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3a.Animals
{
    internal abstract class Animal
    {
        private string name;
        private double weight;
        private int age;

        public Animal(string n, double w, int a)
        {
            Name = n;
            Weight = w;
            Age = a;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();
        public virtual string Stats()
        {
            string stats;
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nName:\t\t{Name}");
           
            sb.Append($"\nWeight:\t\t{Weight}"); 
            sb.Append($"\nAge:\t\t{Age}");
            stats = sb.ToString();
            return stats;
        }
    }
}
