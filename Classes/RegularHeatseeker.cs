namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class RegularHeatseeker : Heatseeker
    {
        //Implement regular quality heatseeker constructor
        public RegularHeatseeker()
        {
            this.HighQuality = false;
            this.Damage = 186;
            this.BlastRadius = 4.6f;
            this.Fuel = 77;
            this.TrackingPrecision = 5.1f;
        }
        //Override SpendFuel method with high consumption
        protected override void SpendFuel()
        {
            Console.WriteLine("Spending heatseeker's fuel at 2.75 kg/s");
        }
        //Override SeekHeat method with low precision
        protected override void SeekHeat()
        {
            Console.WriteLine("Homing in on target with a \u00B1 {0} °C error", this.TrackingPrecision);
        }
    }
}