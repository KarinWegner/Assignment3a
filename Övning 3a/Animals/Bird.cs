namespace Övning_3a.Animals
{
    internal class Bird : Animal
    {
        private double wingSpan;
        public Bird(string n, double w, int a, double wS) : base(n, w, a)
        {
            WingSpan = wS;
        }

        public double WingSpan { get { return wingSpan; } set { wingSpan = value; } }
        public override void DoSound()
        {
            Console.WriteLine("Tweet tweet!");
        }
        public override string Stats()
        {
            string stats = base.Stats();
            stats += $"\nWingspan:\t{wingSpan}";

            return stats;
        }
    }
}