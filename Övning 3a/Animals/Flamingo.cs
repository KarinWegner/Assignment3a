namespace Övning_3a.Animals
{
    internal class Flamingo : Bird
    {
        private bool standingOnOneLeg;
        public Flamingo(string n, double w, int a, double wS, bool sOOL) : base(n, w, a, wS)
        {
        }
        public bool StandingOnOneLeg { get { return standingOnOneLeg; } set { standingOnOneLeg = value; } }
    }
}