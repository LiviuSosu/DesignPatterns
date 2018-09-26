using DesignPaterns.Creational.AbstractFactory;
using DesignPaterns.Creational.Builder;
using System;

namespace DesignPaterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Factory
            //ContinentFactory africa = new AfricaFactory();
            //AnimalWorld world = new AnimalWorld(africa);
            //world.RunFoodChain();

            //// Create and run the American animal world

            //ContinentFactory america = new AmericaFactory();
            //world = new AnimalWorld(america);
            //world.RunFoodChain();
            #endregion

            VehicleBuilder builder;

            // Create shop with vehicle builders

            Shop shop = new Shop();

            // Construct and display vehicles

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user input
            Console.ReadKey();

        }
    }
}
