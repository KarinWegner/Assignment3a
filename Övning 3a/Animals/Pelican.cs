namespace Övning_3a.Animals
{
    internal class Pelican : Bird
    {
        private double beakStorageCapacity;
        public Pelican(string n, double w, int a, double wS, double bSC) : base(n, w, a, wS)
        {
            BeakStorageCapacity = bSC;
        }
        public double BeakStorageCapacity { get { return beakStorageCapacity; } set { beakStorageCapacity = value; } }
    }
}