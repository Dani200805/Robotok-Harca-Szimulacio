namespace Robotok_Harca_Szimulacio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("=== Robot Harc Menü ===");
                Console.ResetColor();
                Console.WriteLine("1. Új játék indítása");
                Console.WriteLine("2. Beállítások");
                Console.WriteLine("3. Kilépés");
                Console.Write("Válassz egy opciót (1-3): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        Settings();
                        break;
                    case "3":
                        Console.WriteLine("Kilépés... Nyomj ENTER-t a kilépéshez.");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Érvénytelen választás! Próbáld újra.");
                        Console.ReadKey();
                        break;
                }
            }

            static void StartGame()
            {
                Console.Clear();
                Console.WriteLine("Játék indítása...");
                Console.WriteLine("Nyomj ENTER-t a folytatáshoz.");
                Console.ReadLine();
            }

            static void Settings()
            {
                Console.Clear();
                Console.WriteLine("Beállítások menü...");
                Console.WriteLine("Nyomj ENTER-t a visszalépéshez.");
                Console.ReadLine();
            }


        }

       
    }
}
