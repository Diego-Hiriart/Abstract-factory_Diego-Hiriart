namespace Abstract_factory_Diego_Hiriart.Classes
{
    class QualityRocket : Rocket
    {
        public QualityRocket()
        {
            this.Damage = 245;
            this.BlastRadius = 11;
            this.Fuel = 100;
        }
        protected override void SpendFuel()
        {
            Console.WriteLine("Spending rocket's fuel at 1.8 kg/s");
        }
    }
}