namespace Övning_3a.Animals
{
    internal class Swan : Bird
    {
        private bool foundSoulMate;
        public Swan(string n, double w, int a, double wS, bool fSM) : base(n, w, a, wS)
        {
        }
        public bool FoundSoulMate { get { return foundSoulMate; } set { foundSoulMate = value; } }
    }
}