using Abstract_factory_Diego_Hiriart.Classes;

namespace Abstract_factory_Diego_Hiriart.Factories
{
    public class RegularMissileFactory
    {
        public Rocket CreateRocket()
        {
            return new RegularRocket();
        }
        public Heatseeker CreateHeatseeker()
        {
            return new RegularHeatseeker();
        }
    }
}