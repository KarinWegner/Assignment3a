namespace Övning_3a.Animals
{
    internal class Hedgehog:Animal
    {
        private int numberOfSpikes;
        public Hedgehog(string n, double w, int a, int Spikenum) : base(n, w, a)
        {
            NumberOfSpikes = Spikenum;
        }

        public int NumberOfSpikes { get { return numberOfSpikes; } set { numberOfSpikes = value; } }
        public override void DoSound()
        {
            Console.WriteLine("Squeak!");
        }
        public override string Stats()
        {
            string stats = base.Stats();
            stats += $"\nNumber of spikes:\t{numberOfSpikes}";

            return stats;
        }
    }
}