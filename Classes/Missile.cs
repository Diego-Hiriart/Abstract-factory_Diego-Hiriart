namespace Abstract_factory_Diego_Hiriart.Classes
{
    public class Missile : Ammo
    {
        public override float Damage { set; get; }
        public virtual float BlastRadius { set; get; }//Meters
        public virtual float Fuel { set; get; }//kg
        public override void Fire()
        {
            this.SpendFuel();
        }
        protected virtual void SpendFuel() { }
    }
}