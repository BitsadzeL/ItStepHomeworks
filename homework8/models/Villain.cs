using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8.models
{
    public class Villain : Character
    {
        public Villain(string name, int money, int health, int darkAbility)
            : base(name, money, health, darkAbility)
        {
        }

        public override void Attack(Character opponent)
        {
            opponent.Health += this.Power;
            Console.WriteLine(opponent.ToString());
            
        }
    }
}
