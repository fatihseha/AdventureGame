using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Armor
    {
        private double protection;
        private String name;

        public double Protection { 
            get => protection; 
            set => protection = value; 
        }
        public string Name { 
            get => name; 
            set => name = value;
        }
        public Armor(double protection,String name)
        {
            this.protection = protection;
            this.name = name;
        }
    }
}
