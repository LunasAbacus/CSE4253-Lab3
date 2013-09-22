using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    [Serializable()]
    internal abstract class DrawableNodeBase : IDrawableNode
    {
        protected DrawableNodeBase(string name)
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

        public abstract void Draw();
    }
}
