namespace Aufgabe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weiterspielen;

            do
            {
                Random random = new Random();
                int zufallszahl = random.Next(1, 101);
                int versuche = 0;
                int zahl = -1;

                Console.WriteLine("Ratespiel! Zahl Zwischen 1 und 100.");

                while (zahl != zufallszahl)
                {
                    Console.WriteLine("Deine Zahl (1..100): ");
                    if (int.TryParse(Console.ReadLine(), out zahl))
                    {
                        versuche++;
                        if (zahl > zufallszahl)
                        {
                            Console.WriteLine("Zu Gross! Nächster Versuch: ");
                        }
                        else if (zahl < zufallszahl)
                        {
                            Console.WriteLine("Zu Klein! Nächster versuch: ");
                        }
                        else
                        {
                            Console.WriteLine($"Die Zahl stimmt! Du hast total {versuche} versuche benötigt.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
                    }
                }
                Console.Write("Nochmal spiele? (j/n)");
                weiterspielen = Console.ReadLine().ToLower();
            } while (weiterspielen == "j");

            Console.WriteLine("Danke fürs Spielen!");
        }  
    }
}

