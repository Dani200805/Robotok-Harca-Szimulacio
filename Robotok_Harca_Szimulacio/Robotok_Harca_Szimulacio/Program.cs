namespace Robotok_Harca_Szimulacio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            do
            {
                c = Menu();
                switch (c)
                {
                    case 0: break;
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                }
            } while (c != -1);
        }

        static char Menu()
        {
            Console.Clear();
            Console.WriteLine("0 - Kilépés");
            Console.WriteLine("1 - ");
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - ");
            Console.WriteLine("4 - ");
            Console.Write("Válasz: ");
            return Console.ReadKey().KeyChar;
        }
    }
}
