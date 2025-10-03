using System;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Random random = new Random();
                int nombre = random.Next(1, 10); // nombre aléatoire
                Console.WriteLine($"nombre de drone : {nombre}");

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

                // Création de la flotte de drones
                List<Drone> fleet = new List<Drone>();
                for (int i = 0; i < nombre; i++)
                {
                    int positionX = random.Next(200, 1000);
                    int positionY = random.Next(200, 500);
                    fleet.Add(new Drone(positionX, positionY, "Joe"));
                }

                List<Building> building = new List<Building>();


                List<Factory> factory = new List<Factory>();
                factory.Add(new Factory(100, 350, 001));
                factory.Add(new Factory(550, 100, 002));
                factory.Add(new Factory(900, 450, 003));
                List<Box> box = new List<Box>();

                List<Store> store = new List<Store>();
                store.Add(new Store(200, 150, 001));
                store.Add(new Store(850, 100, 002));
                store.Add(new Store(500, 450, 003));

                // Démarrage
                Application.Run(new AirSpace(fleet, building, factory, box, store));
                if (fleet.Count > 10)
                {
                    
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}