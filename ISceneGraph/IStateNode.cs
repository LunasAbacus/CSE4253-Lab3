using System.Collections.Generic;

namespace Jacobs.ISceneGraph
{
    public interface IStateNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}
