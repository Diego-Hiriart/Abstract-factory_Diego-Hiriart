namespace Abstract_factory_Diego_Hiriart.Classes
{
    class RegularRocket : Rocket
    {
        //Implement regular quality rocket constructor
        public RegularRocket()
        {
            this.HighQuality = false;
            this.Damage = 198;
            this.BlastRadius = 5;
            this.Fuel = 83;
        }
        //Override SpendFuel method with high consumption
        protected override void SpendFuel()
        {
            Console.WriteLine("Spending rocket's fuel at 2.6 kg/s");
        }
    }
}