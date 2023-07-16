using MESBG_Probabilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESBGProbabilities
{
    public partial class Shooting : Form
    {
        //objects
        private Warrior archer;
        private Hero hero;
        private Model target;
        
        //Variables
        private bool isHero;
        private bool useAcc = false;
        private bool movedVal = false;
        private bool mightVal = false;     
        private int inWayResult;
        private double probableWounds;
        
        public Shooting()
        {
            InitializeComponent();
        }

        private void shoot_Click(object sender, EventArgs e)
        {
            if (manualArcher.Checked)
            {
                if (isHero)
                {
                    hero = new Hero(name.Text, (int)shootValue.Value, (int)bowStrength.Value, allToHit.Checked, onesToHit.Checked, allToWound.Checked, onesToWound.Checked);
                }
                else 
                {
                    archer = new Warrior(name.Text, (int)shootValue.Value, (int)bowStrength.Value, allToHit.Checked, onesToHit.Checked, allToWound.Checked, onesToWound.Checked);

                }

            }
            
            if (manualTarget.Checked)
            {
                target = new Model(targetName.Text, (int)targetDefence.Value);
            }

            result.Visible = true;
            if (isHero)
            {
                probableWounds = hero.Shoot(inWayResult, movedVal, useAcc, target, mightVal);
                // can't wound output
                if (probableWounds <= 0)
                {
                    result.Text = $"{hero.Name}(s) can not wound {target.Name}(s)";

                }
                //normal output
                else
                {
                    result.Text = $"The probalbe result of {hero.Name}(s) shooting at {target.Name}(s) is {decimal.Round((decimal)probableWounds, 2, MidpointRounding.AwayFromZero)} wounds.";
                }

            }
            //warrior output
            else 
            {

                probableWounds = archer.Shoot(inWayResult, movedVal, useAcc, target, (int)numOfModel.Value);
                // can't wound output
                if (probableWounds <= 0)
                {
                    result.Text = $"{archer.Name}(s) can not wound {target.Name}(s)";

                }
                //normal output
                else
                {

                    result.Text = $"The probalbe result of {(int)numOfModel.Value} {archer.Name}(s) shooting at {target.Name}(s) is {decimal.Round((decimal)probableWounds, 2, MidpointRounding.AwayFromZero)} wounds.";
                }

            }
        }



        //create and populate Blackroot Vale Archer as shooter
        private void BRV_CheckedChanged(object sender, EventArgs e)
        {
            archer = new Warrior("Blackroot Vale Archer", 3, 2, false, true, true, false);
            isHero = false;
            ManualArcherBox.Visible = false;
            reRollChoiceBox.Visible = false;

            useMightBox.Visible = false;
            numOfModel.Visible = true;
            numOfModelLabel.Visible = true;


        }

        //create and populate Duinhir as shooter
        private void Dun_CheckedChanged(object sender, EventArgs e)
        {
            hero = new Hero("Duinhir", 3, 2, false, true, true, false);
            isHero = true;
            ManualArcherBox.Visible = false;
            reRollChoiceBox.Visible = false;

            useMightBox.Visible = true;
            numOfModel.Visible = false;
            numOfModelLabel.Visible = false;

        }

        //create and populate Wood Elf Warrior as shooter

        private void WEW_CheckedChanged(object sender, EventArgs e)
        {
            archer = new Warrior("Wood Elf Warriors", 3, 3, false, false, false, false);
            isHero = false;
            ManualArcherBox.Visible = false;
            reRollChoiceBox.Visible = false;



            useMightBox.Visible = false;
            numOfModel.Visible = true;
            numOfModelLabel.Visible = true;


        }

        // manyally create and populate shooter
        private void Manual_CheckedChanged(object sender, EventArgs e)
        {
            ManualArcherBox.Visible = true;

            if (chooseHero.Checked == true)
            {
                useMightBox.Visible = true;
                numOfModel.Visible = false;
                numOfModelLabel.Visible = false;

            }
            else
            {
                useMightBox.Visible = false;
                numOfModel.Visible = true;
                numOfModelLabel.Visible = true;
            }

        }


        // make reroll box vissible
        private void reRolls_CheckedChanged(object sender, EventArgs e)
        {
            reRollChoiceBox.Visible = true;
        }

        //make reroll box invisible
        private void norerolls_CheckedChanged(object sender, EventArgs e)
        {
            reRollChoiceBox.Visible = false;
        }

        //make one the hit match all to hit and dissable if all reroll
        private void reRollAllToHit_CheckedChanged(object sender, EventArgs e)
        {
            onesToHit.Checked = allToHit.Checked;
            if (allToHit.Checked)
            {
                onesToHit.Enabled = false;
            }
            else
            {
                onesToHit.Enabled = true;
            }

        }

        //make one the wound match all to hit and dissable if all reroll
        private void allToWound_CheckedChanged(object sender, EventArgs e)
        {
            onesToWound.Checked = allToWound.Checked;
            if (allToWound.Checked)
            {
                onesToWound.Enabled = false;
            }
            else
            {
                onesToWound.Enabled = true;
            }
        }

        //create and populate Blackroot Vale Archers as target
        private void BRVTarget_CheckedChanged(object sender, EventArgs e)
        {
            target = new Model("Blackroot Vale Archers", 4);
            manualTargetBox.Visible = false;

        }

        //create and populate Moranon Orcs as target
        private void OrcTarget_CheckedChanged(object sender, EventArgs e)
        {
            target = new Model("Moranon Orcs", 5);
            manualTargetBox.Visible = false;

        }

        //manually create and populate target
        private void manualTarget_CheckedChanged(object sender, EventArgs e)
        {
            manualTargetBox.Visible = true;
        }

        //create and populate Duinhir as target
        private void DuinhirTarget_CheckedChanged(object sender, EventArgs e)
        {
            target = new Model("Duinhir", 5);

            manualTargetBox.Visible = false;

        }

        //create and populate Wood Elf Warriors as target
        private void WoodElfTarget_CheckedChanged(object sender, EventArgs e)
        {
            target = new Model("Wood Elf Warriors", 4);

            manualTargetBox.Visible = false;

        }

        //create and populate Moria Goblins as target
        private void Goblin_CheckedChanged(object sender, EventArgs e)
        {
            target = new Model("Moria Goblins", 4);
            manualTargetBox.Visible = false;

        }

        //create and populate Witch King as target
        private void WitchKing_CheckedChanged(object sender, EventArgs e)
        {
            target = new Model("The Witch King", 8);
            manualTargetBox.Visible = false;

        }

        //create and populate Sauron as target
        private void Sauron_CheckedChanged(object sender, EventArgs e)
        {
            target = new Model("Sauron", 10);
            manualTargetBox.Visible = false;

        }

        //make no inway and remove accuracy choice
        private void noInWay_CheckedChanged(object sender, EventArgs e)
        {
            noAccuracy.Checked = false;
            accuracyBox.Visible = false;
            inWayResult = 1;
        }

        //make 3+ inway and make accuracy choice
        private void inWay3_CheckedChanged(object sender, EventArgs e)
        {
            accuracyBox.Visible = true;
            inWayResult = 3;

        }

        //make 4+ inway and make accuracy choice
        private void inWay4_CheckedChanged(object sender, EventArgs e)
        {
            accuracyBox.Visible = true;
            inWayResult = 4;
        }

        //make 5+ inway and make accuracy choice
        private void inWay5_CheckedChanged(object sender, EventArgs e)
        {
            accuracyBox.Visible = true;
            inWayResult = 5;

        }

        private void useAccuracy_CheckedChanged(object sender, EventArgs e)
        {
            useAcc = true;
        }

        private void noAccuracy_CheckedChanged(object sender, EventArgs e)
        {
            useAcc = false;
        }

        //make archer hero and display and hide proper fields
        private void chooseHero_CheckedChanged(object sender, EventArgs e)
        {
            isHero = true;
            useMightBox.Visible = true;
            numOfModel.Visible = false;
            numOfModelLabel.Visible = false;
        }

        //make archer warrior and display and hide proper fields
        private void chooseWarrior_CheckedChanged(object sender, EventArgs e)
        {
            isHero = false;
            useMightBox.Visible = false;
            numOfModel.Visible = true;
            numOfModelLabel.Visible = true;

        }

        private void moved_CheckedChanged(object sender, EventArgs e)
        {
            movedVal = true;
        }

        private void notMoved_CheckedChanged(object sender, EventArgs e)
        {
            movedVal = false;
        }

        private void noMight_CheckedChanged(object sender, EventArgs e)
        {
            mightVal = false;

        }

        private void useMight_CheckedChanged(object sender, EventArgs e)
        {
            mightVal = true;
        }

        private void Shooting_Load(object sender, EventArgs e)
        {
            //Initialize pre selected archer and target
            archer = new Warrior("Blackroot Vale Archer", 3, 2, false, true, true, false);
            isHero = false;

            target = new Model("Moranon Orcs", 5);
        }
    }
}
