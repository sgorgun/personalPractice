using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPartsTwo
{
    class GClass
    {
         public string GtTypeMethod<T>(T parameter)
         {
             return parameter.GetType().ToString();
         }
    }
}
