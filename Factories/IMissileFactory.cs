using Abstract_factory_Diego_Hiriart.Classes;

namespace Abstract_factory_Diego_Hiriart.Factories
{
    public interface IMissileFactory
    {
        public Rocket CreateRocket();
        public Heatseeker CreateHeatseeker();
    }
}