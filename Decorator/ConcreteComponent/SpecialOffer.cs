﻿using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteComponent
{
    public class SpecialOffer : VehicleDecorator
    {
        public SpecialOffer(IVehicle vehicle) : base(vehicle) { }
        public int DiscountPercentage { get; set; }
        public string Offer { get; set; }
        public double Price
        {
            get
            {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }
    }
}
