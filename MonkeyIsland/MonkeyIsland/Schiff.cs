using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    public class Schiff : Orte
    {
        private string name;
        private Pirat pirat;
        public Schiff(string name): base(name)        
        {
            this.name = name;
        }
   
    }
}
