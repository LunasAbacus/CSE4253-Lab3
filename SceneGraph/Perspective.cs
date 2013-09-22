using System;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    class Perspective : TransformableNodeBase
    {
        public Perspective(string name)
            : base(name)
        {
        }

        public override void Apply()
        {
            Console.Out.WriteLine("Applying perspective tranform...");
        }

        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying perspective transform...");
        }
    }
}
