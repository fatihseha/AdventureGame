using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Character
    {
        private double health = 100;
        private double stamina = 100;
        private int gold = 10;
        private Weapon weapon;
        private Armor armor;
        private bool hasAHouse = false;
        private bool dragonQuest = false;
        private bool newPlayer = true;

        public Character()
        {
            this.Weapon = new Weapon(5, "Fist");
        }

        public double Health { 
            get => health; 
            set => health = value; 
        }
        public double Stamina {
            get => stamina; 
            set => stamina = value;
        }
        public int Gold { 
            get => gold; 
            set => gold = value; 
        }
        public bool DragonQuest { get => dragonQuest; set => dragonQuest = value; }
        internal Weapon Weapon { get => weapon; set => weapon = value; }
        internal Armor Armor { get => armor; set => armor = value; }
        public bool NewPlayer { get => newPlayer; set => newPlayer = value; }

        public double getDamage()
        {
            return this.Weapon.Damage;
        }
        public double getProtection()
        {
            return this.Armor.Protection;
        }
        public void setWeapon(Weapon weapon)
        {
            this.Weapon = weapon;
        }
        public Weapon getWeapon()
        {
            return Weapon;
        }
        public void setArmor(Armor armor)
        {
            this.Armor = armor;
        }
        public Armor getArmor()
        {
            return Armor;
        }
        
        public bool getHouse()
        {
            return hasAHouse;
        }
        public void setHouse(bool house)
        {
            this.hasAHouse = house;
        }

        public void Attack(Monster monster)
        {
            if (this.Weapon.Damage - monster.Protection > 0)
            {
                monster.Health = monster.Health - (this.Weapon.Damage - monster.Protection );
                stamina = stamina - 1;
                return;
            }
            else
            {
                if (this.Weapon.Damage - monster.Protection <= 0)
                {
                    stamina = stamina - 1;
                    return;
                }
            }
        }

        public void Fight(Monster monster)
        {
            
            while (this.health>0 && monster.Health>0)
            {
               
                Attack(monster);
                if (monster.Health > 0)
                {
                    monster.Attack(this);
                    
                }
                else
                {
                    break;
                }
            }
            if (this.health <= 0)
            {
                return;
            }
            else
            {
                if (monster.Health <= 0)
                {
                    this.Gold += monster.Gold;
                    Console.WriteLine("You won the fight!");
                    Console.WriteLine("You got " + monster.Gold + " gold from the monster!");
                    if (stamina <= 0)
                    {
                        stamina = 0;
                    }
                    return;
                }
            }
        }

        public void restInStreet()
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            if (a>=0 && a<5)
            {
                this.setWeapon(new Weapon(5, "Fist"));
                this.setArmor(null);
                Console.WriteLine("Your weapon and armor were stolen!");
            }
            if (a >= 5 && a < 15)
            {
                this.setWeapon(new Weapon(5, "Fist"));
                Console.WriteLine("Your weapon was stolen!");
            }
            if (a >= 15 && a < 25)
            {
                this.setArmor(null);
                Console.WriteLine("Your armor was stolen!");
            }


            this.stamina = this.stamina + 10;
            if (this.stamina > 100)
            {
                this.stamina = 100;
                Console.WriteLine("Your new stamina: " + this.stamina);
            }
            else
            {
                Console.WriteLine("Your new stamina: " + this.stamina);
            }
        }
        public void restInMotel()
        {
            Random random = new Random();
            int a = random.Next(1, 100);

            if (a >= 0 && a < 3)
            {
                this.setWeapon(new Weapon(5, "Fist"));
                this.setArmor(null);
                Console.WriteLine("Your weapon and armor were stolen!");
            }
            if (a >= 3 && a < 8)
            {
                this.setWeapon(new Weapon(5, "Fist"));
                Console.WriteLine("Your weapon was stolen!");
            }
            if (a >= 8 && a < 13)
            {
                this.setArmor(null);
                Console.WriteLine("Your armor was stolen!");
            }

            this.stamina = this.stamina + 50;
            if (this.stamina > 100)
            {
                this.stamina = 100;
                Console.WriteLine("Your new stamina: " + this.stamina);
            }
            else
            {
                Console.WriteLine("Your new stamina: " + this.stamina);
            }
        }
        public void restInHome()
        {
            this.stamina += 50;
            Console.WriteLine("Your new stamina: " + this.stamina);
        }
        public void mainInfo()
        {
            Console.WriteLine("You have " + gold + " gold.");
            Console.WriteLine("You have " + health + " health.");
            Console.WriteLine("You have " + stamina + " stamina.");
            Console.WriteLine("You have "+weapon.Damage+" damage.");
            Console.Write("You have ");
            if (armor == null)
            {
                Console.WriteLine("0 protection");
            }
            else
            {
                Console.WriteLine(armor.Protection + " protection");
            }
                Console.WriteLine();
        }
    }

}

