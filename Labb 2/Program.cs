using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fast_Figures
{
    class Program
    {
        // Metod för slumptal
        private static int RandomNumber(int n1, int n2)
        {
            Random rnd = new Random();
            int digits = rnd.Next(n1, n2);
            return digits;
        }

        // Metod för Maingame
        private static void PlayGame(int res)
        {
            Console.WriteLine(res);
            Thread.Sleep(1800);
            Console.Clear();
            GamingClass.GamingMethod(res);
            Console.ReadLine();
            Console.Clear();
        }

        // Metod för svårighetshöjning
        private static void LevelInfo()
        {
            Information.LevelInfo();
        }

        static void Main()
        {
            int rndNumberDigits;
            int[] rndNo = new int[] { 100, 999, 1000, 9999, 10000, 99999, 100000, 999999, 1000000, 9999999, 10000000, 99999999 };
            string name = Information.Name();
            // Introduktion och instruktion
            Information.WelcomeMessage(name);

            // Level 1
            for (int i = 0; i < 3; i++)
            {
                rndNumberDigits = RandomNumber(rndNo[10], rndNo[11]);
                PlayGame(rndNumberDigits);
            }

            // Level 2
            LevelInfo();
            for (int i = 0; i < 3; i++)
            {
                rndNumberDigits = RandomNumber(rndNo[2], rndNo[3]);
                PlayGame(rndNumberDigits);
            }

            // Level 3
            LevelInfo();
            for (int i = 0; i < 3; i++)
            {
                rndNumberDigits = RandomNumber(rndNo[4], rndNo[5]);
                PlayGame(rndNumberDigits);
            }

            // Level 4
            LevelInfo();
            for (int i = 0; i < 3; i++)
            {
                rndNumberDigits = RandomNumber(rndNo[6], rndNo[7]);
                PlayGame(rndNumberDigits);
            }

            // Level 5
            LevelInfo();
            for (int i = 0; i < 3; i++)
            {
                rndNumberDigits = RandomNumber(rndNo[8], rndNo[9]);
                PlayGame(rndNumberDigits);
            }

            // Level 5
            LevelInfo();
            for (int i = 0; i < 3; i++)
            {
                rndNumberDigits = RandomNumber(rndNo[10], rndNo[11]);
                PlayGame(rndNumberDigits);
            }
            // Avslut
            Information.ByeByeMessage(name);
        }
    }
}

