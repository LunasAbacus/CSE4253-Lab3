using System;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    [Serializable()]
    internal class Scale : TransformableNodeBase
    {
        public Scale(string name)
            : base(name)
        {
        }

        public override void Apply()
        {
            Console.Out.WriteLine("Applying scale tranform...");
        }

        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying scale transform...");
        }
    }
}
