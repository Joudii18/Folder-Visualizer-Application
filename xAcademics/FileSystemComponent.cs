using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAcademics
{
    internal abstract class FileSystemComponent
    {
        protected String name;

        public Visualizer Strategy { get; set; } // here
        protected FileSystemComponent(String name) {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public void visualize(Graphics g, int x, int y)
        {
            Strategy?.visualize(this, g, x, y); // here
        }

        public abstract int calculateSize();
    }
}
