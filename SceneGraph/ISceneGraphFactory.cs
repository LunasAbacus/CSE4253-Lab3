using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    public interface ISceneGraphFactory
    {
        IDrawableNode CreateDrawableNode(string name, string DrawableType, object drawableData);
        IGroupNode CreateGroupNode(string name, string groupType, object groupData);
        IStateNode CreateStateNode(string name, string stateType, object stateData);
        ITransformNode CreateTransformNode(string name, string transformType, object transformData);
    }
}
