using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            Shop shop = new Shop();
            FileOperations file = new FileOperations();
            shop.Player = player;
            file.Player = player;
            bool killedDragon = false;

            
            while (true)
            {
                if (file.checkFile())
                {
                    file.syncDataIn();
                }
                if (player.NewPlayer)
                {
                    Console.WriteLine("Hello traveler...");
                    Console.WriteLine("You have 10 gold to spend");
                    Console.WriteLine("You can buy a sword with that.");
                    Console.WriteLine("Then you can kill the monsters outside of our city");
                    Console.WriteLine("When you kill a monster bring it's head to our king");
                    Console.WriteLine("He will reward you with gold.");
                    Console.WriteLine("Some monster's reward might be higher than the others");
                    Console.WriteLine("Good luck...");
                    player.NewPlayer = false;
                }
                while (player.Health > 0 && !killedDragon)
                {
                    try
                    {
                        Console.WriteLine();
                        player.mainInfo();
                        Console.WriteLine("1-Speak with king.");
                        Console.WriteLine("2-Go to blacksmith.");
                        Console.WriteLine("3-Go to healer");
                        Console.WriteLine("4-Go outside to fight with monsters.");
                        Console.WriteLine("5-Rest.");
                        Console.WriteLine("6-Info");
                        Console.WriteLine("0-Quit");
                        int menu = Convert.ToInt32(Console.ReadLine());
                        switch (menu)
                        {
                            case 0:
                                file.syncDataOut();
                                System.Environment.Exit(0);
                                break;
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("1-Buy a house (100 gold)");
                                Console.WriteLine("2-Speak");
                                Console.WriteLine("0-Quit");
                                int kingMenu = Convert.ToInt32(Console.ReadLine());
                                if (kingMenu == 1)
                                {
                                    if (player.Gold >= 100)
                                    {
                                        player.Gold -= 100;
                                        Console.WriteLine();
                                        Console.WriteLine("You bought a house");
                                        player.setHouse(true);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You don't have enough gold.");
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                                if (kingMenu == 2)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Hello traveler...");
                                    Console.WriteLine("If you bring me the monster head i will pay you gold.");
                                    Console.WriteLine("And there is one more thing...");
                                    Console.WriteLine("There is a dragon somewhere outside and it makes big trouble for us");
                                    Console.WriteLine("If you kill it and bring it's head to me ");
                                    Console.WriteLine("You will be hero of this city.");
                                    Console.WriteLine("Good luck out there...");
                                    Console.WriteLine();
                                    player.DragonQuest = true;
                                    break;
                                }
                                if (kingMenu == 3)
                                {
                                    break;
                                }
                                break;

                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("What are you looking for?");
                                Console.WriteLine("1-Buy weapon");
                                Console.WriteLine("2-Buy armor");
                                Console.WriteLine("3-Sell");
                                Console.WriteLine("0-Quit");
                                int menu2 = Convert.ToInt32(Console.ReadLine());
                                switch (menu2)
                                {
                                    case 0:
                                        break;

                                    case 1:
                                        shop.buyWeapon();
                                        break;

                                    case 2:
                                        shop.buyArmor();
                                        break;

                                    case 3:
                                        Console.WriteLine();
                                        Console.WriteLine("I can buy your equipments only half of it's price!");
                                        Console.WriteLine("1-Sell your weapon");
                                        Console.WriteLine("2-Sell your armor");
                                        Console.WriteLine("0-Quit");

                                        int menu5 = Convert.ToInt32(Console.ReadLine());
                                        if (menu5 == 1)
                                        {
                                            shop.sellEquipmentWeapon();
                                            break;
                                        }
                                        else
                                        {
                                            if (menu5 == 2)
                                            {
                                                shop.sellEquipmentArmor();
                                                break;
                                            }
                                            else
                                            {
                                                if (menu5 == 0)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine();
                                                    Console.WriteLine("Input should be between 0-3!");
                                                    Console.WriteLine();
                                                    continue;
                                                }
                                            }
                                        }
                                        break;

                                    default:
                                        Console.WriteLine();
                                        Console.WriteLine("Input should be between 0-3!");
                                        Console.WriteLine();
                                        continue;
                                }
                                break;

                            case 3:
                                Console.WriteLine();
                                Console.WriteLine("1-Heal 50 health (10 gold)");
                                Console.WriteLine("2-Heal 100 health (20 gold)");
                                Console.WriteLine("0-Quit");
                                int menu6 = Convert.ToInt32(Console.ReadLine());

                                if (menu6 == 1)
                                {
                                    if (player.Gold < 10)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You don't have enough gold!");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else
                                    {
                                        player.Gold -= 10;
                                        if (player.Health <= 50)
                                        {
                                            player.Health += 50;
                                            Console.WriteLine();
                                            Console.WriteLine("Your new health: " + player.Health);
                                            Console.WriteLine();
                                            break;
                                        }
                                        else
                                        {
                                            player.Health = 100;
                                            Console.WriteLine();
                                            Console.WriteLine("Your new health: " + player.Health);
                                            Console.WriteLine();
                                            break;
                                        }
                                    }

                                }
                                if (menu6 == 2)
                                {
                                    if (player.Gold < 20)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("You don't have enough gold!");
                                        Console.WriteLine();
                                        break;
                                    }
                                    else
                                    {
                                        player.Gold -= 20;
                                        player.Health = 100;
                                        Console.WriteLine();
                                        Console.WriteLine("Your new health: " + player.Health);
                                        Console.WriteLine();
                                        break;
                                    }

                                }
                                if (menu6 == 0)
                                {
                                    break;
                                }

                                break;

                            case 4:
                                Console.WriteLine("1-Fight with easy monster.");
                                Console.WriteLine("2-Fight with normal monster.");
                                Console.WriteLine("3-Fight with hard monster.");
                                if (player.DragonQuest)
                                {
                                    Console.WriteLine("4-Fight with dragon.");
                                }
                                Console.WriteLine("0-Quit");
                                int menu7 = Convert.ToInt32(Console.ReadLine());
                                Monster monster;
                                monster = new EasyMonster();
                                Monster monster2;
                                monster2 = new NormalMonster();
                                Monster monster3;
                                monster3 = new HardMonster();
                                if (menu7 == 1)
                                {

                                    
                                    while (true)
                                    {
                                        player.mainInfo();
                                       
                                        monster.monsterInfo();
                                        Console.WriteLine("1-Fight");
                                        Console.WriteLine("2-Next (-1 stamina)");
                                        Console.WriteLine("0-Go back to city");
                                        int menu8 = Convert.ToInt32(Console.ReadLine());
                                        if (menu8 == 1)
                                        {
                                            if (player.Stamina >= 10)
                                            {
                                                player.Fight(monster);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("You don't have enough stamina go get rest.");
                                                Console.WriteLine();
                                                break;
                                            }

                                        }
                                        if (menu8 == 2)
                                        {
                                            monster = new EasyMonster();
                                            player.Stamina -= 1;
                                            continue;
                                        }
                                        if (menu8 == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (menu7 == 2)
                                {
                                    
                                    while (true)
                                    {
                                        player.mainInfo();
                                        monster2.monsterInfo();
                                        Console.WriteLine("1-Fight");
                                        Console.WriteLine("2-Next (-1 stamina)");
                                        Console.WriteLine("0-Go back to city");
                                        int menu8 = Convert.ToInt32(Console.ReadLine());
                                        if (menu8 == 1)
                                        {
                                            if (player.Stamina >= 10)
                                            {
                                                player.Fight(monster2);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("You don't have enough stamina go get rest.");
                                                Console.WriteLine();
                                                break;
                                            }
                                        }
                                        if (menu8 == 2)
                                        {
                                            monster2 = new NormalMonster();
                                            player.Stamina -= 1;
                                            continue;
                                        }
                                        if (menu8 == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (menu7 == 3)
                                {
                                    
                                    while (true)
                                    {
                                        player.mainInfo();
                                        
                                        monster3.monsterInfo();
                                        Console.WriteLine("1-Fight");
                                        Console.WriteLine("2-Next (-1 stamina)");
                                        Console.WriteLine("0-Go back to city");
                                        int menu8 = Convert.ToInt32(Console.ReadLine());
                                        if (menu8 == 1)
                                        {
                                            if (player.Stamina >= 10)
                                            {
                                                player.Fight(monster3);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("You don't have enough stamina go get rest.");
                                                Console.WriteLine();
                                                break;
                                            }
                                        }
                                        if (menu8 == 2)
                                        {
                                            monster3 = new HardMonster();
                                            player.Stamina -= 1;
                                            continue;
                                        }
                                        if (menu8 == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (menu7 == 4 && player.DragonQuest)
                                {
                                    Monster dragon;
                                    while (true)
                                    {
                                        player.mainInfo();
                                        dragon = new Dragon();
                                        dragon.monsterInfo();
                                        Console.WriteLine("1-Fight");
                                        Console.WriteLine("0-Go back to city");
                                        int menu8 = Convert.ToInt32(Console.ReadLine());
                                        if (menu8 == 1)
                                        {
                                            if (player.Stamina >= 50)
                                            {
                                                player.Fight(dragon);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("You don't have enough stamina go get rest.");
                                                Console.WriteLine();
                                                break;
                                            }
                                        }
                                        if (menu8 == 0)
                                        {
                                            break;
                                        }
                                    }
                                }


                                break;

                            case 5:

                                Console.WriteLine("1-Rest in street");
                                Console.WriteLine("2-Rest in motel(10 gold)");
                                if (player.getHouse())
                                {
                                    Console.WriteLine("3-Rest in home");
                                }
                                Console.WriteLine("0-Quit");
                                int menu9 = Convert.ToInt32(Console.ReadLine());

                                if (menu9 == 1)
                                {
                                    player.restInStreet();
                                    break;
                                }
                                if (menu9 == 2 && player.Gold >= 10)
                                {
                                    player.restInMotel();
                                    player.Gold -= 10;
                                    break;

                                }
                                if (menu9 == 3 && player.getHouse())
                                {
                                    player.restInHome();
                                    break;

                                }
                                if (menu9 == 0)
                                {
                                    break;
                                }

                                break;

                            case 6:
                                player.mainInfo();
                                break;
                            default:
                                Console.WriteLine("Input should be between 0-5!");
                                continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Input should only be integer!");
                        Console.WriteLine();
                    }
                    if (killedDragon)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You finished the game!");
                        Console.WriteLine();
                        file.syncDataDead();
                        break;
                    }
                    if (player.Health <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You died!");
                        Console.WriteLine();
                        file.syncDataDead();
                        continue;
                    }
                }
            }
        }
    }
}

