using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class creates an ogre character with its stats, attack, defend, and special 
    /// </summary>
    class Ogre : Entity
    {
        /// <summary>
        /// constructor to get the info for the bandit
        /// </summary>
        public Ogre()
        {
            this.Name = "Ogre";
            this.Speed = 25;
            this.Strength = 100;
            this.PDefense = 100;
            this.MDefense = 25;
            this.HitPoints = 80;
            this.InitialHealth = 80;
            this.IsPlayer = false;
        }
    }
}
