using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Interface;

namespace _2DSimpleGame.Objects
{
    public class Character : ICharacter
    {
        public Position Placement { get; set; }
        public char Show { get; set; }
        public int DamagePoint { get; set; }
        public int LifePoint { get; set; }
        public IWorld GameWorld { get; set; }
        public IStategyDam Stategy { get; set; }
        public Weapon Weap { get; set; }
        public Singleton SingleTrace { get; set; }

        public Character(Position placement, char show, int damagePoint, int lifePoint, IWorld gameWorld)
        {
            Placement = placement;
            Show = show;
            DamagePoint = damagePoint;
            LifePoint = lifePoint;
            GameWorld = gameWorld;
            Stategy = new DefaultStategy();
            SingleTrace = Singleton.Instance;
        }

        public bool Alive()
        {
            return (LifePoint > 0);
        }

        
        public void RecieveDamage(int dp)
        {
            LifePoint -= dp;
        }

        public void Move(char ch)
        {
            switch (ch)
            {
                case 'w': 
                    MoveControl(Placement, new Position(Placement.X, Placement.Y - 1));
                    break;
                case 'a':
                    MoveControl(Placement, new Position(Placement.X - 1, Placement.Y));
                    break;
                case 's':
                    MoveControl(Placement, new Position(Placement.X, Placement.Y + 1));
                    break;
                case 'd':
                    MoveControl(Placement, new Position(Placement.X + 1, Placement.Y));
                    break;
            }
            SingleTrace.TraceTrigger(this);
            GameWorld.Draw();

        }

        public void MoveControl(Position startPosition, Position endPosition)
        {
            IWorldObjects worldObjects = GameWorld.GetWorldObjects(endPosition);

            if (worldObjects == null && GameWorld.GameGround[endPosition.Y,endPosition.X] != 'K') // spillerne kan ikke komme ud af banen og de kan rykke ind hvis feltet er tomt 
            {
                Placement = endPosition;
            }
            else 
            {
                if (worldObjects is ICharacter c)
                {
                    c.RecieveDamage(Stategy.DamagePoints(this));
                    
                }
            
            }
        }


    }
}
