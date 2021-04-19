using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Objects;

namespace _2DSimpleGame.Interface
{
    //Interface = er en "kontrakt" med de ting som skal være i f.eks. world
   public interface IWorld
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public char [,] GameGround { get; set; }
        public List<IWorldObjects> WorldObjects { get; set; }

        public IWorldObjects GetWorldObjects(Position pos);


        public void Draw();

        public void AddCharacter(ICharacter ch);



    }
}
