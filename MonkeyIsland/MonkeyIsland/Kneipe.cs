using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    public class Kneipe : Orte
    { 
        private string name;
        private Pirat pirat;
        private Insel insel;
        
        
        public Kneipe(string name) : base (name) {
            this.name = name;
        }
       
    }
}
