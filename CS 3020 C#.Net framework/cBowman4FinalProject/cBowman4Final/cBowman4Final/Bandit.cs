using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class creates a bandit character with its stats, attack, defend, and special 
    /// </summary>
    class Bandit : Entity
    {
        /// <summary>
        /// constructor to get the info for the bandit
        /// </summary>
        public Bandit()
        {
            this.Name = "Bandit";
            this.Speed = 30;
            this.Strength = 30;
            this.PDefense = 25;
            this.MDefense = 25;
            this.HitPoints = 70;
            this.InitialHealth = 70;
            this.IsPlayer = false;
        }
    }
}
