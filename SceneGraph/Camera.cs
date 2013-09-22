using System;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    class Camera : TransformableNodeBase
    {
        public Camera(string name)
            : base(name)
        {
        }

        public override void Apply()
        {
            Console.Out.WriteLine("Applying camera tranform...");
        }

        public override void UnApply()
        {
            Console.Out.WriteLine("Unapplying camera transform...");
        }
    }
}
