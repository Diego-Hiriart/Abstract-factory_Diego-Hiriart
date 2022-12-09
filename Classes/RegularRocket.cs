namespace Abstract_factory_Diego_Hiriart.Classes
{
    class RegularRocket : Rocket
    {
        public RegularRocket()
        {
            this.Damage = 198;
            this.BlastRadius = 5;
            this.Fuel = 83;
        }
        protected override void SpendFuel()
        {
            Console.WriteLine("Spending rocket's fuel at 2.6 kg/s");
        }
    }
}