using Decorator.Component;

namespace Decorator.Decorator
{
    public abstract class VehicleDecorator : IVehicle
    {
        private readonly IVehicle _vehicle;
        public VehicleDecorator(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public string Make => _vehicle.Make;

        public string Model => _vehicle.Model;

        public double Price => _vehicle.Price;
    }
}
