using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    delegate R MyDelegate<R>(); 
    delegate R MyDelegate<T, R>(T parameter);
}
