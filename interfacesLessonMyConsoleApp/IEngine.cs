using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfacesLessonMyConsoleApp
{
    public interface IEngine
    {
        int Power { get; }
        int Weight { get; }
        void Start();
        void Stop();
    }
}