using System;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    [Serializable()]
    internal class Translate : TransformableNodeBase
    {
        public Translate(string name)
            : base(name)
        {
        }

        public override void Apply()
        {
            Console.Out.WriteLine("Applying translation tranform...");
        }

        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying translation transform...");
        }
    }
}
