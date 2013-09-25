using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Jacobs.SceneGraphCore;
using Jacobs.ISceneGraph;

namespace Jacobs.CreateScene
{
    class CreateScene
    {
        static string[] legalTypes = {"building", "camera", "cube", "drawmode",
                                       "group", "perspective", "rotate", "scale",
                                       "sphere", "terrain", "translate"};
        static string[] iDrawables = {"cube", "sphere", "building", "terrain"};
        static string[] iTransformables = {"camera", "rotate", "translate", "scale", "perspective"};

        [STAThread]
        static void Main(string[] args)
        {
            ISceneGraphFactory factory = new SceneFactory();
            IVisitor nameVisitor = new NameVisitor();
            ISceneNode root = factory.CreateGroupNode("root", "group", null);

            // Loop through user input until exit encountered
            Console.WriteLine("This program will assist in creating a scenegraph.");
            string input = "";

            do
            {
                Console.Write("\nWould you like to Add, View or Exit: ");
                input = Console.ReadLine().ToLower();

                if (input == "add")
                {
                    // Get user input
                    Console.Write("Please enter parent node: ");
                    string parent = Console.ReadLine().ToLower();
                    ISceneNode parentNode = SearchVisitor.Find(parent, root);

                    Console.Write("Please enter node type:   ");
                    string type = Console.ReadLine().ToLower();

                    Console.Write("Please enter node name:   ");
                    string name = Console.ReadLine();

                    // Check user input
                    if (parentNode == null || !(parentNode is IGroupNode))
                    {
                        Console.WriteLine("Could not find not group node with name: " + parent);
                    }
                    else if (!legalTypes.Contains(type))
                    {
                        Console.WriteLine("Type: " + type + "is not a legal type");
                    }
                    else // valid parent and type
                    {
                        // Actually add the node
                        ISceneNode newNode = null;

                        if (iDrawables.Contains(type))
                        {
                            newNode = factory.CreateDrawableNode(name, type, null);
                        }
                        else if (iTransformables.Contains(type))
                        {
                            newNode = factory.CreateTransformNode(name, type, null);
                        }
                        else if ("group" == type)
                        {
                            newNode = factory.CreateGroupNode(name, type, null);
                        }
                        else if ("drawmode" == type)
                        {
                            newNode = factory.CreateStateNode(name, type, null);
                        }

                        ((IGroupNode)parentNode).AddChild(newNode);
                    }
                }
                //{
                //    // Take input
                //    Console.Write("Please enter parent node: ");
                //    string parent = Console.ReadLine().ToLower();

                //    // Check that parent can be found
                //    ISceneNode parentNode = SearchVisitor.Find(parent, root);
                //    if (parentNode != null && parentNode is IGroupNode)
                //    {
                //        // Ask for name and type
                //        Console.Write("Please enter node type:   ");
                //        string type = Console.ReadLine().ToLower();

                //        if (legalTypes.Contains(type))
                //        {
                //            Console.Write("Please enter node name:   ");
                //            string name = Console.ReadLine();
                //            ((IGroupNode)parentNode).AddChild(factory.)
                //        }
                //        else
                //        {

                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("Could not find parent.");
                //    }

                //}
                else if (input == "view")
                {
                    // view a debug version of scenegraph
                    Console.WriteLine();
                    root.Accept(nameVisitor);
                    Console.WriteLine();
                }
                else if (input != "exit")
                {
                    Console.WriteLine("Invalid response, please try again.");
                }
            } while (input != "exit");

            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Stream stream = File.Open(dialog.FileName, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                using (stream)
                {
                    formatter.Serialize(stream, root);
                }
            }
            else
            {
                Console.WriteLine("You break my heart. Exiting now, I guess.");
            }
        }
    }
}
