using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fast_Figures
{
    public class Information
    {
        // Introduktion och instruktion
        public static void WelcomeMessage(string name)
        {
            Console.Clear();
            Console.WriteLine("Hej " + name + "!\n");
            Console.WriteLine("Du får under två sekunder se en sifferkombination.\nNu är det upp till dig att komma ihåg den.\n\nTryck [ENTER] för att börja.");
            Console.ReadLine();
            Console.Clear();
        }

        // Höjning av svårighetsgrad (infotext)
        public static void LevelInfo()
        {
            Console.WriteLine("Bra jobbat!\nNu höjer vi svårighetsgraden och lägger till ett nummer!");
            Thread.Sleep(1000);
            Console.WriteLine("\nTryck [ENTER] när du är redo.");
            Console.ReadLine();
            Console.Clear();
        }

        // Numret som skall gissas
        public static void TheNumber()
        { 
            Console.WriteLine("Vilken sifferkombination såg du? (OBS! Endast siffror)");
        }

        // Rätt svar
        public static void CorrectAnswer()
        {
            Console.Clear();
            Console.WriteLine("Rätt svar!\n\nTryck [ENTER] för att fortsätta.");
        }

        // Fel svar
        public static void WrongAnswer(int n)
        {
            Console.WriteLine("\nTyvärr. Rätt svar är " + n);
        }

        // Slut på spelet
        public static void ByeByeMessage(string name)
        {
            Console.Clear();
            Console.WriteLine("Tack för spelet, " + name + "!\n\n\n");
            Thread.Sleep(4000);
        }

        // Spelarens namn
        public static string Name()
        {
            string name;
            Console.WriteLine("Välkommen till spelet 'FAST FIGURES'!\n");
            Thread.Sleep(1000);
            Console.Write("Skriv in ditt namn: ");
            name = Console.ReadLine();
            return name;
        }
    }
}
