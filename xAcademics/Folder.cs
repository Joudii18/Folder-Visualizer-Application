using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAcademics
{
    internal class Folder : FileSystemComponent
    {

        public List<FileSystemComponent> children = new List<FileSystemComponent>();

        public Folder(string name) :
            base(name)
        { }

        public void add(FileSystemComponent compnenet)
        {
            children.Add(compnenet);
        }

        public void remove(FileSystemComponent compnenet)
        {
            children.Remove(compnenet);
        }

        public override int calculateSize()
        {
            int totalSize = 0;

            for (int i = 0; i < children.Count; i++)
            {
                totalSize += children[i].calculateSize();

            }
            return totalSize;
        }
    }
}
