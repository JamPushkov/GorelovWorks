using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemApp
{
    class Warior : Player
    {
        public Warior(int hp, int str, string name) : base(hp, str, name)
        {
            _class = "Разбойник";

            Random rnd = new Random();

        }
    }
}
