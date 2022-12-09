using Abstract_factory_Diego_Hiriart.Classes;

namespace Abstract_factory_Diego_Hiriart.Factories
{
    public class QualityMissileFactory
    {
        public Rocket CreateRocket()
        {
            return new QualityRocket();
        }
        public Heatseeker CreateHeatseeker()
        {
            return new QualityHeatseeker();
        }
    }
}