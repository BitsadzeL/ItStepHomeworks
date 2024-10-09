using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8.models
{
    public class Character
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }


        public Character(string name, int money, int health, int power)
        {
            Name = name;
            Money = money;
            Health = health;
            Power = power;
        }


        public override string ToString()
        {
            return ($" {Name} has {Health} HP");
        }


        public virtual void Attack(Character opponent){}
    }
}
