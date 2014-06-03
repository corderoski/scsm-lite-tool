using System;
using Newtonsoft.Json;
using SCSMTool.Framework.Entities;

namespace SCSMTool.Framework
{
    public class Serialization
    {

        public static String Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        public static NodeString Deserialize(string value)
        {
            return JsonConvert.DeserializeObject(value, typeof(NodeString)) as NodeString;
        }

    }
}
