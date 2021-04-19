using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Interface;
using _2DSimpleGame.Objects;

namespace TestProject
{
    public class Worker
    {
        public void Work()
        {
            World w = new World();

            ICharacter ch = new Character(new Position(5,5),'P',2,10,w);
            ICharacter ch2 = new Character(new Position(15, 15), 'H', 2, 10,w);

            w.AddCharacter(ch);
            w.AddCharacter(ch2);
            
            w.Draw();



            while (ch.Alive() && ch2.Alive())
            {
                Console.WriteLine($"Characther 1 Life: {ch.LifePoint}");
                char typeToKey = Console.ReadKey().KeyChar; //Får fat på hvad brugeren inputter 
                ch.Move(typeToKey);

                Console.WriteLine($"Characther 2 Life: {ch2.LifePoint}");
                char typeToKey2 = Console.ReadKey().KeyChar; //Får fat på hvad brugeren inputter 
                ch2.Move(typeToKey2);

                
            }

            Console.WriteLine($"character {(ch.Alive()?1:2)} won"); //Ternary operator 
        }
    }
}
