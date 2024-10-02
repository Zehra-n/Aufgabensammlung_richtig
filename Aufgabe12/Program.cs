namespace Aufgabe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            do
            {
                Console.WriteLine("Die Zahl ist grösser als 5.");
                Console.WriteLine(new string('-', 27));
                a--;
                Console.WriteLine($"{a}");

            } while (a > 5);

            Console.WriteLine("Die Zahl ist kleiner als 5.");
        }
    }
}

