using MESBG_Probabilities;
using MESBGProbabilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MESBGProbabilties
{ 

    public class Program
    {

        //convert y, yes and true to true
        //anything else to false
        static bool YNToBool(string yn)
        {
            if (yn.ToLower() == "y" || yn.ToLower() == "yes" || yn.ToLower() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Shooting());

            //utility variables
            int preset = 0;
            bool repeat = false;
            bool temp;

            //Archer variables
            string archerName = "No Name";
            int shootValue = 0;
            int bowStrength = 0;
            bool rerollToHitAll = false;
            bool rerollToHitOnes = false;
            bool rerollToWoundAll = false;
            bool rerollToWoundOnes = false;
            bool isHero = false;

            //shooting variables
            bool moved = false;
            bool useAcuracy = false;
            int inWay = 1;
            bool useMight = false;
            int totalOfWarrior = 0;
            double probableWounds;

            //Target variables
            string targetName;
            int targetDefence;

            //initialize archer, hero and target
            Warrior archer = new Warrior();
            Hero hero = new Hero();
            Model target = new Model();
            /*
            do
            {
                //get archer info
                Console.WriteLine("Who is shooting?");
                Console.WriteLine("Type 1 if you want to use Blackroot Vale Archers");
                Console.WriteLine("Type 2 if you want to use Duinhir");
                Console.WriteLine("Type 3 if you want to Wood Elf Warriors");
                Console.WriteLine("Type anything else if you want to manualy enter stats");

                preset = int.Parse(Console.ReadLine());
                if (preset == 1)
                {
                    archer = new Warrior("Blackroot Vale Archers", 3, 2, false, true, true, false);
                    isHero = false;
                }
                else if (preset == 2)
                {
                    hero = new Hero("Duinhir", 3, 2, false, true, true, false);
                    isHero = true;

                }
                else if(preset == 3)
                {
                    archer = new Warrior("Wood Elf Warriors", 3, 3, false, false, false, false);
                    isHero = false;

                }
                else //custom archer
                {
                    Console.WriteLine("Let's get info on the archer.");
                    Console.Write("What is it's name?: ");
                    archerName = Console.ReadLine();

                    Console.Write($"Is {archerName} a hero? (y/n) : ");
                    isHero = YNToBool(Console.ReadLine());

                    Console.Write($"What is {archerName}'s shoot value? (y/n) : ");
                    shootValue = int.Parse(Console.ReadLine());

                    Console.Write($"Does {archerName} have rerolls? (y/n) : ");
                    temp = YNToBool(Console.ReadLine());

                    if (temp)
                    {
                        Console.WriteLine($"Does {archerName} have reroll all to Hits? (y/n)");
                        rerollToHitAll = YNToBool(Console.ReadLine());
                        if (!rerollToHitAll)
                        {

                            Console.WriteLine($"Does {archerName} have reroll ones to Hits? (y/n)");
                            rerollToHitAll = Convert.ToBoolean(Console.ReadLine());

                        }
                        Console.WriteLine($"Does {archerName} have reroll all to Wounds? (y/n)");
                        rerollToWoundAll = YNToBool(Console.ReadLine());
                        if (!rerollToWoundAll)
                        {

                            Console.WriteLine($"Does {archerName} have reroll ones to Wounds? (y/n)");
                            rerollToWoundAll = Convert.ToBoolean(Console.ReadLine());

                        }

                    }

                    //create the archer
                    if (isHero)
                    {
                        hero = new Hero(archerName, shootValue, bowStrength, rerollToHitAll, rerollToHitOnes, rerollToWoundAll, rerollToWoundOnes);
                    }
                    else
                    {
                        archer = new Warrior(archerName, shootValue, bowStrength, rerollToHitAll, rerollToHitOnes, rerollToWoundAll, rerollToWoundOnes);
                    }

                }


                //get info on shoot
                if (isHero)
                {
                    Console.WriteLine("Do you want to use might? (y/n)");
                    Console.WriteLine("Note: this will increace the value for all of to hit, in the way and to wounding");
                    useMight = YNToBool(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("How many archers are there?");
                    totalOfWarrior = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Did they move? (y/n)");
                moved = YNToBool(Console.ReadLine());

                Console.WriteLine("What is the In The Way Value?");
                Console.WriteLine("Note: If there is no in the way type 1");
                inWay = int.Parse(Console.ReadLine());

                if (inWay != 1)
                {
                    Console.WriteLine("Are they benefiting from Heroic Acuracy? (y/n)");
                    useAcuracy = YNToBool(Console.ReadLine());
                }
                else
                {
                    useAcuracy = false;
                }


                //get info on Target
                Console.WriteLine("Who is the Target?");
                Console.WriteLine("Type 1 if you want to use Blackroot Vale Archers");
                Console.WriteLine("Type 2 if you want to use Duinhir");
                Console.WriteLine("Type 3 if you want to use Wood Elf Warriors");
                Console.WriteLine("Type 4 if you want to use Moranon Orcs");
                Console.WriteLine("Type 5 if you want to use Moria Goblins");
                Console.WriteLine("Type 6 if you want to use The Witch King");
                Console.WriteLine("Type 7 if you want to use Sauron");
                Console.WriteLine("Type anything else if you want to manualy enter stats");
                preset = int.Parse(Console.ReadLine());

                if (preset == 1)
                {
                    target = new Model("Blackroot Vale Archers", 4);
                }
                else if (preset == 2)
                {
                    target = new Model("Duinhir", 5);
                }
                else if (preset == 3)
                {
                    target = new Model("Wood Elf Warriors", 4);
                }
                else if (preset == 4)
                {
                    target = new Model("Moranon Orcs", 5);
                }

                else if (preset == 5)
                {
                    target = new Model("Moria Goblins", 4);
                }
                else if (preset == 6)
                {
                    target = new Model("The Witch King", 8);
                }
                else if (preset == 7)
                {
                    target = new Model("Sauron", 10);
                }
                else //custom target
                {
                    Console.WriteLine("What is the target's name?");
                    targetName = Console.ReadLine();
                    Console.WriteLine($"What is {targetName}'s Defence?");
                    targetDefence = int.Parse(Console.ReadLine());

                    target = new Model(targetName, targetDefence);

                }                


                if (isHero)
                {
                    probableWounds = hero.Shoot(1, moved, useAcuracy, target, useMight);
                    if (probableWounds <= 0)
                    {
                        Console.WriteLine($"{hero.Name}(s) can not wound {target.Name}(s)");

                    }
                    else
                    {
                        Console.WriteLine($"The probalbe result of {hero.Name}(s) shooting at {target.Name}(s) is {decimal.Round((decimal)probableWounds, 2, MidpointRounding.AwayFromZero)} wounds.");
                    }

                }
                else
                {

                    probableWounds = archer.Shoot(inWay, moved, useAcuracy, target, totalOfWarrior);
                    if (probableWounds <= 0)
                    {
                        Console.WriteLine($"{archer.Name}(s) can not wound {target.Name}(s)");

                    }
                    else
                    {

                        Console.WriteLine($"The probalbe result of {totalOfWarrior} {archer.Name}(s) shooting at {target.Name}(s) is {decimal.Round((decimal)probableWounds, 2, MidpointRounding.AwayFromZero)} wounds.");
                    }

                }


                Console.WriteLine("Do you want to repeat? (y/n)");
                repeat = YNToBool(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine();

            } while (repeat);
            */
        }
                
    }
}