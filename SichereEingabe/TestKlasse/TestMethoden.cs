using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestKlasse
{
    public static class TestMethoden
    {

        public static int IntegerTest()
        {

            int zahl1;
            Console.WriteLine("Bitte Geben Sie etwas zum Testen ein.");
            while (true)
            {
                try
                {
                    zahl1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"Fehlermeldung: '{ex.Message}'.  Bitte Zahl eingeben.");
                    continue;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine($"Fehlermeldung2: '{ex.Message}'.  Bitte Zahl eingeben.");
                    continue;
                }
            }
            return zahl1;

        }
        public static int IntegerTest(int MinZahl, int MaxZahl)
        {

            int zahl1;

            Console.WriteLine("Bitte Geben Sie etwas zum Testen ein.");
            while (true)
            {
                try
                {
                    zahl1 = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"Fehlermeldung: '{ex.Message}'.  Bitte Zahl eingeben.");
                    continue;
                }
                if (zahl1 < MinZahl || zahl1 > MaxZahl)
                {
                    Console.WriteLine($"Zahl liegt nicht zwischen {MinZahl} und {MaxZahl}");
                }
                else
                {
                    Console.WriteLine($"{zahl1} liegt im angegebenen Bereich");
                    break;
                }

            }
            return zahl1;

        }
        public static double DoubleTest()
        {
            double zahl1;
            Console.WriteLine("Bitte Geben Sie etwas zum Testen ein.");
            while (true)
            {
                try
                {
                    zahl1 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"Fehlermeldung: '{ex.Message}'.  Bitte Zahl eingeben.");
                    continue;
                }
            }
            return zahl1;

        }
        public static double DoubleTest(double MinZahl, double MaxZahl)
        {

            double zahl1;

            Console.WriteLine("Bitte Geben Sie etwas zum Testen ein.");
            while (true)
            {
                try
                {
                    zahl1 = Convert.ToDouble(Console.ReadLine());

                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"Fehlermeldung: '{ex.Message}'.  Bitte Zahl eingeben.");
                    continue;
                }
                if (zahl1 < MinZahl || zahl1 > MaxZahl)
                {
                    Console.WriteLine($"Zahl liegt nicht zwischen {MinZahl} und {MaxZahl}");
                }
                else
                {
                    Console.WriteLine($"{zahl1} liegt im angegebenen Bereich");
                    break;
                }

            }
            return zahl1;

        }

        public static float FloatTest()
        {
            float zahl1;

            Console.WriteLine("Bitte Geben Sie etwas zum Testen ein.");
            while (true)
            {
                try
                {
                    zahl1 = float.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"Fehlermeldung: '{ex.Message}'.  Bitte gültige float Zahl eingeben.");
                    continue;
                }


            }
            return zahl1;

        }

        public static char CharTest()
        {
            char zahl1;


         Regex pattern = new System.Text.RegularExpressions.Regex(@"^[A-Za-z]$");

            Console.WriteLine("Bitte Geben Sie etwas zum Testen ein.");
            while (true)
            {
                try
                {
                    zahl1 = Convert.ToChar(Console.ReadLine());

                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"Fehlermeldung: '{ex.Message}'.  Bitte Buchstaben eingeben.");
                    continue;
                }
                string zahl2 = Convert.ToString(zahl1);
                if (pattern.IsMatch(zahl2))
                {
                    Console.WriteLine($"{zahl1} ist gültig");
                    return zahl1;
                }

                Console.WriteLine("Ungültige Eingabe!!");
            }



        }
    }
}

