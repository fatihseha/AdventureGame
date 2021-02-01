using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class FileOperations
    {
       private Character player;

        String path = @"C:\Users\Seha\source\repos\AdventureGame\AdventureGame\TextFile.txt";

        internal Character Player { get => player; set => player = value; }

        public bool checkFile()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path))
                {
                    writer.WriteLine(100);
                    writer.WriteLine(100);
                    writer.WriteLine(10);
                    writer.WriteLine("0");
                    writer.WriteLine("0");
                    writer.WriteLine(false);
                    writer.WriteLine(false);
                    writer.WriteLine(true);
                    return false;
                }
            }
            return true;
        }
        public void syncDataIn()
        {
            String[] data;
            data = File.ReadAllLines(path);

            Player.Health = Convert.ToDouble(data[0]);
            Player.Stamina = Convert.ToDouble(data[1]);
            Player.Gold = Convert.ToInt32(data[2]);
            if (data[3].Equals("0"))
            {
                Player.setWeapon(new Weapon(5, "Fist"));
            }
            else
            {
                if (data[3].Equals("1"))
                {
                    Player.setWeapon(new Weapon(10, "Iron Sword"));
                }
                else
                {
                    if (data[3].Equals("2"))
                    {
                        Player.setWeapon(new Weapon(15, "Spear"));
                    }
                    else
                    {
                        if (data[3].Equals("3"))
                        {
                            Player.setWeapon(new Weapon(25, "Axe"));
                        }
                        else
                        {
                            if (data[3].Equals("4"))
                            {
                                Player.setWeapon(new Weapon(55, "Katana"));
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            if (data[4].Equals("0"))
            {
                Player.setArmor(null);
            }
            else
            {
                if (data[4].Equals("1"))
                {
                    Player.setArmor(new Armor(3, "Cloth"));
                }
                else
                {
                    if (data[4].Equals("2"))
                    {
                        Player.setArmor(new Armor(6, "Chainmail"));
                    }
                    else
                    {
                        if (data[4].Equals("3"))
                        {
                            Player.setArmor(new Armor(9, "Iron Chestplate"));
                        }
                        else
                        {
                            if (data[4].Equals("4"))
                            {
                                Player.setArmor(new Armor(12, "Steel Chestplate"));
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            if (data[5] == "False")
            {
                Player.setHouse(false);
            }
            else
            {
                Player.setHouse(true);
            }
            if (data[6] == "False")
            {
                Player.DragonQuest = false;
            }
            else
            {
                Player.DragonQuest = true;
            }
            if (data[7] == "False")
            {
                Player.NewPlayer=false;
            }
            else
            {
                Player.NewPlayer = true;
            }
        }

        public void syncDataOut()
        {
            File.Delete(path);

            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(Player.Health);
                writer.WriteLine(Player.Stamina);
                writer.WriteLine(Player.Gold);
                if (Player.Weapon.Damage == 5)
                {
                    writer.WriteLine("0");
                }
                else
                {
                    if (Player.Weapon.Damage == 10)
                    {
                        writer.WriteLine("1");
                    }
                    else
                    {
                        if (Player.Weapon.Damage == 15)
                        {
                            writer.WriteLine("2");
                        }
                        else
                        {
                            if (Player.Weapon.Damage == 25)
                            {
                                writer.WriteLine("3");
                            }
                            else
                            {
                                if (Player.Weapon.Damage == 55)
                                {
                                    writer.WriteLine("4");
                                }
                            }

                        }

                    }

                }
                if (Player.Armor == null)
                {
                    writer.WriteLine("0");
                }
                else
                {
                    if (Player.Armor.Protection == 3)
                    {
                        writer.WriteLine("1");
                    }
                    else
                    {
                        if (Player.Armor.Protection == 6)
                        {
                            writer.WriteLine("2");
                        }
                        else
                        {
                            if (Player.Armor.Protection == 9)
                            {
                                writer.WriteLine("3");
                            }
                            else
                            {
                                if (Player.Armor.Protection == 12)
                                {
                                    writer.WriteLine("4");
                                }
                            }
                        }
                    }
                }
                writer.WriteLine(Player.getHouse());
                writer.WriteLine(Player.DragonQuest);
                writer.WriteLine(Player.NewPlayer);
            }
        }

        public void syncDataDead()
        {
            File.Delete(path);
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(100);
                writer.WriteLine(100);
                writer.WriteLine(10);
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine(false);
                writer.WriteLine(false);
                writer.WriteLine(true);
            }
        }

    }
}
