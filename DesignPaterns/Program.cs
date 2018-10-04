using DesignPaterns.Creational.AbstractFactory;
using DesignPaterns.Creational.Builder;
using DesignPaterns.Creational.Factory_Method;
using System;

namespace DesignPaterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational design patterns
            //AbstractFactory();
            //Builder();
            Factory_Method();
            #endregion

            #region Structural design patterns
            #endregion

            #region Behavioral design patterns
            #endregion
            // Wait for user input
            Console.ReadKey();
        }

        static void AbstractFactory()
        {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }

        static void Builder()
        {
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
        }

        static void Factory_Method()
        {
            // Note: constructors call Factory Method

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
        }
    }
}
