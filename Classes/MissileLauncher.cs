using Abstract_factory_Diego_Hiriart.Factories;

namespace Abstract_factory_Diego_Hiriart.Classes
{
    class MissileLauncher
    {
        public MissileLauncher(MissileFactory factory)
        {
            this.Factory = factory;
        }
        public MissileFactory Factory { get; }
        private Missile? ChamberedMissile { set; get; }//Nullable, chamber could be empty
        public void LoadRocket()
        {
            this.ChamberedMissile = this.Factory.CreateRocket();
            Console.WriteLine("Rocket loaded");
        }
        public void LoadHeatseeker()
        {
            this.ChamberedMissile = this.Factory.CreateHeatseeker();
            Console.WriteLine("Heatseeker loaded");
        }
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