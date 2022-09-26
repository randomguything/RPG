using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace helloworld;

class Program
{
    static void Main()
    {
        int enemystartingnumbers = 1000;
        int playerstartingnumbers = 1000;
        int enemycurrentnumbers = 1000;
        int playercurrentnumbers = 1000;
        int enemymorale = 100;
        int playermorale = 100;
        
        bool enemyattacking = false;
        bool playerattacking = false;
        bool playerlost = false;
        bool enemylost = false;
        bool enemyrecievedcassualties;
        bool playerrecievedcasualties;


        Console.WriteLine("welcome genaral.\nYou have found yourself in a strange unfamiliar land after a storm at sea. \nyour division is on the march inland.\n");
        Thread.Sleep(2000);
        Console.WriteLine("you have encountered an opposing hostile force and are forced to engage with limited forces\n");
        Thread.Sleep(2000);
        Console.WriteLine("THE BATTLE HAS BEGUN\n");

        Thread.Sleep(5000);

        enemyattacking = true;
        playerattacking = false;

        while (playerlost == false || enemylost == false)
        {

            if (playercurrentnumbers  <= 0 || playermorale <= 0)
            {
                playerlost = true;
                Console.WriteLine("you have lost");
                return;
            }
            else if (enemycurrentnumbers  <= 0 || enemymorale <= 0)
            {
                enemylost = true;
                Console.WriteLine("you are victoriouse today");
            }

            if (enemyattacking = true)
            {
                Random enemyattack = new Random();
                int random_NUM = enemyattack.Next(1, 6);
                if (random_NUM == 1)
                {
                    Console.WriteLine("the enemy have fired however they missed all of their shots and their morale has been lowered your men's morale is at {0}", playermorale + "/100");
                    enemymorale -= 25;
                    enemyattacking = false;
                    Console.WriteLine("you have {0}", playercurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }
                else if (random_NUM == 2)
                {
                    Console.WriteLine("the enemy fires and misses all of their shots your men's morale is at {0}", playermorale + "/100");
                    enemyattacking = false;
                    Console.WriteLine("you have {0}", playercurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }

                else if (random_NUM == 3)
                {
                    playercurrentnumbers -= 25;
                    playermorale -= 5;
                    Console.WriteLine("the enemy has fired and they miss most of their shots and only inflict a few casualties your men's morale is at {0}", playermorale + "/100");
                    enemyattacking = false;
                    Console.WriteLine("you have {0}", playercurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }
                else if (random_NUM == 4)
                {
                    playercurrentnumbers -= 100;
                    playermorale -= 10;
                    Console.WriteLine("the enemy fires and inflicts casualties on your unit however your men's morale is at {0}", playermorale + "/100");
                    enemyattacking = false;
                    Console.WriteLine("you have {0}", playercurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }
                else if (random_NUM == 5)
                {
                    playercurrentnumbers -= 250;
                    playermorale -= 15;
                    Console.WriteLine("the enemy fires and inflicts heavy casualties on your men your men's morale is at {0}", playermorale + "/100");
                    enemyattacking = false;
                    Console.WriteLine("you have {0}", playercurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }
                else
                {
                    playercurrentnumbers -= 300;
                    playermorale -= 20;
                    Console.WriteLine("the enemy fires and inflicts very heavy casualtias on your men your men's morale is at {0}", playermorale + "/100");
                    enemyattacking = false;
                    Console.WriteLine("you have {0}", playercurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }




            }
            Thread.Sleep(2000);



            if (playerattacking = true)
            {
                Random playerattack = new Random();
                int random_NUM2 = playerattack.Next(1, 6);
                if (random_NUM2 == 1)
                {
                    Console.WriteLine("your men have fired but missed all of their shots and their morale has been lowered your men's morale is at {0}", playermorale + "/100");
                    enemymorale -= 25;
                    enemyattacking = false;
                    Console.WriteLine("you have {0}", playercurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }
                else if (random_NUM2 == 2)
                {
                    Console.WriteLine("your men fire and misse all of their shots the enemy's morale is at {0}", enemymorale + "/100");
                    enemyattacking = false;
                    Console.WriteLine("the enemy have {0}", enemycurrentnumbers + "/1000 men left\n");
                    playerattacking = true;
                }

                else if (random_NUM2 == 3)
                {
                    enemycurrentnumbers -= 25;
                    enemymorale -= 5;
                    Console.WriteLine("you men have fired and they miss most of their shots and only inflict a few casualties the enemy's morale is at {0}", enemymorale + "/100");
                    enemyattacking = true;
                    Console.WriteLine("the enemy have {0}", enemycurrentnumbers + "/1000 men left\n");
                    playerattacking = false;
                }
                else if (random_NUM2 == 4)
                {
                    enemycurrentnumbers -= 100;
                    enemymorale -= 10;
                    Console.WriteLine("your men fire and inflict casualties on the enemy unit however their morale is at {0}", enemymorale + "/100");
                    enemyattacking = true;
                    Console.WriteLine("the enemy have {0}", enemycurrentnumbers + "/1000 men left\n");
                    playerattacking = false;
                }
                else if (random_NUM2 == 5)
                {
                    playercurrentnumbers -= 250;
                    playermorale -= 15;
                    Console.WriteLine("your men fire and inflict heavy casualties on the enemy their morale is at {0}", enemymorale + "/100");
                    enemyattacking = true;
                    Console.WriteLine("the enemy have {0}", enemycurrentnumbers + "/1000 men left\n");
                    playerattacking = false;
                }
                else
                {
                    playercurrentnumbers -= 300;
                    playermorale -= 20;
                    Console.WriteLine("your men fire and inflict very heavy casualtias on the enemy their morale is at {0}", enemymorale + "/100");
                    enemyattacking = true;
                    Console.WriteLine("the enemy have {0}", enemycurrentnumbers + "/1000 men left\n");
                    playerattacking = false;
                }

                Thread.Sleep(2000);
            }

        
    
        }

    }
}


