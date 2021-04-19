using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Interface;
using _2DSimpleGame.Objects;

namespace TestProject
{
    public class World : AbstractWorld
    {
        public override void Draw()
        {
            Console.Clear();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    IWorldObjects o = GetWorldObjects(new Position(j, i));
                    if (o != null)
                    {
                        Console.Write(o.Show);
                    }
                    else
                    {
                        Console.Write(GameGround[i, j]);
                    }
                   

                    

                }
                    Console.Write("\n");
            }
        }
    }
}
