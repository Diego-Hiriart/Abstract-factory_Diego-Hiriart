namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class Heatseeker : Missile
    {
        public virtual float TrackingPrecision { set; get; }//Degrees
        //Override Fire method
        public override void Fire()
        {
            Console.WriteLine("Firing heatseeker");
            Console.WriteLine("Stats: \n\tHigh quality: {0} \n\tDamage: {1} hp \n\tBlast radius: {2} m \n\tFuel: {3} kg \n\tTracking precision: {4} °C",
            this.HighQuality, this.Damage, this.BlastRadius, this.Fuel, this.TrackingPrecision);
            this.SpendFuel();
            this.SeekHeat();
        }
        //Implement new SeekHeat method, use virtual so it can be overridden
        protected virtual void SeekHeat() { }
    }
}