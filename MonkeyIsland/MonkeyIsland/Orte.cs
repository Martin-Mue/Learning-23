using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    public class Orte
    {
        private string name;
        private Pirat pirat;

        public Orte(string name)
        {
            this.name = name;
            this.pirat = pirat;

        }
       
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPirat(Pirat pirat) 
        {
            this.pirat = pirat;
        }
        public Pirat GetPirat()
        {
            return pirat;
        }
    }
}
