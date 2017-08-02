using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Teiler = new List<int>();
            string eingabe = Console.ReadLine();
            int Zahlenwert = 0;
            String Ausgabe = "Teiler der Zahl sind: ";
            int Summe = 0;
            long Produkt = 1;
            if (Int32.TryParse(eingabe, out Zahlenwert))
            {
                for (int i = 1; i <= Zahlenwert; i++)
                {
                    if (Zahlenwert % i == 0)
                    {
                        Teiler.Add(i);
                    }
                }

                for (int wert = 0; wert < Teiler.Count(); wert++)
                {
                    if (wert == Teiler.Count-1)
                    {
                        Ausgabe += Teiler.ElementAt(wert);
                        Summe += Teiler.ElementAt(wert);
                        Produkt *= Teiler.ElementAt(wert);
                    }
                    else
                    {
                        Ausgabe += Teiler.ElementAt(wert) + ",";
                        Summe += Teiler.ElementAt(wert);
                        Produkt *= Teiler.ElementAt(wert);
                    }
                }

                Double Durchschnitt = 0.0;
                Durchschnitt = Double.Parse(Summe.ToString()) / Double.Parse((Teiler.Count+1).ToString());
                Ausgabe += "\nDie Summe der Teiler beträgt " + Summe + ".\n";
                Ausgabe += "Das Produkt der Teiler beträgt " + Produkt + ".\n";
                Ausgabe += "Der mittlere Durchschnitt der Teiler beträgt " + Durchschnitt + ".\n";
                if (Teiler.Count == 2)
                {
                    Ausgabe += "Zudem ist es eine Primzahl.";
                }
                else {
                    Ausgabe += "Es ist aber keine Primzahl.";
                }
            }
            Console.WriteLine(Ausgabe);
            Console.WriteLine("Press any Key to close the Window...");
            Console.ReadKey();


        }
    }
}
