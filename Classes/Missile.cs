namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class Missile : Ammo
    {
        public override float Damage { set; get; }
        public virtual float BlastRadius { set; get; }//Meters
        public virtual float Fuel { set; get; }//kg
        //Implement Fire method
        public override void Fire()
        {
            this.SpendFuel();
        }
        //Implement a new SpendFuel method, use virtual so it can be overridden
        protected virtual void SpendFuel() { }
    }
}