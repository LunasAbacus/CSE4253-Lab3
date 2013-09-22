using System;
using Jacobs.ISceneGraph;

namespace CreateScene
{
    class SearchVisitor : IVisitor
    {
        static public ISceneNode Find(string targetName, ISceneNode root)
        {
            SearchVisitor visitor = new SearchVisitor(targetName);
            

            return visitor.getResult();
        }

        private readonly string targetString;
        private bool notFound;
        private ISceneNode result;

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

        }

        public void PreVisit(IGroupNode node)
        {

        }

        public void PreVisit(ITransformNode node)
        {

        }

        public void PreVisit(IStateNode node)
        {

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
