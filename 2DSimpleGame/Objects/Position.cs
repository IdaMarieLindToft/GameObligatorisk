using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DSimpleGame.Objects
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        //L (SOLID)
        public Position(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentOutOfRangeException($" X og Y skal være over 0. X: {x} Y:{y}");
            }
            else
            {
              X = x;
              Y = y;   
            }
           
        }
    }
}
