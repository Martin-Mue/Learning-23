using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    public class Strand :Orte
    {
        private string name;

        public Strand(string name): base (name)
        {

            this.name = name;

        }
      
    }
}
