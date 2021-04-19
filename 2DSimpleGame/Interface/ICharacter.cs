using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Objects;

namespace _2DSimpleGame.Interface
{
    public interface ICharacter : IWorldObjects
    {
        public int DamagePoint { get; set; }
        public int LifePoint { get; set; }
        public IWorld GameWorld { get; set; }
        public IStategyDam Stategy { get; set; }
        public Weapon Weap { get; set; }

        public bool Alive();
        public void RecieveDamage(int dp);
        public void Move(char ch);
        public void MoveControl(Position startPosition, Position endPosition);

    }
}

