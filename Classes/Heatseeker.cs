namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class Heatseeker : Missile
    {
        public virtual float TrackingPrecision { set; get; }//Degrees
        //Override Fire method
        public override void Fire()
        {
            Console.WriteLine("Firing heatseeker");
            Console.WriteLine("Stats: \n\tDmage: {0} hp \n\tBlast radius: {1} m \n\tFuel: {2} kg \n\tTracking precision: {3} °C",
            this.Damage, this.BlastRadius, this.Fuel, this.TrackingPrecision);
            this.SpendFuel();
            this.SeekHeat();
        }
        //Implement new SeekHeat method, use virtual so it can be overridden
        protected virtual void SeekHeat() { }
    }
}