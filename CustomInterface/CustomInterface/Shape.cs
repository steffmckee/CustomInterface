﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // the abstract base class of the hierarchy.
    abstract class Shape
    {
        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }

        // a single virtual method.
        //public virtual void Draw()
        //{
        //    Console.WriteLine("Inside Shape.Draw()");
        //}

        // force all child classes to define how to be rendered
        public abstract void Draw();
    }
}
