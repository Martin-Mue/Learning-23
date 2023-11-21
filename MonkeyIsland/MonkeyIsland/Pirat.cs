using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    public class Pirat
    {
        private string name;
        public Pirat(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}
