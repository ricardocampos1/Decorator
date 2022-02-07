// See https://aka.ms/new-console-template for more information
using Decorator.ConcreteComponent;

HondaCity car = new HondaCity();
Console.WriteLine($"Honda City preço : {car.Price}");
SpecialOffer offer = new SpecialOffer(car);
offer.DiscountPercentage = 25;
offer.Offer = "25 % de desconto";
Console.WriteLine($"{offer.Price} @ Honda preço especial : {offer.Offer} ");
Console.ReadKey();
