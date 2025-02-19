namespace Robotok_Harca_Szimulacio
{
    class Program
    {
        private static List<Fegyver> elerhetoFegyverek = new List<Fegyver>();
        private static List<Robot> ellenfelek = new List<Robot>();
        private static Robot jatekosRobot;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Robotok Harca Szimuláció");
            Console.ResetColor();
            Console.WriteLine("\nRobot Harci Menü:");
            Inicializalas();
            Indit();
        }


        static void Indit()
        {
            bool fut = true;
            while (fut)
            {
                Console.WriteLine("\n1. Robot állapot megtekintése");
                Console.WriteLine("2. Új fegyver felszerelése");
                Console.WriteLine("3. Új fegyver hozzáadása");
                Console.WriteLine("4. Harc indítása");
                Console.WriteLine("5. Kilépés");
                Console.Write("Válassz egy lehetőséget: ");
                string valasztas = Console.ReadLine();

                switch (valasztas)
                {
                    case "1":
                        RobotAllapotMegtekintese();
                        break;
                    case "2":
                        UjFegyverFelszerelese();
                        break;
                    case "3":
                       UjFegyverHozzaadasa();
                        break;
                    case "4":
                        HarcInditasa();
                        break;
                    case "5":
                        fut = false;
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás, próbáld újra.");
                        break;
                }
            }
        }

        static void Inicializalas()
        {
            elerhetoFegyverek.Add(new Fegyver("Lézer", 20));
            elerhetoFegyverek.Add(new Fegyver("Plazmaágyú", 30));
            elerhetoFegyverek.Add(new Fegyver("Rakétavető", 40));

            jatekosRobot = new Robot("Alfa", 5, elerhetoFegyverek[0], new Pancel("Pajzs", 10));

            ellenfelek.Add(new Robot("Beta", 3, elerhetoFegyverek[1], new Pancel("Erős pajzs", 15)));
            ellenfelek.Add(new Robot("Gamma", 7, elerhetoFegyverek[2], new Pancel("Titan pajzs", 20)));
        }
        static void RobotAllapotMegtekintese()
        {
            Console.WriteLine($"Robot neve: {jatekosRobot.Nev}, Szint: {jatekosRobot.Szint}, Fegyver: {jatekosRobot.Fegyver.Nev}, Páncél: {jatekosRobot.Pancel.Nev}");
        }

        static void UjFegyverFelszerelese()
        {
            Console.WriteLine("Válassz egy új fegyvert:");
            for (int i = 0; i < elerhetoFegyverek.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {elerhetoFegyverek[i].Nev} - Sebzés: {elerhetoFegyverek[i].Sebzes}");
            }
            Console.Write("Választott fegyver száma: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= elerhetoFegyverek.Count)
            {
                jatekosRobot.Fegyver = elerhetoFegyverek[index - 1];
                Console.WriteLine("Új fegyver felszerelve!");
            }
            else
            {
                Console.WriteLine("Érvénytelen választás.");
            }
        }

        static void UjFegyverHozzaadasa()
        {
            Console.Write("Add meg az új fegyver nevét: ");
            string nev = Console.ReadLine();
            Console.Write("Add meg a fegyver sebzését: ");
            if (int.TryParse(Console.ReadLine(), out int sebzes) && sebzes > 0)
            {
                elerhetoFegyverek.Add(new Fegyver(nev, sebzes));
                Console.WriteLine("Új fegyver hozzáadva!");
            }
            else
            {
                Console.WriteLine("Érvénytelen sebzés érték.");
            }
        }

        static void HarcInditasa()
        {
            Console.WriteLine("Válassz egy ellenfelet:");
            for (int i = 0; i < ellenfelek.Count; i++)
            {
                int esely = SzamolGyozelmiEsely(ellenfelek[i]);
                Console.WriteLine($"{i + 1}. {ellenfelek[i].Nev} (Szint: {ellenfelek[i].Szint}) - Győzelmi esély: {esely}%");
            }
            Console.Write("Választott ellenfél száma: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= ellenfelek.Count)
            {
                Robot ellenfel = ellenfelek[index - 1];
                int esely = SzamolGyozelmiEsely(ellenfel);
                bool jatekosGyoz = random.Next(100) < esely;
                int maradekEletero = random.Next(10, 50);

                if (jatekosGyoz)
                {
                    Console.WriteLine($"Gratulálok! Legyőzted {ellenfel.Nev}-t! Hátralévő életerőd: {maradekEletero}");
                }
                else
                {
                    Console.WriteLine($"Sajnos {ellenfel.Nev} győzött! Ellenfeled hátralévő életereje: {maradekEletero}");
                }
            }
            else
            {
                Console.WriteLine("Érvénytelen választás.");
            }
        }

        static int SzamolGyozelmiEsely(Robot ellenfel)
        {
            int esely = 50 + ((jatekosRobot.Szint - ellenfel.Szint) * 10) + (jatekosRobot.Fegyver.Sebzes) / 5;
            return Math.Max(10, Math.Min(90, esely));
        }
    }
}
