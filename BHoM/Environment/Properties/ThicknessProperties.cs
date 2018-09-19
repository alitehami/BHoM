﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BH.oM.Base;
using BH.oM.Environment.Elements;

namespace BH.oM.Environment.Properties
{
    public class ThicknessProperties : BHoMObject
    {
        public double Thickness { get; set; } = 0.0;
        public UnitType Unit { get; set; } = UnitType.Meter;
    }
}
