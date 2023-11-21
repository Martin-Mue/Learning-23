using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonkeyIsland;

namespace MonkeyIsland
{
    public class Insel : Orte
    {
        private string name;
        private Kneipe kneipe;
        private Strand strand;
        private Pirat pirat;

        public Insel(string name): base (name)
        {
            this.name = name;
            kneipe = new Kneipe("Monkey Bar");
            strand = new Strand("Copa Cabana");
        }
      
        public Kneipe GetKneipe()
        {
            return kneipe;
        }
        public Strand GetStrand()
        {
            return strand;
        }
    }
}
