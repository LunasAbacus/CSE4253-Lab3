

namespace Jacobs.ISceneGraph
{
    public interface IGroupNode : ISceneNode
    {
        void AddChild(ISceneNode child);
    }
}
