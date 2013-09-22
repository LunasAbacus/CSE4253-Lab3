﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jacobs.SceneGraphCore
{
    [Serializable()]
    internal class Cube : DrawableNodeBase
    {
        public Cube(string name)
            : base(name)
        {
        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing a cube...");
        }
    }
}
