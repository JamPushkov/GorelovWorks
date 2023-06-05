using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemApp
{
    class Player
    {
        protected int health;
        protected int strenght;
        protected string name;
        protected string _class;

        public Player(int hp, int str, string name)
        {
            this.health = hp;
            this.strenght = str;
            this.name = name;
            _class = "Игрок";
        }

        public virtual void Hit(Player target)
        {
                { 
                target.TakeDamge(strenght);
                Console.WriteLine($"{Info()} наносит удар по {target.Info()}");
                }
        }

        public void TakeDamge(int dmg)
        {
            Console.WriteLine($"{Info()} получил {dmg} урона");
            health -= dmg;
        }

        public bool IsLose()
        {
            return health <= 0;
        }

        public string Info()
        {
            return $"({_class}) {name}[{health}]";
        }

        public string Infoname()
        {
            return $"{name}";
        }

        public bool IfStan()
        {
            return true;
        }

        public bool IfBurn()
        {
            return true;
        }
    }
}