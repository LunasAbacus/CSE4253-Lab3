using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Jacobs.ISceneGraph;
using Jacobs.SceneGraphCore;

namespace Jacobs.ReadScene
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ISceneNode root = null;

                Stream stream = File.Open(dialog.FileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                using (stream)
                {
                    root = (ISceneNode) formatter.Deserialize(stream);
                }

                if (root != null)
                {
                    NameVisitor visitor = new NameVisitor();
                    root.Accept(visitor);
                }
            }
            Console.ReadKey();
        }
    }
}
