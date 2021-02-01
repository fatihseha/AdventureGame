using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Shop
    {
        private Character player;

        internal Character Player { get => player; set => player = value; }

        public void buyWeapon()
        {
            Console.WriteLine();
            Console.WriteLine("1-Buy Iron Sword (damage : 10) 10 gold.");
            Console.WriteLine("2-Buy Spear (damage : 15) 20 gold.");
            Console.WriteLine("3-Buy Axe (damage : 25) 36 gold.");
            Console.WriteLine("4-Buy Katana (damage : 55) 90 gold.");
            Console.WriteLine("0-Quit");
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1 && Player.Gold >= 10)
            {
                if (Player.Weapon.Damage == 5)
                {

                }
                else
                {
                    if (Player.Weapon.Damage == 10)
                    {
                        Player.Gold += 5;
                        Console.WriteLine();
                        Console.WriteLine("You sold your old weapon for 5 gold!");
                        Console.WriteLine();
                    }
                    else
                    {
                        if (Player.Weapon.Damage == 15)
                        {
                            Player.Gold += 10;
                            Console.WriteLine();
                            Console.WriteLine("You sold your old weapon for 10 gold!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (Player.Weapon.Damage == 25)
                            {
                                Player.Gold += 18;
                                Console.WriteLine();
                                Console.WriteLine("You sold your old weapon for 18 gold!");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (Player.Weapon.Damage == 55)
                                {
                                    Player.Gold += 45;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old weapon for 45 gold!");
                                    Console.WriteLine();
                                }
                            }

                        }

                    }

                }
                Player.setWeapon(new Weapon(10, "Iron Sword"));
                Player.Gold = Player.Gold - 10;
                Console.WriteLine();
                Console.WriteLine("You bought Iron Sword!");
                Console.WriteLine();
                return;
            }
            else
            {
                if (menu == 2 && Player.Gold >= 20)
                {
                    if (Player.Weapon.Damage == 5)
                    {

                    }
                    else
                    {
                        if (Player.Weapon.Damage == 10)
                        {
                            Player.Gold += 5;
                            Console.WriteLine();
                            Console.WriteLine("You sold your old weapon for 5 gold!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (Player.Weapon.Damage == 15)
                            {
                                Player.Gold += 10;
                                Console.WriteLine();
                                Console.WriteLine("You sold your old weapon for 10 gold!");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (Player.Weapon.Damage == 25)
                                {
                                    Player.Gold += 18;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old weapon for 18 gold!");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    if (Player.Weapon.Damage == 55)
                                    {
                                        Player.Gold += 45;
                                        Console.WriteLine();
                                        Console.WriteLine("You sold your old weapon for 45 gold!");
                                        Console.WriteLine();
                                    }
                                }

                            }

                        }

                    }
                    Player.setWeapon(new Weapon(15, "Spear"));
                    Player.Gold = Player.Gold - 20;
                    Console.WriteLine();
                    Console.WriteLine("You bought Spear!");
                    Console.WriteLine();
                    return;
                    
                }
                else
                {
                    if (menu == 3 && Player.Gold >= 36)
                    {
                        if (Player.Weapon.Damage == 5)
                        {

                        }
                        else
                        {
                            if (Player.Weapon.Damage == 10)
                            {
                                Player.Gold += 5;
                                Console.WriteLine();
                                Console.WriteLine("You sold your old weapon for 5 gold!");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (Player.Weapon.Damage == 15)
                                {
                                    Player.Gold += 10;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old weapon for 10 gold!");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    if (Player.Weapon.Damage == 25)
                                    {
                                        Player.Gold += 18;
                                        Console.WriteLine();
                                        Console.WriteLine("You sold your old weapon for 18 gold!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        if (Player.Weapon.Damage == 55)
                                        {
                                            Player.Gold += 45;
                                            Console.WriteLine();
                                            Console.WriteLine("You sold your old weapon for 45 gold!");
                                            Console.WriteLine();
                                        }
                                    }

                                }

                            }

                        }
                        Player.setWeapon(new Weapon(25, "Axe"));
                        Player.Gold = Player.Gold - 36;
                        Console.WriteLine();
                        Console.WriteLine("You bought Axe!");
                        Console.WriteLine();
                        return;
                        
                    }
                    else
                    {
                        if (menu == 4 && Player.Gold >= 90)
                        {
                            if (Player.Weapon.Damage == 5)
                            {

                            }
                            else
                            {
                                if (Player.Weapon.Damage == 10)
                                {
                                    Player.Gold += 5;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old weapon for 5 gold!");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    if (Player.Weapon.Damage == 15)
                                    {
                                        Player.Gold += 10;
                                        Console.WriteLine();
                                        Console.WriteLine("You sold your old weapon for 10 gold!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        if (Player.Weapon.Damage == 25)
                                        {
                                            Player.Gold += 18;
                                            Console.WriteLine();
                                            Console.WriteLine("You sold your old weapon for 18 gold!");
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            if (Player.Weapon.Damage == 55)
                                            {
                                                Player.Gold += 45;
                                                Console.WriteLine();
                                                Console.WriteLine("You sold your old weapon for 45 gold!");
                                                Console.WriteLine();
                                            }
                                        }

                                    }

                                }

                            }
                            Player.setWeapon(new Weapon(55, "Katana"));
                            Player.Gold = Player.Gold - 90;
                            Console.WriteLine();
                            Console.WriteLine("You bought Katana!");
                            Console.WriteLine();
                            return;
                            
                        }
                        else
                        {
                            if (menu == 0)
                            {
                                return;
                            }

                        }
                    }
                }
            }
            

        }
        public void buyArmor()
        {
            Console.WriteLine();
            Console.WriteLine("1-Buy Cloth Vest (protection : 3) 12 gold.");
            Console.WriteLine("2-Buy Chainmail (protection : 6) 24 gold.");
            Console.WriteLine("3-Buy Iron Chestplate (protection : 9) 36 gold.");
            Console.WriteLine("4-Buy Steel Chestplate (protection : 12) 60 gold.");
            Console.WriteLine("0-Quit");
            int menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1 && Player.Gold >= 12)
            {
                if (Player.Armor == null)
                {

                }
                else
                {
                    if (Player.Armor.Protection==3)
                    {
                        Player.Gold += 6;
                        Console.WriteLine();
                        Console.WriteLine("You sold your old armor for 6 gold!");
                        Console.WriteLine();
                    }
                    else
                    {
                        if (Player.Armor.Protection == 6)
                        {
                            Player.Gold += 12;
                            Console.WriteLine();
                            Console.WriteLine("You sold your old armor for 12 gold!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (Player.Armor.Protection == 9)
                            {
                                Player.Gold += 18;
                                Console.WriteLine();
                                Console.WriteLine("You sold your old armor for 18 gold!");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (Player.Armor.Protection == 12)
                                {
                                    Player.Gold += 30;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old armor for 30 gold!");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
                Player.setArmor(new Armor(3, "Cloth Vest"));
                Player.Gold = Player.Gold - 12;
                Console.WriteLine();
                Console.WriteLine("You bought Cloth Vest!");
                Console.WriteLine();
                return;
            }
            else
            {
                if (menu == 2 && Player.Gold >= 24)
                {
                    if (Player.Armor == null)
                    {

                    }
                    else
                    {
                        if (Player.Armor.Protection == 3)
                        {
                            Player.Gold += 6;
                            Console.WriteLine();
                            Console.WriteLine("You sold your old armor for 6 gold!");
                            Console.WriteLine();
                        }
                        else
                        {
                            if (Player.Armor.Protection == 6)
                            {
                                Player.Gold += 12;
                                Console.WriteLine();
                                Console.WriteLine("You sold your old armor for 12 gold!");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (Player.Armor.Protection == 9)
                                {
                                    Player.Gold += 18;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old armor for 18 gold!");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    if (Player.Armor.Protection == 12)
                                    {
                                        Player.Gold += 30;
                                        Console.WriteLine();
                                        Console.WriteLine("You sold your old armor for 30 gold!");
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                    Player.setArmor(new Armor(6, "Chainmail"));
                    Console.WriteLine();
                    Console.WriteLine("You bought Chainmail!");
                    Console.WriteLine();
                    Player.Gold = Player.Gold - 24;
                    return;
                }
                else
                {
                    if (menu == 3 && Player.Gold >= 36)
                    {
                        if (Player.Armor == null)
                        {

                        }
                        else
                        {
                            if (Player.Armor.Protection == 3)
                            {
                                Player.Gold += 6;
                                Console.WriteLine();
                                Console.WriteLine("You sold your old armor for 6 gold!");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (Player.Armor.Protection == 6)
                                {
                                    Player.Gold += 12;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old armor for 12 gold!");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    if (Player.Armor.Protection == 9)
                                    {
                                        Player.Gold += 18;
                                        Console.WriteLine();
                                        Console.WriteLine("You sold your old armor for 18 gold!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        if (Player.Armor.Protection == 12)
                                        {
                                            Player.Gold += 30;
                                            Console.WriteLine();
                                            Console.WriteLine("You sold your old armor for 30 gold!");
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                        }
                        Player.setArmor(new Armor(9, "Iron Chestplate"));
                        Console.WriteLine();
                        Console.WriteLine("You bought Iron Chestplate!");
                        Console.WriteLine();
                        Player.Gold = Player.Gold - 36;
                        return;
                    }
                    else
                    {
                        if (menu == 4 && Player.Gold >= 60)
                        {
                            if (Player.Armor == null)
                            {

                            }
                            else
                            {
                                if (Player.Armor.Protection == 3)
                                {
                                    Player.Gold += 6;
                                    Console.WriteLine();
                                    Console.WriteLine("You sold your old armor for 6 gold!");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    if (Player.Armor.Protection == 6)
                                    {
                                        Player.Gold += 12;
                                        Console.WriteLine();
                                        Console.WriteLine("You sold your old armor for 12 gold!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        if (Player.Armor.Protection == 9)
                                        {
                                            Player.Gold += 18;
                                            Console.WriteLine();
                                            Console.WriteLine("You sold your old armor for 18 gold!");
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            if (Player.Armor.Protection == 12)
                                            {
                                                Player.Gold += 30;
                                                Console.WriteLine();
                                                Console.WriteLine("You sold your old armor for 30 gold!");
                                                Console.WriteLine();
                                            }
                                        }
                                    }
                                }
                            }
                            Player.setArmor(new Armor(12, "Steel Chestplate"));
                            Player.Gold = Player.Gold - 60;
                            Console.WriteLine();
                            Console.WriteLine("You bought Steel Chestplate");
                            Console.WriteLine();
                            return; 
                        }
                        else
                        {
                            if (menu == 0)
                            {
                                return; 
                            }

                        }
                    }
                }
            }
        }
        public void sellEquipmentWeapon()
        {
            
                if (Player.Weapon.Damage == 5)
                {
                Console.WriteLine();
                Console.WriteLine("You have nothing to sell!");
                Console.WriteLine();
                return;
                }
                else
                {
                    if (Player.Weapon.Damage == 10)
                    {
                    Player.setWeapon(new Weapon(5, "Fist"));
                    Console.WriteLine();
                    Console.WriteLine("You sold your Iron Sword for 5 gold!");
                    Console.WriteLine();
                    Player.Gold = Player.Gold + 5;
                    return;
                }
                    else
                    {
                        if (Player.Weapon.Damage == 15)
                        {
                        Player.setWeapon(new Weapon(5, "Fist"));
                        Console.WriteLine();
                        Console.WriteLine("You sold your Spear for 10 gold!");
                        Console.WriteLine();
                        Player.Gold = Player.Gold + 10;
                        return;
                    }
                        else
                        {
                            if (Player.Weapon.Damage == 25)
                            {
                            Player.setWeapon(new Weapon(5, "Fist"));
                            Console.WriteLine();
                            Console.WriteLine("You sold your Axe for 18 gold!");
                            Console.WriteLine();
                            Player.Gold = Player.Gold + 18;
                            return;
                        }
                            else
                            {
                                if (Player.Weapon.Damage == 55)
                                {
                                Player.setWeapon(new Weapon(5, "Fist"));
                                Console.WriteLine();
                                Console.WriteLine("You sold your Katana for 45 gold!");
                                Console.WriteLine();
                                Player.Gold = Player.Gold + 45;
                                return;
                            }
                            }

                        }

                    }

                }
            
        }
        public void sellEquipmentArmor()
        {

            if (Player.Armor==null)
            {
                Console.WriteLine();
                Console.WriteLine("You have nothing to sell!");
                Console.WriteLine();
                return;
            }
            else
            {
                if (Player.Armor.Protection == 3)
                {
                    Player.Armor = null;
                    Console.WriteLine();
                    Console.WriteLine("You sold your Cloth Vest for 6 gold!");
                    Console.WriteLine();
                    Player.Gold = Player.Gold + 5;
                    return;
                }
                else
                {
                    if (Player.Armor.Protection == 6)
                    {
                        Player.Armor = null;
                        Console.WriteLine();
                        Console.WriteLine("You sold your Chainmail for 12 gold!");
                        Console.WriteLine();
                        Player.Gold = Player.Gold + 10;
                        return;
                    }
                    else
                    {
                        if (Player.Armor.Protection == 9)
                        {
                            Player.Armor = null;
                            Console.WriteLine();
                            Console.WriteLine("You sold your Iron Chestplate for 18 gold!");
                            Console.WriteLine();
                            Player.Gold = Player.Gold + 18;
                            return;
                        }
                        else
                        {
                            if (Player.Armor.Protection == 12)
                            {
                                Player.Armor = null;
                                Console.WriteLine();
                                Console.WriteLine("You sold your Steel Chestplate for 30 gold!");
                                Console.WriteLine();
                                Player.Gold = Player.Gold + 45;
                                return;
                            }
                        }

                    }

                }

            }

        }
    }
}
