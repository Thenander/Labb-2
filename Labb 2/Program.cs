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
            int rndNoDigits;
            int[] rndNo = new int[] { 100, 999, 1000, 9999, 10000, 99999, 100000, 999999, 1000000, 9999999, 10000000, 99999999, 10, 99 };
            string name = Information.Name();
            // Introduktion och instruktion
            Information.WelcomeMessage(name);
            // Level 0
            for (int i = 0; i < 1; i++)
            {
                rndNoDigits = RandomNumber(rndNo[12], rndNo[13]);
                PlayGame(rndNoDigits);
            }
            LevelInfo();
            // Level 1
            for (int i = 0; i < 3; i++)
            {
                rndNoDigits = RandomNumber(rndNo[0], rndNo[1]);
                PlayGame(rndNoDigits);
            }
            LevelInfo();
            // Level 2
            for (int i = 0; i < 3; i++)
            {
                rndNoDigits = RandomNumber(rndNo[2], rndNo[3]);
                PlayGame(rndNoDigits);
            }
            LevelInfo();
            // Level 3
            for (int i = 0; i < 3; i++)
            {
                rndNoDigits = RandomNumber(rndNo[4], rndNo[5]);
                PlayGame(rndNoDigits);
            }
            LevelInfo();
            // Level 4
            for (int i = 0; i < 4; i++)
            {
                rndNoDigits = RandomNumber(rndNo[6], rndNo[7]);
                PlayGame(rndNoDigits);
            }
            LevelInfo();
            // Level 5
            for (int i = 0; i < 4; i++)
            {
                rndNoDigits = RandomNumber(rndNo[8], rndNo[9]);
                PlayGame(rndNoDigits);
            }
            LevelInfo();
            // Level 5
            for (int i = 0; i < 4; i++)
            {
                rndNoDigits = RandomNumber(rndNo[10], rndNo[11]);
                PlayGame(rndNoDigits);
            }
            // Avslut
            Information.ByeByeMessage(name);
        }
    }
}

