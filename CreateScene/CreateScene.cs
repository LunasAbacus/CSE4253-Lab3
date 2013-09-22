using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jacobs.SceneGraphCore;
using Jacobs.ISceneGraph;

namespace CreateScene
{
    class CreateScene
    {
        static void Main(string[] args)
        {
            ISceneGraphFactory factory = new SceneFactory();

            ISceneNode root = factory.CreateGroupNode("root", "group", null);

            // Loop through user input until exit encountered
            Console.WriteLine("This program will assist in creating a scenegraph.");
            string input = "";

            do
            {
                Console.Write("Would you like to Add or Exit: ");
                input = Console.ReadLine();
            } while (input != "exit");
        }
    }
}
