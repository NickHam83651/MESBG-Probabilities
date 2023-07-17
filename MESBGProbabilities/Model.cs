using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MESBG_Probabilities
{
    class Model
    {
        // Define the Model properties
        public string Name { get; set; } = "Model";
        public int ShootValue { get; set; } = 0;
        public int Defence { get; set; } = 0;
        public int BowStrength { get; set; } = 0;
        public bool RerollToHitAll { get; set; } = false;
        public bool RerollToHitOnes { get; set; } = false;
        public bool RerollToWoundAll { get; set; } = false;
        public bool RerollToWoundOnes { get; set; } = false;


        // Constructor for archer
        public Model(string name = "Model",
            int shootvalue = 0,
            int bowStrength = 0,
            bool rerollToHitAll = false,
            bool rerollToHitOnes = false,
            bool rerollToWoundAll = false,
            bool rerollToWoundOnes = false)
        {
            Name = name;
            ShootValue = shootvalue;
            BowStrength = bowStrength;
            RerollToHitAll = rerollToHitAll;
            RerollToHitOnes = rerollToHitOnes;
            RerollToWoundAll = rerollToWoundAll;
            RerollToWoundOnes = rerollToWoundOnes;
        }

        //constructor for target 
        public Model(string name = "Model",
            int defence = 0)
        {
            Name = name;
            Defence = defence;
        }

        public Model()
        {
            
        }

        //Probability to get neededValue factoring in other peramitors
        public double DetermineProb(int neededValue, bool rerollAll, bool rerollOne, int modify)
        {

            double prob;
            //Console.WriteLine(modify);

            if (rerollAll == true)
            {
                prob = ProbOfRoll(neededValue, modify);
                return prob + ((1.0 - prob) * prob);
            }
            else if (rerollOne == true)
            {
                prob = ProbOfRoll(neededValue, modify);
                return prob + ((1.0 / 6.0) * prob);
            }
            else
            {
                return ProbOfRoll(neededValue, modify);
            }
        }

        //Value needed to get value or higher on a D6 dice
        public double ProbOfRoll(int value, int modify)
        {
            //I put -99 in wound chart to show where something can't be wounded
            if(value == -99)
            {
                return -99;
            }
            else if (value - modify <= 0)
            {
                return (7 - value) / 6.0;
            }
            else
            {
                return (7 - (value - modify)) / 6.0;
            }
        }


        //function used to shoot the target
        //note: at this point I could have used one variable for modifyToHit, modifyInWay and modifyToWound
        // I did them seperatly to acomidate future work
        public double Shoot(int inWay, bool move, bool heroicAcuracy, Model target, int modifyToHit, int modifyInWay, int modifyToWound)
        {
            double ProbTotalHits = 0;
            // Determine to Hit Probability
            if (move == true)
            {
                ProbTotalHits = DetermineProb(ShootValue + 1, RerollToHitAll, RerollToHitOnes, modifyToHit);
                //Console.WriteLine(ProbTotalHits);
            }

            if (move == false)
            {
                ProbTotalHits = DetermineProb(ShootValue, RerollToHitAll, RerollToHitOnes, modifyToHit);
                //Console.WriteLine(ProbTotalHits);

            }

            if (ProbTotalHits > 1)
            {
                ProbTotalHits = 1;
            }
            else if(ProbTotalHits < 0)
            {
                ProbTotalHits = 0;
            }


            // Determine In Way Probability
            if (heroicAcuracy == true)
            {
                //heroic acuracy allows reroll of failed in ways
                ProbTotalHits *= ProbOfRoll(inWay, modifyInWay);
                ProbTotalHits += ProbTotalHits * (1.0 - ProbOfRoll(inWay, modifyInWay));
            }
            else
            {
                ProbTotalHits = ProbTotalHits * ProbOfRoll(inWay, modifyInWay);
            }

            if (ProbTotalHits > 1)
            {
                ProbTotalHits = 1;
            }
            else if (ProbTotalHits < 0)
            {
                ProbTotalHits = 0;
            }


            // Determine To Wound Probability
            if (target.Defence - BowStrength >= 5)
            {
                //if the target has a high enough defence then you need to roll a 6 then get some other number depending on values
                ProbTotalHits = ProbTotalHits * DetermineProb(6, RerollToWoundAll, RerollToWoundOnes, modifyToWound);
                ProbTotalHits = ProbTotalHits * DetermineProb(WoundChart[BowStrength, target.Defence], RerollToWoundAll, RerollToWoundOnes, modifyToWound);
            }
            else
            {
                ProbTotalHits = ProbTotalHits * DetermineProb(WoundChart[BowStrength, target.Defence], RerollToWoundAll, RerollToWoundOnes, modifyToWound);
            }

            if (ProbTotalHits > 1)
            {
                ProbTotalHits = 1;
            }
            else if (ProbTotalHits < 0)
            {
                ProbTotalHits = 0;
            }

            return ProbTotalHits;
        }

        //die role needed to wound
        // for -1 see other chart
        public int[,] WoundChart =
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 4, 5, 5, 6, 6, 4, 5, 6, -99, -99},
            {0, 4, 4, 5, 5, 6, 6, 4, 5, 6, -99},
            {0, 3, 4, 4, 5, 5, 6, 6, 4, 5, 6},
            {0, 3, 3, 4, 4, 5, 5, 6, 6, 4, 5},
            {0, 3, 3, 3, 4, 4, 5, 5, 6, 6, 4},
            {0, 3, 3, 3, 3, 4, 4, 5, 5, 6, 6},
            {0, 3, 3, 3, 3, 3, 4, 4, 5, 5, 6},
            {0, 3, 3, 3, 3, 3, 3, 4, 4, 5, 5},
            {0, 3, 3, 3, 3, 3, 3, 3, 4, 4, 5},
            {0, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4},
        };
        
    }
}
