using Jacobs.ISceneGraph;

namespace Jacobs.ISceneGraph
{
    public interface ITransformNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}
