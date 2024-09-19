using Övning_3a.Animals;

namespace Övning_3a
{
    internal class WolfMan : Wolf, IPerson
    {
        public WolfMan(string n, double w, int a, int pS) : base(n, w, a, pS)
        {
        }
        public void Talk() 
        {
            Console.WriteLine("Totally rawr XD");
        }
    }
}