namespace Abstract_factory_Diego_Hiriart.Classes
{
    public abstract class Ammo
    {
        //Base class for ammo, missiles in this case
        public abstract float Damage { set; get; }//HP
        public abstract void Fire();
    }
}