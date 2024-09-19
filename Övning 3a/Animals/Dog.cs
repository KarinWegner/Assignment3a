namespace Övning_3a.Animals
{
    internal class Dog : Animal
    {
        private int tricksLearnt;
        public Dog(string n, double w, int a, int tL) : base(n, w, a)
        {
            TricksLearnt = tL;
        }
        public int TricksLearnt { get { return tricksLearnt; } set { tricksLearnt = value; } }
        public override void DoSound()
        {
            Console.WriteLine("Woof!");
        }
        public override string Stats()
        {
            string stats = base.Stats();
            stats += $"\nTricks Learnt:\t{tricksLearnt}";

            return stats;
        }
        public string Sit()
        {
            string result = "Sit boy!\nThe dog sat down!\nGood boy!";
            return result;
        }
    }
}