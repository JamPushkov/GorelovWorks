using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Stats
    {
        public int exp;
        public int bodrost;
        public int hungry;
        public int money;
        public int home;
        public int work;
        public int zp;
        public int maxhungry;
        public int maxbodrost;
        public int hp;
        public int maxhp;

        public Stats(int exp, int bodrost, int hungry, int money, int home, int work, int zp, int maxhungry, int maxbodros, int hp, int maxhp)
        {
            this.exp = exp;
            this.bodrost = bodrost;
            this.hungry = hungry;
            this.money = money;
            this.home = home;
            this.work = work;
            this.zp = zp;
            this.maxhungry = maxhungry;
            this.maxbodrost = maxbodros;
            this.hp = hp;
            this.maxhp = maxhp;
        }
    }
}