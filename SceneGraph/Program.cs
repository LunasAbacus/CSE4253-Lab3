/**
 * Nathan Jacobs - CSE 4253 
 * Lab2
 * This lab demonstrates a simple scene graph
 * using the visitor pattern.
 **/

using System;
using Jacobs.ISceneGraph;
using Jacobs.SceneGraphCore;

namespace Jacobs.SceneGraphCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two different visitors for sample use
            IVisitor classVisitor = new NameTypeVisitor();
            IVisitor nameVisitor = new NameVisitor();

            ISceneNode root;
            //Test different scene graphs
            Console.WriteLine("Flat Test - class:");
            root = FlatTest();
            root.Accept(classVisitor);
            Console.WriteLine();

            Console.WriteLine("Flat Test - name:");
            root = FlatTest();
            root.Accept(nameVisitor);
            Console.WriteLine();

            Console.WriteLine("Deep Test - name:");
            root = DeepTest();
            root.Accept(nameVisitor);
            Console.WriteLine();

            Console.WriteLine("Normal Test - name:");
            root = NormalTest();
            root.Accept(nameVisitor);
            Console.WriteLine();

            Console.WriteLine("Normal Test - class:");
            root = NormalTest();
            root.Accept(classVisitor);
            Console.WriteLine();

            // Wait on user input
            Console.ReadKey();
        }

        static ISceneNode SimplestTest()
        {
            ISceneNode root = new GroupNode("Root");
            
            ISceneNode node = new Cube("cube");
            (root as GroupNode).AddChild(node);
            node = new Cube("cube2");
            (root as GroupNode).AddChild(node);
            GroupNode snowman = new GroupNode("snowman");
            (root as GroupNode).AddChild(snowman);
            node = new Cube("Bottom");
            snowman.AddChild(node);
            node = new Cube("Middle");
            snowman.AddChild(node);
            node = new Cube("Top");
            snowman.AddChild(node);

            return root;
        }

        static ISceneNode FlatTest()
        {
            ISceneNode root = new GroupNode("Root");
        
            // Create a wide tree having all node types
            GroupNode shapes = new GroupNode("Evil entity");
            shapes.AddChild(new Cube("Evil cube"));
            shapes.AddChild(new Terrain("Evil terrain"));
            shapes.AddChild(new Building("Evil building"));
            shapes.AddChild(new Sphere("Evil sphere"));

            (root as GroupNode).AddChild(shapes);
            (root as GroupNode).AddChild(new Camera("Crooked Camera"));
            (root as GroupNode).AddChild(new Rotate("Sinister Rotator"));
            (root as GroupNode).AddChild(new Translate("Trippy translation"));
            (root as GroupNode).AddChild(new Scale("Splippery scale"));
            (root as GroupNode).AddChild(new Perspective("Peppy perpective"));

            (root as GroupNode).AddChild(new DrawMode("Drippy drawmode"));

            return root;
        }

        static ISceneNode DeepTest()
        {
            ISceneNode root = new GroupNode("Root");
            (root as GroupNode).AddChild(new Sphere("Skull"));

            GroupNode vert1 = new GroupNode("Vertibrae 1");
            vert1.AddChild(new Cube("Vertibrae bone 1"));
            GroupNode vert2 = new GroupNode("Vertibrae 2");
            vert2.AddChild(new Cube("Vertibrae bone 2"));
            GroupNode vert3 = new GroupNode("Vertibrae 3");
            vert3.AddChild(new Cube("Vertibrae bone 3"));
            GroupNode vert4 = new GroupNode("Vertibrae 4");
            vert4.AddChild(new Cube("Vertibrae bone 4"));
            GroupNode vert5 = new GroupNode("Vertibrae 5");
            vert5.AddChild(new Cube("Vertibrae bone 5"));
            GroupNode vert6 = new GroupNode("Vertibrae 6");
            vert6.AddChild(new Cube("Vertibrae bone 6"));
            GroupNode vert7 = new GroupNode("Vertibrae 7");
            vert7.AddChild(new Cube("Vertibrae bone 7"));

            vert1.AddChild(vert2);
            vert2.AddChild(vert3);
            vert3.AddChild(vert4);
            vert4.AddChild(vert5);
            vert5.AddChild(vert6);
            vert6.AddChild(vert7);

            (root as GroupNode).AddChild(vert1);

            return root;
        }

        static ISceneNode NormalTest()
        {
            ISceneNode root = new GroupNode("Root");
            (root as GroupNode).AddChild(new Camera("Eye Camera"));
            (root as GroupNode).AddChild(new Perspective("Perpective"));

            GroupNode person = new GroupNode("Person");
            person.AddChild(new Cube("Body"));
            
            GroupNode head = new GroupNode("Head");
            head.AddChild(new Translate("Move head"));
            head.AddChild(new Sphere("Skull"));

            GroupNode lArm = new GroupNode("L Arm");
            lArm.AddChild(new Translate("Left arm translate"));
            lArm.AddChild(new Scale("Left arm scale"));
            lArm.AddChild(new Cube("Left Arm"));

            GroupNode rArm = new GroupNode("R Arm");
            rArm.AddChild(new Translate("Right arm translate"));
            rArm.AddChild(new Scale("Right arm scale"));
            rArm.AddChild(new Cube("Right Arm"));

            GroupNode lLeg = new GroupNode("L Leg");
            lLeg.AddChild(new Translate("Left leg translate"));
            lLeg.AddChild(new Scale("Left leg scale"));
            lLeg.AddChild(new Cube("Left Leg"));

            GroupNode rLeg = new GroupNode("R Leg");
            rLeg.AddChild(new Translate("Right leg translate"));
            rLeg.AddChild(new Scale("Right leg scale"));
            rLeg.AddChild(new Cube("Right Leg"));

            person.AddChild(head);
            person.AddChild(lArm);
            person.AddChild(rArm);
            person.AddChild(lLeg);
            person.AddChild(rLeg);

            (root as GroupNode).AddChild(person);

            return root;
        }
    }
}
