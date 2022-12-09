namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class Rocket : Missile
    {
        //Override Fire method
        public override void Fire()
        {
            Console.WriteLine("Firing rocket");
            Console.WriteLine("Stats: \n\tHigh quality: {0} \n\tDamage: {1} hp \n\tBlast radius: {2} m \n\tFuel: {3} kg",
            this.HighQuality, this.Damage, this.BlastRadius, this.Fuel);
        }
    }
}