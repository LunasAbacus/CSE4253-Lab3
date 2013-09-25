using System;
using Jacobs.ISceneGraph;

namespace Jacobs.CreateScene
{
    class SearchVisitor : IVisitor
    {
        static public ISceneNode Find(string targetName, ISceneNode root)
        {
            SearchVisitor visitor = new SearchVisitor(targetName);

            visitor.PreBranchVisit(root);

            return visitor.getResult();
        }

        private readonly string targetString;
        private bool notFound;
        private ISceneNode result;

        private void PreBranchVisit(ISceneNode node)
        {
            if (node is IGroupNode)
            {
                PreVisit((IGroupNode)node);
            }
            else if (node is IDrawableNode)
            {
                PreVisit((IDrawableNode) node);
            }
            else if (node is IStateNode)
            {
                PreVisit((IStateNode) node);
            }
            else if (node is ITransformNode)
            {
                PreVisit((ITransformNode) node);
            }
        }

        private SearchVisitor(string targetName)
        {
            this.targetString = targetName;
            this.notFound = true;
        }

        public ISceneNode getResult()
        {
            return result;
        }

        private void CompareToTarget(ISceneNode node)
        {
            if (notFound && targetString == node.Name)
            {
                notFound = false;
                this.result = node;
            }
        }

        
        public void PreVisit(IDrawableNode node)
        {
            CompareToTarget(node);
        }

        public void PreVisit(IGroupNode node)
        {
            CompareToTarget(node);

            foreach (ISceneNode child in node)
            {
                PreBranchVisit(child);
            }
        }

        public void PreVisit(ITransformNode node)
        {
            CompareToTarget(node);
        }

        public void PreVisit(IStateNode node)
        {
            CompareToTarget(node);
        }

        public void PostVisit(IDrawableNode node)
        {

        }

        public void PostVisit(IGroupNode node)
        {

        }

        public void PostVisit(ITransformNode node)
        {

        }

        public void PostVisit(IStateNode node)
        {

        }
    }
}
