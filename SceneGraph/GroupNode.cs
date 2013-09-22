using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    [Serializable()]
    internal class GroupNode : IGroupNode
    {
        public string Name
        {
            get;
            private set;
        }

        #region Member variables
        private IList<ISceneNode> children = new List<ISceneNode>(8);
        #endregion

        public GroupNode(string name)
        {
            this.Name = name;
        }

        public void AddChild(ISceneNode child)
        {
            children.Add(child);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            foreach (ISceneNode child in children)
            {
                child.Accept(visitor);
            }
            visitor.PostVisit(this);
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return children.GetEnumerator();
        }

        public IEnumerator<ISceneNode> GetEnumerator()
        {
            return children.GetEnumerator();
        }
        
    }
}
