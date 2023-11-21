//Funktion zur Namensgenerierung
using System;

namespace Guardian2
{
    internal class Program
    {
        static Random rnd = new Random();

        static string Gegnername()
        {
            string[] silben =  {
                        "ba", "be", "bi", "bo", "bu",
                        "ca", "ce", "ci", "co" ,"cu",
                        "da", "de", "di", "do", "du",
                        "fa","fe", "fi" ,"fo", "fu",
                        "ga", "ge", "gi", "go", "gu",
                        "ha", "he", "hi", "ho", "hu",
                        "ja", "je", "ji", "jo", "ju",
                        "ka", "ke", "ki", "ko", "ku",
                        "la", "le", "li", "lo", "lu",
                        "ma", "me", "mi", "mo", "mu",
                        "na", "ne", "ni", "no", "nu",
                        "pa", "pe", "pi", "po", "pu",
                        "ra", "re", "ri", "ro", "ru",
                        "sa", "se", "si", "so", "su",
                        "ta", "te", "ti", "to", "tu",
                        "va", "ve", "vi", "vo", "vu",
                        "wa", "we", "wi", "wo", "wu",
                        "xa", "xe", "xi", "xo", "xu",
                        "ya", "ye", "yi", "yo", "yu",
                        "za", "ze", "zi", "zo", "zu",
                        "ya", "ye", "yi", "yo", "yu",
                        "ab", "eb", "ib", "ob", "ub",
                        "ac", "ec", "ic", "oc", "uc",
                        "ad", "ed", "id", "od", "ud",
                        "af", "ef", "if", "of", "uf",
                        "ag", "eg", "ig", "og", "ug",
                        "ah", "eh", "ih", "oh" ,"uh",
                        "aj", "ej", "ij", "oj" ,"uj",
                        "ak", "ek", "ik", "ok" ,"uk",
                        "al", "el", "il", "ol" ,"ul",
                        "am", "em", "im", "om" ,"um",
                        "an", "en", "in", "on", "un",
                        "ap", "ep", "ip", "op", "up",
                        "ar", "er", "ir", "or", "ur",
                        "as", "es" ,"is", "os", "us",
                        "at", "et" ,"it", "ot", "ut",
                        "av", "ev", "iv", "ov", "uv",
                        "aw", "ew" ,"iw", "ow", "uw",
                        "ax", "ex" ,"ix", "ox", "ux",
                        "ay", "ey" ,",iy", "oy", "uy",
                        "az", "ez", "iz" ,"oz" ,"uz"};


            int zaehler = rnd.Next(5);
            string generatedName = " ";

            while (zaehler != 0)
            {
                Random rnd2 = new Random();
                zaehler--;
                int iteral = rnd2.Next(200);
                generatedName += silben[iteral + 1];
            }
            return generatedName.ToUpper();


            static int[] Charakterklassen(int Staerke, int Gesundheit, int Glueck, int AnzahlTraenke)
            {


                string[] Klassen = { "Krieger", "Magier", "Dieb", "Zwerg", "Heiler" };

                string SpielerKlasse;

                Console.WriteLine($"Wählen Sie aus folgenden Klassen: ");
                foreach (string item in Klassen)
                {
                    Console.WriteLine(item);
                }
                SpielerKlasse = Console.ReadLine();

                switch (SpielerKlasse)
                {
                    case "Krieger":
                        Console.Write("Du hast die Klasse Krieger gewählt");
                        Console.WriteLine($"Du hast deine Streitaxt wieder gefunden Dein neuer Stärkewert: {Staerke}");
                        Staerke = Staerke + 5;
                        break;

                    case "Magier":
                        Console.Write("Du hast die Klasse Magier gewählt");
                        Staerke = Staerke - 2;
                        Gesundheit = Gesundheit + 4;
                        Console.WriteLine($"Dein Zaubertrank ist fertig!Dein neuer Gesundheitswert:{Gesundheit} und dein neuer Stärkewert: {Staerke} ");
                        break;
                    case "Dieb":
                        Console.Write("Du hast die Klasse Dieb gewählt");
                        Glueck = Glueck + 4;
                        Console.WriteLine($"Du hast Fette Beute gemacht! Dein neuer Glückswert {Glueck}");
                        break;
                    case "Zwerg":
                        Console.Write("Du hast die Klasse Zwerg gewählt");
                        Glueck = Glueck + 2;
                        Gesundheit = Gesundheit + 1;
                        Console.WriteLine($"Du hast Fette Beute gemacht! Dein neuer Glückswert {Glueck}");
                        break;
                    case "Heiler":
                        Console.Write("Du hast die Klasse Heiler gewählt");
                        AnzahlTraenke = AnzahlTraenke + 1;
                        Gesundheit = Gesundheit + 4;
                        Console.WriteLine($"Scheinbar bist du nun gerüstet für ein langes Leben! Dein neuer Gesundheitswert: {Gesundheit}. Außerdem hast du einen zusätzlichen Trank gefunden!");
                        break;
                }

                int[] stats = { Staerke, Gesundheit, Glueck, AnzahlTraenke };
                return stats;
            }
            //Kampf - Angriffswerte bestimmen
            static void Angriff(int Staerke, int Gesundheit, int Glueck, int GlueckGegner, int StaerkeGegner, int GesundheitGegner, string Name, string GegnerName, int AnzahlTraenke)
            {

                double SchadenAmGegner = 0;
                double SchadenAmSpieler = 0;
                double GesundheitGegner2 = Convert.ToDouble(GesundheitGegner);
                double Gesundheit2 = Convert.ToDouble(Gesundheit);
                string weiter = " ";
                string Heilung = " ";


                int AnzahlTraenkeGegner = 1;

                while (GesundheitGegner2 > 0 && Gesundheit2 > 0)

                {
                    //Angriff und kritischer Treffer Spieler berechnen
                    double Angriff = (double)Staerke / 10;
                    double kritischerTreffer = (Angriff * (Glueck * 0.1)) + Angriff;
                    //Angriff und kritischer treffer Gegner berechnen
                    double AngriffGegner = (double)StaerkeGegner / 10;
                    double kritischerTrefferGegner = (AngriffGegner * (GlueckGegner * 0.1)) + AngriffGegner;


                    Random zufall = new Random();
                    int zufall2 = zufall.Next(1, 11);

                    if (zufall2 == 5)
                    {
                        SchadenAmGegner = kritischerTreffer;
                        SchadenAmSpieler = kritischerTrefferGegner;

                        Gesundheit2 = Gesundheit2 - SchadenAmSpieler;
                        GesundheitGegner2 = GesundheitGegner2 - SchadenAmGegner;
                    }
                    else
                    {
                        Gesundheit2 = Gesundheit2 - AngriffGegner;
                        GesundheitGegner2 = GesundheitGegner2 - Angriff;
                        SchadenAmGegner = Angriff;
                        SchadenAmSpieler = AngriffGegner;

                    }
                    if (AnzahlTraenkeGegner >= 1)
                    {
                        Random eineChance = new Random();
                        int eineChance2 = eineChance.Next(1, 5);
                        if (eineChance2 == 2)
                        {
                            GesundheitGegner2 += 3;
                            AnzahlTraenkeGegner = 0;
                            Console.WriteLine($"{GegnerName} hat einen Heiltrank zu sich genommen!");
                        }

                    }
                    //Ausgabe der Rundenergebnisse 
                    Console.WriteLine($" {Name} verursacht {SchadenAmGegner} Schaden an {GegnerName} ");
                    Console.WriteLine($" {GegnerName} verursacht {SchadenAmSpieler} Schaden an {Name}");
                    Console.WriteLine($" {Name}: Noch {Gesundheit2.ToString("0.##")} Gesundheit übrig");
                    Console.WriteLine($" {GegnerName}: Noch  {GesundheitGegner2.ToString("0.##")} Gesundheit übrig");


                    //Noch eine Runde?
                    Console.WriteLine($"{Name} noch eine Runde?j/n");
                    weiter = Console.ReadLine();

                    if (weiter != "j")
                    {
                        break;

                    }

                    //Heilung?
                    else if (AnzahlTraenke >= 1)
                    {

                        Console.WriteLine("Moechten Sie einen Heiltrank zu sich nehmen?j/n?");
                        Heilung = Console.ReadLine();
                        if (Heilung == "j")
                        {
                            Gesundheit2 = Gesundheit2 + 3;

                            AnzahlTraenke = AnzahlTraenke - 1;
                        }
                        else
                        {
                            AnzahlTraenke = 1;
                        }

                    }

                }

                if (Gesundheit2 <= 0)
                {
                    Console.WriteLine($"{Name} hat den Kampf verloren.");
                }
                else if (GesundheitGegner2 <= 0)
                {
                    Console.WriteLine($"{Name} hat den Kampf gewonnen!");

                }

                static void Main(string[] args)
                {
                    //BEGIN MAIN!!!!!

                    int Gesundheit;
                    int Staerke;
                    int Glueck;
                    int AnzahlTraenke = 1;
                    int GesundheitGegner;
                    int StaerkeGegner;
                    int GlueckGegner;
                    int Gesamt;
                    string Gegnername = " ";

                    Console.WriteLine("Willkommen bei Guardian of BitLC! Sie können nun Ihre Spielfigur erstellen. Bitte geben Sie einen Namen ein: ");
                    string Name = Console.ReadLine();

                    bool help = false;
                    do
                    {
                        Console.WriteLine("Vergeben Sie nun Ihre Punkte fuer Ihren Survivor. Sie haben 15 zu verteilende Punkte fuer drei Eigenschaften. Waehlen Sie Weise");
                        Console.WriteLine("Geben Sie die Punktzahl fuer die Staerke ein: ");
                        Staerke = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Jetzt die Punktzahl fuer die Eigenschaft Gesundheit: ");
                        Gesundheit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" geben Sie nun Ihren Glueckswert an: ");
                        Glueck = Convert.ToInt32(Console.ReadLine());

                        if ((Staerke + Gesundheit + Glueck) > 15)
                        {
                            Console.WriteLine(" Sie haben Ihrer Spielfigur zu viele Punkte vergeben. Nochmal (n) versuchen oder auf Standartwerte zuruecksetzen(s)?");
                            string Antwort = Console.ReadLine();

                            if (Antwort == "s")
                            {
                                Console.WriteLine("Auf Standardwerte zurueckgesetzt. Staerke = 5, Gesundheit = 5, Glueck = 5");
                                Staerke = 5;
                                Gesundheit = 5;
                                Glueck = 5;
                                break;

                            }
                            else if (Antwort == "n")
                            {
                                continue;
                            }
                        }
                        else
                        {

                            help = false;
                            break;
                        }

                    } while (help != true);


                    Random rad = new Random();


                    Console.WriteLine("Nun werden die gegnerischen Werte generiert");
                    do
                    {
                        StaerkeGegner = rad.Next(1, 7);

                        GesundheitGegner = rad.Next(1, 7);

                        GlueckGegner = 15 - StaerkeGegner - GesundheitGegner;

                        Gesamt = StaerkeGegner + GesundheitGegner + GlueckGegner;
                        Console.WriteLine(Gesamt);
                        if (Gesamt == 15)
                        {
                            break;
                        }

                    } while (true);

                    Console.WriteLine("Gesundheit des Gegners: " + GesundheitGegner);
                    Console.WriteLine("Glück des Gegners: " + GlueckGegner);
                    Console.WriteLine("Stärke des Gegners: " + StaerkeGegner);


                    string GegnerName = Gegnername();

                    Console.WriteLine("Gegnerischer Name: " + GegnerName);

                    // Rufen Sie die Charakterklassen-Methode auf und erfassen Sie den Rückgabewert in charakterStats
                    int[] charakterStats = Charakterklassen(Staerke, Gesundheit, Glueck, AnzahlTraenke);

                    // Aktualisieren Sie die Variablen mit den Werten aus charakterStats
                    Staerke = charakterStats[0];
                    Gesundheit = charakterStats[1];
                    Glueck = charakterStats[2];
                    AnzahlTraenke = charakterStats[3];

                    Console.WriteLine($" Hallo {Name}, du hast Staerke: {Staerke} zugewiesen. Deine Gesundheit liegt bei: {Gesundheit}, dein Glück bei {Glueck} ");

                    Console.WriteLine("Bereit zum Kampf?");

                    Angriff(Staerke, Gesundheit, Glueck, GlueckGegner, StaerkeGegner, GesundheitGegner, Name, GegnerName, AnzahlTraenke);






                }
            }
        }
    }
}










