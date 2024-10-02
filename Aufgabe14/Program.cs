namespace Aufgabe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie breit soll der Stamm sein? ");
            int stammBreite = int.Parse(Console.ReadLine());

            Console.Write("Wie hoch soll der Stamm sein? ");
            int stammHoehe = int.Parse(Console.ReadLine());

            Console.Write("Wie hoch soll die Krone sein? ");
            int kroneHoehe = int.Parse(Console.ReadLine());

            for (int i = 0; i < kroneHoehe; i++)
            {

                int sterne = 2 * i + 1;
                int leerzeichen = kroneHoehe - i - 1;

                Console.Write(new string(' ', leerzeichen));

                Console.WriteLine(new string('*', sterne));
            }


            for (int i = 0; i < stammHoehe; i++)
            {

                int leerzeichen = (kroneHoehe - stammBreite / 2) - 1;


                Console.Write(new string(' ', leerzeichen));

                Console.WriteLine(new string('*', stammBreite));
            }
        }
    }
}
