using System;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    class Rotate : TransformableNodeBase
    {
        public Rotate(string name)
            : base(name)
        {
        }

        public override void Apply()
        {
            Console.Out.WriteLine("Applying rotation tranform...");
        }

        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying rotation transform...");
        }
    }
}
