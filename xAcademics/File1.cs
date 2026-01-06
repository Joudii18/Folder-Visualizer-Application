using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAcademics
{
    internal class File1 : FileSystemComponent{  // this is how we extends columns in C#

        private int size;
        private String extension;

        public File1(string name, int size, string extension)
              : base(name)
        {
            this.size = size;
            this.extension = extension;
        }

        public override int calculateSize()
        {
            return size / 1024; // convert to bytes
        }
    }
}
