namespace Övning_3a.Animals
{
    internal class Wolf : Animal
    {

        private int packSize;
        public Wolf(string n, double w, int a, int pS) : base(n, w, a)
        {
            PackSize = pS;
        }
        public int PackSize { get { return packSize; } set { packSize = value; } }
        public override void DoSound()
        {
            Console.WriteLine("Awoo!");
        }
        public override string Stats()
        {
            string stats = base.Stats();
            stats += $"\nPack size:\t{packSize}";

            return stats;
        }
    }
}