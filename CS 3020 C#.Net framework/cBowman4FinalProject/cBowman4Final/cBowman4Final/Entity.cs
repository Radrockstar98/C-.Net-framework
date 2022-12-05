using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class is used to create the stats for the playable characters and the eneimes.
    /// This will also be where the info needed for things like skill points will be set
    /// </summary>
    public class Entity
    {
        Calculation newCalc = new Calculation();

        /// <summary>
        /// the properites for the getters and setters
        /// </summary>
        private int speed, strength, smortness, pDefense, mDefense, skillPoints;
        private double hitPoints, initalHealth;
        private int location;
        private string name;
        private string phase;
        private bool isPlayer = true;


        /// <summary>
        /// to calcuate the final damage delt by an entity, using the calculation class
        /// </summary>
        public double FinalDamage(Entity defense, double strength)
        {
            // to get the total damage an entity does to an oppenent 
            double totalDamage = newCalc.Damage(strength);
            double tDamage;
            if (name == "Mage")
            {
                // to round down if .4 and less and round up for .5 and over
                tDamage = Math.Round(totalDamage * (100 / (100 + (double)defense.MDefense)), MidpointRounding.AwayFromZero);
            }
            else
            {
                // to round down if .4 and less and round up for .5 and over
                tDamage = Math.Round(totalDamage * (100 / (100 + (double)defense.PDefense)), MidpointRounding.AwayFromZero);
            }
            defense.HitPoints -= tDamage;
            return tDamage;
        }

        /// <summary>
        /// to allow the entites to attack
        /// </summary>
        public double Attack(Entity damage)
        {
            if (name == "Mage" || name == "Dragon") // since the mage and dragon uses smortness (magical attack) 
            {
                // does standard damage
                return FinalDamage(damage, this.Smortness);
            }
            else
            {
                // does standard damage
                return FinalDamage(damage, this.Strength);
            }
        }

        /// <summary>
        /// to allow the entites to defend
        /// </summary>
        public void Defend()
        {
            // increase the spped, physical defense, and magical defense by 1
            this.Speed += 2;
            this.PDefense += 2;
            this.MDefense += 2;
        }

        public double Special(Entity damage)
        { 
            // increases damage delt by 1.5
            double special1 = this.Strength * 2;
            double special2 = this.Smortness * 2;

            if (name == "Mage") // since the mage does smortness (magical) damage
            {
                // does standard damage
                return FinalDamage(damage, special2);
            }
            else
            {
                // this will deal the new and higher damage
                return FinalDamage(damage, special1);
            }
        }

        // to get the name of the entity
        public string Name { get => name; set => name = value; }

        // to get the speed of the entity
        public int Speed { get => speed; set => speed = value; }

        // to get the physical strength of the entity
        public int Strength { get => strength; set => strength = value; }

        // to get the magical strength of the entity (aka smortness, player entities and dragon)
        public int Smortness { get => smortness; set => smortness = value; }

        // to get the physical defense of the entity
        public int PDefense { get => pDefense; set => pDefense = value; }

        // to get the mafical defense of the entity
        public int MDefense { get => mDefense; set => mDefense = value; }

        // to get the skill points of the entity (only for player entities)
        public int SkillPoints { get => skillPoints; set => skillPoints = value; }

        // to get the hitpoints (health) of an etity
        public double HitPoints { get => hitPoints; set => hitPoints = value; }

        // to get the initial health of an entity 
        public double InitialHealth { get => initalHealth; set => initalHealth = value; }

        // to see if the entity is a player.
        public bool IsPlayer { get => isPlayer; set => isPlayer = value; }

        // to get the current phase (for players only)
        public string Phase { get => phase; set => phase = value; }

        // to get the entity location 
        public int Location { get => location; set => location = value; }
    }
}
