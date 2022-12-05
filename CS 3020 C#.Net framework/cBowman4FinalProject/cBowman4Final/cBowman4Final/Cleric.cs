using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class creates a cleric character with its stats, attack, defend, and special 
    /// </summary>
    class Cleric : Entity
    {
        /// <summary>
        /// constructor to get the info for the cleric
        /// </summary>
        public Cleric()
        {
            this.Name = "Cleric";
            this.Speed = 50;
            this.Strength = 20;
            this.PDefense = 50;
            this.MDefense = 50;
            this.HitPoints = 75;
            this.InitialHealth = 75;
            this.SkillPoints = 0; 
            this.IsPlayer = true;
        }
    }
}
