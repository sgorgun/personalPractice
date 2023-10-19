using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfacesLessonMyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rocket rocket = new Rocket();
            rocket.Header = new RocketHeader();

            rocket.Engine = new HatersEngine();
            Console.WriteLine("Heater pull:" + SpecialNasaMethod(rocket.Engine.Power, rocket.Weight));

            Console.ReadKey();
        }


        public static int SpecialNasaMethod(int power, int mass)
        {
            return (mass / power * 10) + 82;
        }
    }
}