using System.Collections.Generic;
using FileHelpers.DataLink;
using SCSMTool.Framework.Entities;

namespace SCSMTool.Framework
{

    public class ExcelImport
    {

        public static IEnumerable<DataItem> LoadFile(string path, int firstRow, int firstColumn)
        {
            var provider = new ExcelStorage(typeof(DataItem));

            provider.StartRow = firstRow;
            provider.StartColumn = firstColumn;

            provider.FileName = path;

            var res = (DataItem[])provider.ExtractRecords();
            return res;
        }

    }

}
