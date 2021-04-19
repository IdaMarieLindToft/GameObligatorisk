using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Interface;

namespace _2DSimpleGame.Objects
{
    public class DefaultStategy : IStategyDam
    {
        public int DamagePoints(ICharacter ch)
        {
            return ch.DamagePoint;
        }
    }
}
