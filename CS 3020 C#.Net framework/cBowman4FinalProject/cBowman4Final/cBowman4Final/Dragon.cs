using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class creates a dragon character with its stats, attack, defend, and special 
    /// </summary>
    class Dragon : Entity
    {
        /// <summary>
        /// constructor to get the info for the bandit
        /// </summary>
        public Dragon()
        {
            this.Name = "Dragon";
            this.Speed = 35;
            this.Strength = 75;
            this.Smortness = 75;
            this.PDefense = 80;
            this.MDefense = 80;
            this.HitPoints = 120;
            this.InitialHealth = 120;
            this.IsPlayer = false;
        }
    }
}

