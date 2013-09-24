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
            IDrawableNode node;

            DrawableType = DrawableType.ToLower();

            switch (DrawableType)
            {
                case "cube":
                    node = new Cube(name);
                    break;
                case "terrain":
                    node = new Terrain(name);
                    break;
                case "sphere":
                    node = new Sphere(name);
                    break;
                case "building":
                    node = new Building(name);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("The type " + DrawableType + " is not a recognized IDrawableNode.");
            }

            return node;
        }

        public IGroupNode CreateGroupNode(string name, string groupType, object groupData)
        {
            IGroupNode node;

            groupType = groupType.ToLower();

            switch (groupType)
            {
                case "group":
                    node = new GroupNode(name);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("The type " + groupType + " is not a recognized IGroupNode.");
            }

            return node;
        }

        public IStateNode CreateStateNode(string name, string stateType, object stateData)
        {
            IStateNode node;

            stateType = stateType.ToLower();

            switch (stateType)
            {
                case "drawmode":
                    node = new DrawMode(name);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("The type " + stateType + " is not a recognized IStateNode.");
            }

            return node;
        }

        public ITransformNode CreateTransformNode(string name, string transformType, object transformData)
        {

            ITransformNode node;

            transformType = transformType.ToLower();

            switch (transformType)
            {
                case "camera":
                    node = new Camera(name);
                    break;
                case "rotate":
                    node = new Rotate(name);
                    break;
                case "translate":
                    node = new Translate(name);
                    break;
                case "scale":
                    node = new Scale(name);
                    break;
                case "perspective":
                    node = new Perspective(name);
                    break;

                default:
                    throw new ArgumentOutOfRangeException("The type " + transformType + " is not a recognized ITransformNode.");
            }

            return node;
        }
    }
}
