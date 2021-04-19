using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Interface;

namespace _2DSimpleGame.Objects
{
    public class Weapon : IWorldObjects
    {
        public Position Placement { get; set; }
        public char Show { get; set; }
        public int Damage { get; set; }

        public Weapon(Position placement, char show, int damage)
        {
            Placement = placement;
            Show = show;
            Damage = damage;
        }
    }
}
