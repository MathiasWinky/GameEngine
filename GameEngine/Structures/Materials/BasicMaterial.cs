﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

using SharpDX;
using Color = SharpDX.Color;

namespace GameEngine
{
    public class BasicMaterial : Material
    {
        public Color MainColor 
        {
            get;set;
        }
    }
}
