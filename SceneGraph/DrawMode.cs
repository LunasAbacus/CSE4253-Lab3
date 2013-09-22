using System;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    [Serializable()]
    internal class DrawMode : IStateNode
    {
        public DrawMode(string name)
        {
            this.Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            visitor.PostVisit(this);
        }

        public string Name
        {
            get;
            protected set;
        }

        public void Apply()
        {
            Console.WriteLine("Applying drawmode...");
        }

        public void UnApply()
        {
            Console.WriteLine("Unapplying drawmode...");
        }
    }
}
