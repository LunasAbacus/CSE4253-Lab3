using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jacobs.ISceneGraph
{
    public interface IGroupNode : ISceneNode, IEnumerable<ISceneNode>
    {
        void AddChild(ISceneNode child);
    }
}

