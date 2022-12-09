using Abstract_factory_Diego_Hiriart.Classes;

namespace Abstract_factory_Diego_Hiriart.Factories
{
    public class HighQualityMissileFactory
    {
        public Rocket CreateRocket()
        {
            return new HighQualityRocket();
        }
        public Heatseeker CreateHeatseeker()
        {
            return new HighQualityHeatseeker();
        }
    }
}