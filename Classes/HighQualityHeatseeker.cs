namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class HighQualityHeatseeker : Heatseeker
    {
        //Implement high quality heatseeker constructor
        public HighQualityHeatseeker()
        {
            this.HighQuality = true;
            this.Damage = 212;
            this.BlastRadius = 7;
            this.Fuel = 88.6f;
            this.TrackingPrecision = 2.1f;
        }
        //Override SpendFuel method with low consumption
        protected override void SpendFuel()
        {
            Console.WriteLine("Spending heatseeker's fuel at 1.99 kg/s");
        }
        //Override SeekHeat method with high precision
        protected override void SeekHeat()
        {
            Console.WriteLine("Homing in on target with a \u00B1 {0} °C error", this.TrackingPrecision);
        }
    }
}