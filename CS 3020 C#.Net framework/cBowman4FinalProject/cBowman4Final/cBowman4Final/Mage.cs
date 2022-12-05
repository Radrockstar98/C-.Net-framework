using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class creates a mage character with its stats, attack, defend, and special 
    /// </summary>
    class Mage : Entity
    {
        /// <summary>
        /// constructor to get the info for the warrior
        /// </summary>
        public Mage()
        {
            this.Name = "Mage";
            this.Speed = 55;
            this.Smortness = 65;
            this.PDefense = 30;
            this.MDefense = 100;
            this.HitPoints = 80;
            this.InitialHealth = 80;
            this.SkillPoints = 0;
            this.IsPlayer = true;
        }
    }
}
