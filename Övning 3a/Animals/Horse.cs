namespace Övning_3a.Animals
{
    internal class Horse : Animal
    {
           private double jumpHeight;
        public Horse(string n, double w, int a, double jH) : base(n, w, a)
        {
            JumpHeight = jH;
        }
        public double JumpHeight { get { return jumpHeight; } set { jumpHeight = value; } }

        public override void DoSound()
        {
            Console.WriteLine("Neigh!");
        }
        public override string Stats()
        {
            string stats = base.Stats();
            stats += $"\nJump height:\t{jumpHeight}";

            return stats;
        }
    }
}