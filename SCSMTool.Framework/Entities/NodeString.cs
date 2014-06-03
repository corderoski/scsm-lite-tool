using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SCSMTool.Framework.Entities
{

    public class NodeString
    {

        public NodeString()
        {
            Childs = new Collection<NodeString>();
        }

        public String Name { get; set; }

        public String Text { get; set; }

        public ICollection<NodeString> Childs { get; set; }
    }

}
