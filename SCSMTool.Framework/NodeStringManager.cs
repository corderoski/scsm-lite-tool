using System;
using SCSMTool.Framework.Entities;

namespace SCSMTool.Framework
{
    public class NodeStringManager
    {

        public static NodeString GetNodeString(String file)
        {
            //  loads content
            var content = System.IO.File.ReadAllText(file);
            //  returns the entity
            return Serialization.Deserialize(content);
        }

        public static NodeString GetNodeStringContent(String file)
        {
            //  loads content
            var content = System.IO.File.ReadAllText(file);
            //  returns the entity
            return Serialization.Deserialize(content);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">an element to match</param>
        /// <param name="name">the name to match</param>
        /// <returns>The matched element, otherwise, null.</returns>
        public static NodeString GetElement(NodeString value, String name)
        {
            if (Compare(value, name))
                return value;
            NodeString match = null;
            foreach (var child in value.Childs)
            {
                if (Compare(child, name))
                {
                    match = child;
                    break;
                }
                match = GetElement(child, name);
                if (match != null)
                    return match;
            }
            return match;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <returns>true if match, otherwise, false.</returns>
        private static bool Compare(NodeString value, String name)
        {
            return (value.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
