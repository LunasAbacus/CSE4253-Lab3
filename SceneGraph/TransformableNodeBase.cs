using System;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    abstract class TransformableNodeBase : ITransformNode
    {
        protected TransformableNodeBase(string name)
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

        public abstract void Apply();
        public abstract void UnApply();
    }
}
