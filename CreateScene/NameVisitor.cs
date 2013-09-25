using System;
using System.Collections.Generic;
using Jacobs.ISceneGraph;

namespace Jacobs.CreateScene
{
    class NameVisitor : IVisitor
    {
        #region Member Variables
        string currentIndentation = "";
        string indentIncrement = "   ";
        #endregion

        public void PreVisit(IDrawableNode drawable)
        {
            System.Console.WriteLine(currentIndentation
                + drawable.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IGroupNode groupie)
        {
            System.Console.WriteLine(currentIndentation
                + groupie.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IStateNode statist)
        {
            System.Console.WriteLine(currentIndentation
                + statist.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(ITransformNode transformer)
        {
            System.Console.WriteLine(currentIndentation
                + transformer.Name);
            currentIndentation += indentIncrement;
        }

        public void PostVisit(IDrawableNode drawable)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(IGroupNode groupie)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(IStateNode statist)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public void PostVisit(ITransformNode transformer)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }
    }
}
