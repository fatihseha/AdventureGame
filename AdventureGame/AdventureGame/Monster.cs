using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Monster
    {
        private double damage;
        private double protection;
        private int gold;
        private double health = 100;

        public Monster(double damage,double protection,int gold)
        {
            this.damage = damage;
            this.protection = protection;
            this.gold = gold;
        }
        public Monster()
        {
            this.damage = 0;
            this.protection = 0;
            this.gold = 0;
        }

        public double Damage { 
            get => damage; 
            set => damage = value;
        }
        public double Protection { 
            get => protection; 
            set => protection = value; 
        }
        public int Gold { 
            get => gold; 
            set => gold = value; 
        }
        public double Health { 
            get => health; 
            set => health = value; 
        }

        public void Attack(Character character)
        {
            if (character.getArmor() != null)
            {
                if (this.damage-character.getArmor().Protection  > 0)
                {
                    
                    character.Health = character.Health - (this.damage-character.getArmor().Protection );
                    return;
                }
                else
                {
                    if (this.damage - character.getArmor().Protection <= 0)
                    {
                        
                        return;
                    }
                }
            }
            else
            {
                character.Health = character.Health -this.damage;
                return;
            }
        }
        public void monsterInfo()
        {
            Console.WriteLine("Monster's health " + health);
            Console.WriteLine("Monster's damage: "+damage);
            Console.WriteLine("Monster's gold: " + gold);
            Console.WriteLine("Monster's protection: " + protection);
        }
    }
}
