using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInstanceConstructors
{
    public class NamedItem(string name)
    {
        public string Name => name;
    }

}
