using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class creates a warrior character with its stats, attack, defend, and special 
    /// </summary>
    class Warrior : Entity
    {
        /// <summary>
        /// constructor to get the info for the warrior
        /// </summary>
        public Warrior()
        {
            this.Name = "Warrior";
            this.Speed = 45;
            this.Strength = 65;
            this.PDefense = 100;
            this.MDefense = 25;
            this.HitPoints = 110;
            this.InitialHealth = 110;
            this.SkillPoints = 0;
            this.IsPlayer = true;
        }
    }
}
