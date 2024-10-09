using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8.models
{
    public class Hero : Character
    {
        public Hero(string name, int money, int health, int lightAbility): base(name, money, health, lightAbility)
        {
        }



        
        public void Heal(Hero hero, int amount)
        {
            if (this.Health > amount)
            {
 
                hero.Health += amount;
                this.Health -= amount;
                Console.WriteLine(hero.ToString());
            }
            else
            {
                Console.WriteLine($"{this.Name} does not have enough health to heal.");
            }
        }

        public override void Attack(Character opponent) => opponent.Health-= this.Power;

    }
}
