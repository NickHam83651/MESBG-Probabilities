using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESBG_Probabilities
{
    internal class Warrior : Model
    {
        public int TotalOfWarrior { get; set; }

        // Constructor 
        public Warrior(string name = "Model",
        int shootvalue = 0,
        int bowStrength = 0,
        bool rerollToHitAll = false,
        bool rerollToHitOnes = false,
        bool rerollToWoundAll = false,
        bool rerollToWoundOnes = false)
        : base(name, shootvalue, bowStrength, rerollToHitAll, rerollToHitOnes, rerollToWoundAll, rerollToWoundOnes)
        {
        }

        public new double Shoot(int inWay, bool move, bool heroicAcuracy, Model target, int TotalOfWarrior)
        {
            return TotalOfWarrior *  base.Shoot(inWay, move, heroicAcuracy, target,0,0,0);
        }

    }


}
