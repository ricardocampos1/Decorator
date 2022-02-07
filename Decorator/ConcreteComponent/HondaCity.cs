using Decorator.Component;

namespace Decorator.ConcreteComponent
{
    public class HondaCity : IVehicle
    {
        public string Make => "HondaCity";

        public string Model => "CNG";

        public double Price => 1000000;
    }
}
