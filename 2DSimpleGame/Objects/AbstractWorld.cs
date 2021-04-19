using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;
using System.Xml;
using _2DSimpleGame.Interface;

namespace _2DSimpleGame.Objects
{
    // Design Pattern: Template
    public abstract class AbstractWorld : IWorld 
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public char[,] GameGround { get; set; }
        public List<IWorldObjects> WorldObjects { get; set; }

        public AbstractWorld()
        {
           ReadConfig();
           GameGround = new char[Height, Width];
           WorldObjects = new List<IWorldObjects>();

           for (int i = 0; i < Height; i++)
           {
               for (int j = 0; j < Width; j++)
               {
                   if (i == 0 || i == Height -1 || j == 0 || j == Height -1)
                   {
                       GameGround[i, j] = 'K';
                   }
                   else
                   {
                       GameGround[i, j] = ' ';
                   }
                
               }
               
           }

        }

        public abstract void Draw();

        public void AddCharacter(ICharacter ch)
        {
            WorldObjects.Add(ch);
        }


        // Lambda expression (LINQ)
        public IWorldObjects GetWorldObjects(Position pos)
        {
            return WorldObjects.Find(o => o.Placement.X == pos.X && o.Placement.Y == pos.Y); 
            
        }


        // Height og Width bliver læst fra den oprettede Tekst config file
        // DESIGN Requirement: The frameWork must be configurable from a config-file
        private static XmlDocument configDocument()
        {
            XmlDocument configDoc = new XmlDocument();

            configDoc.Load("ServerConfiguration.xml");
            return configDoc;
        }

        private void ReadConfig()
        {
            XmlNode xNode = configDocument().DocumentElement.SelectSingleNode("x");
            XmlNode yNode = configDocument().DocumentElement.SelectSingleNode("y");

            string xstr = xNode.InnerText.Trim();
            string ystr = yNode.InnerText.Trim();

            int x = Convert.ToInt32(xstr);
            int y = Convert.ToInt32(ystr);

            Height = x;
            Width = y;

        }

    }
}
