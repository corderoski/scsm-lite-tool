using System;
using System.Text;
using FileHelpers;

namespace SCSMTool.Framework.Entities
{

    [DelimitedRecord("|")]
    public class DataItem
    {
    
        public String Direccion;

        public String Area;

        public String Category;

        public String Name;

        public String Description;

        public String ID;

        public override string ToString()
        {
            var str = new StringBuilder();

            foreach (var field in typeof(DataItem).GetFields())
            {
                var value = this.GetType().GetField(field.Name).GetValue(this);
                str.Append(value + "    ");
            }

            return str.ToString();
        }
    
    }

}
