using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    public class SceneFactory : ISceneGraphFactory
    {
        public IDrawableNode CreateDrawableNode(string name, string DrawableType, object drawableData)
        {
            return null;
        }

        public IGroupNode CreateGroupNode(string name, string groupType, object groupData)
        {
            return null;
        }

        public IStateNode CreateStateNode(string name, string stateType, object stateData)
        {
            return null;
        }

        public ITransformNode CreateTransformNode(string name, string transformType, object transformData)
        {
            return null;
        }
    }
}
