using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlowControl
{
    internal class CinemaVisitor
    {
        internal string Name { get; set; } // Only used to save a fake "name"
        internal uint Age { get; set; }
        public CinemaVisitor(string name, uint age) {
            Name = name;
            Age = age;
        }


    }
}
