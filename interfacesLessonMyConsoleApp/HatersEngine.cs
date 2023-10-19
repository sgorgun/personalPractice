using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfacesLessonMyConsoleApp
{
    public class HatersEngine : IEngine
    {
        public int Power { get; }

        public int Weight { get; }
        public string GetCopyrighters { get; }

        public HatersEngine()
        {
            Weight = 3000;
            Power = 20000;
            GetCopyrighters = "Xcrime Inc.";
        }

        public void Start()
        {
            Console.WriteLine("Heads on fire, thrust to maximum!");
        }

        public void Stop()
        {
            Console.WriteLine("Throw in some good content. The Heads are getting cold.");
        }
    }
}