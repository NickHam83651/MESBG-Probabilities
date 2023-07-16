using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MESBG_Probabilities
{
     class Hero : Model
    {
        public bool useMight { get; set; } = false;


        // Constructor 
        public Hero(string name = "Model",
        int shootvalue = 0,
        int bowStrength = 0,
        bool rerollToHitAll = false,
        bool rerollToHitOnes = false,
        bool rerollToWoundAll = false,
        bool rerollToWoundOnes = false)
        :base(name, shootvalue, bowStrength, rerollToHitAll, rerollToHitOnes, rerollToWoundAll, rerollToWoundOnes)
        {  
        }

        public double Shoot(int inWay, bool move, bool heroicAcuracy, Model target, bool useMight)
        {

            double ProbTotalHits;
            if (useMight)
            {
                ProbTotalHits = base.Shoot(inWay, move, heroicAcuracy, target, 1, 1, 1);
                return ProbTotalHits;
            }
            else
            {
                ProbTotalHits = base.Shoot(inWay, move, heroicAcuracy, target,0,0,0);
                return ProbTotalHits;
            }
        }

    }
}
