using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2DSimpleGame.Interface;

namespace _2DSimpleGame.Objects
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private TraceSource Ts { get; set; }
        private int TraceId = 1;

        public static Singleton Instance 
        { 
            get{
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
         }
        }



        private Singleton()
        {
            Ts = new TraceSource("Ida's Game");
            Ts.Switch = new SourceSwitch("Ida's Game", "All");
            StreamWriter Sw = new StreamWriter("TraceGame.txt");
            Sw.AutoFlush = true;

            TraceListener Tl = new TextWriterTraceListener(Sw);
            Tl.Filter = new EventTypeFilter(SourceLevels.All);
            Ts.Listeners.Add(Tl);
        }

        public void TraceTrigger(ICharacter ch)
        {
            Ts.TraceEvent(TraceEventType.Information, TraceId++, $"Charachter {ch.Show}, moved to this position {ch.Placement.X} {ch.Placement.Y}");

        }
   
    }


}



