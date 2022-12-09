namespace Abstract_factory_Diego_Hiriart.Classes
{
    class HighQualityRocket : Rocket
    {
        //Implement high quality rocket constructor
        public HighQualityRocket()
        {
            this.HighQuality = true;
            this.Damage = 245;
            this.BlastRadius = 11;
            this.Fuel = 100;
        }
        //Override SpendFuel method with low consumption
        protected override void SpendFuel()
        {
            Console.WriteLine("Spending rocket's fuel at 1.8 kg/s");
        }
    }
}