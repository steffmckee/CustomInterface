﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCircle : Circle
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle.");
        }
    }
}