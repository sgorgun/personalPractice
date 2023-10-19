using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfacesLessonMyConsoleApp
{
    public class RocketHeader
    {
        public int Cosmonauts { get; private set; }
        public int WeightShell { get; private set; }

        public RocketHeader()
        {
            Cosmonauts = 8;
            WeightShell = 3000;
        }

        public int GetWeight()
        {
            return Cosmonauts * 90 + WeightShell;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Message:");
            Console.WriteLine(message);
            Console.WriteLine("was sent");
        }
    }
}