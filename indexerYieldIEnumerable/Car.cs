using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerYieldIEnumerable
{
    internal class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString() // Переопределяем метод
        {
            return Name + " " + Number;
        }
    }
}
