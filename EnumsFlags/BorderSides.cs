﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsFlags
{
    [Flags]
    enum BorderSides { None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 }
}
