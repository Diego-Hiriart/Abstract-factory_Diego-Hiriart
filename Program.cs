using Abstract_factory_Diego_Hiriart.Classes;
using Abstract_factory_Diego_Hiriart.Factories;

namespace Abstract_factory_Diego_Hiriart
{
    internal class Program
    {
        private static bool _highQualityUnlocked = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Diego Hiriart León \n Ingeniería de Software \n ISWZ3206-01 Desarrollo de Software Seguro");
            Console.WriteLine("Abstract Factory - Design pattern\n");
            SetQualityLevel();
            UseMissileLauncher();
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        private static void SetQualityLevel()
        {
            //Ask user if they want to unlock high quality ammo
            string? response = "";
            do
            {
                Console.Write("Unlock high quality ammo? (yes or no): ");
                response = Console.ReadLine();
                if (response == null || (response.ToLower() != "yes" && response.ToLower() != "no"))
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
            while (response == null || (response.ToLower() != "yes" && response.ToLower() != "no"));
            //Set high quality ammo if user answers yes
            if (response == "yes")
            {
                _highQualityUnlocked = true;
                Console.WriteLine("High quality ammo unlocked");
            }
            else
            {
                Console.WriteLine("Regular quality ammo will be used");
            }
        }

        private static void UseMissileLauncher()
        {
            //Instantiate missile launcher with propper quality
            MissileLauncher missileLauncher;
            if (_highQualityUnlocked)
            {
                missileLauncher = new MissileLauncher(new HighQualityMissileFactory());
            }
            else
            {
                missileLauncher = new MissileLauncher(new RegularMissileFactory());
            }
            //Menu option
            int option = 0;
            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Load rocket \t2. Load heatseeker \t3. Fire missile \t4. Exit");
                int.TryParse(Console.ReadLine(), out option);
                switch (option)
                {
                    case 1:
                        missileLauncher.LoadRocket();
                        break;

                    case 2:
                        missileLauncher.LoadHeatseeker();
                        break;

                    case 3:
                        missileLauncher.FireMissile();
                        break;

                    case 4:
                        Console.WriteLine("\nExiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option, try again");
                        break;
                }
            } while (option != 4);
        }
    }
}