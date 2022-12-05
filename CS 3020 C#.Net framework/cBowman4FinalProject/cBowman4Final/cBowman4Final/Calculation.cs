using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cBowman4Final
{
    /// <summary>
    /// this class is to calucate the damge done to an entity, went with the long form of calculations as strength - defense caused a bug
    /// </summary>
    class Calculation
    {
        /// <summary>
        /// to calculate the damage done to an entity through the strength
        /// </summary>
        public double Damage(double strength)
        {
            // to form the damge done, found formula online
            double damage = (5 + (strength * 1.5 / 5)) * (1 + (strength / 100));

            // to round down if .4 and less and round up for .5 and over
            return Math.Round(damage, MidpointRounding.AwayFromZero);
        }
    }
}
