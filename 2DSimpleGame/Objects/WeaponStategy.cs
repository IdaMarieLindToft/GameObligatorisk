using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Interface;

namespace _2DSimpleGame.Objects
{
    public class WeaponStategy : IStategyDam
    {
        public int DamagePoints(ICharacter ch)
        {
            return ch.DamagePoint + ch.Weap.Damage;
        }
    }
}
