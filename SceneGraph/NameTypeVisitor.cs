using System;
using System.Collections.Generic;
using Jacobs.ISceneGraph;

namespace Jacobs.SceneGraphCore
{
    class NameTypeVisitor : IVisitor
    {
        #region Member Variables
        string currentIndentation = "";
        string indentIncrement = "   ";
        #endregion

        public void PreVisit(IDrawableNode drawable)
        {
            System.Console.WriteLine(currentIndentation
                + "A Drawable of type "
                + drawable.GetType().ToString()
                + " with name: " + drawable.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IGroupNode groupie)
        {
            System.Console.WriteLine(currentIndentation
                + "A Group of type "
                + groupie.GetType().ToString()
                + " with name: " + groupie.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(IStateNode statist)
        {
            System.Console.WriteLine(currentIndentation
                + "A State of type "
                + statist.GetType().ToString()
                + " with name: " + statist.Name);
            currentIndentation += indentIncrement;
        }

        public void PreVisit(ITransformNode transformer)
        {
            System.Console.WriteLine(currentIndentation
                + "A Transform of type "
                + transformer.GetType().ToString()
                + " with name: " + transformer.Name);
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
