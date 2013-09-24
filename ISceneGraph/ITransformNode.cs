using Jacobs.ISceneGraph;
using System.Collections.Generic;

namespace Jacobs.ISceneGraph
{
    public interface ITransformNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}
