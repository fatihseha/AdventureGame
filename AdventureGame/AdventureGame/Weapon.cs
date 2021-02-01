using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Weapon
    {
        private double damage;
        private String name;

        public double Damage { 
            get => damage; 
            set => damage = value; 
        }
        public string Name { 
            get => name; 
            set => name = value;
        }

        public Weapon(double damage,String name)
        {
            this.damage = damage;
            this.name = name;
        }
    }
}
