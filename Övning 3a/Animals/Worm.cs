namespace Övning_3a.Animals
{
    internal class Worm:Animal
    {
        private double crawlSpeed;
        public Worm(string n, double w, int a, double cs) : base(n, w, a)
        {
            CrawlSpeed = cs;
        }
        public double CrawlSpeed { get { return crawlSpeed; } set { crawlSpeed = value; } }

        public override void DoSound()
        {
            Console.WriteLine("~~~~");
        }
        public override string Stats()
        {
            string stats = base.Stats();
            stats += $"\nCrawl speed:\t{crawlSpeed}";

            return stats;
        }
    }
}