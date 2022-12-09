using Abstract_factory_Diego_Hiriart.Factories;

namespace Abstract_factory_Diego_Hiriart.Classes
{
    class MissileLauncher
    {
        //Create new missile launcher with a factory interface so both types of factories can be called
        public MissileLauncher(MissileFactory factory)
        {
            this.Factory = factory;
        }
        //Factory to be used
        public MissileFactory Factory { get; }
        //Missile that will be created by factory
        private Missile? ChamberedMissile { set; get; }//Nullable, chamber could be empty
        //Create and save a rocket
        public void LoadRocket()
        {
            this.ChamberedMissile = this.Factory.CreateRocket();
            Console.WriteLine("Rocket loaded");
        }
        //Create and save a heatseeker
        public void LoadHeatseeker()
        {
            this.ChamberedMissile = this.Factory.CreateHeatseeker();
            Console.WriteLine("Heatseeker loaded");
        }
        //Fire the chambered missile
        public void FireMissile()
        {
            if (this.ChamberedMissile != null)
            {
                this.ChamberedMissile.Fire();
            }
            else
            {
                Console.WriteLine("Missile chamber empty!");
            }
        }
    }
}