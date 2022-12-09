namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class Rocket : Missile
    {
        public override void Fire(){
            Console.WriteLine("Firing rocket");
            Console.WriteLine("Stats: \n\tDmage: {0} hp \n\tBlast radius: {1} m \n\tFuel: {2} kg",
            this.Damage, this.BlastRadius, this.Fuel);
        }
    }
}