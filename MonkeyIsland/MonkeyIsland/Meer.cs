using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    public class Meer : Orte
    {
        //Felder
        private string name;
        private Schiff schiff;
        private Insel[] inseln = new Insel[3];
        private Pirat pirat;

        public Meer(string name) : base(name)
        {
            this.name = name;
            //Komposition! Ohne Meer gibt es keine Inseln! 
            inseln[0] = new Insel("Monkey Island");
            inseln[1] = new Insel("Donkey island");
            inseln[2] = new Insel("Banana Island");
        }
        public void SetSchiff(Schiff schiff)
        {
            this.schiff = schiff;
        }
        public void SetPirat(Pirat pirat)
        {
            this.pirat = pirat;
        }
        public string GetName()
        {
            return name;
        }
        public Pirat GetPirat()
        {
            return pirat;
        }
        public Insel[] GetInseln()
        {
            return inseln;
        }
        public Schiff GetSchiff()
        {
            return schiff;
        }
    }
}
