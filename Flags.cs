﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegionFlags
{
    public enum Flags
    {
        NONE = 0,
        PRIVATE = 1,
        PVP = 2,
        DEATH = 4,
        HURT = 8,
        NOITEM = 16,
        NOMOB = 32,
        MOBKILL = 64,
        HEAL = 128, 
        GODMOB = 256
    }
}
