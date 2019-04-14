using ImportExample.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImportExample
{
    public class CityReader
    {
        public static ICityReader GetReader(string filePath)
        {
            string fileExtension = Path.GetExtension(filePath);

            if (fileExtension.Equals(".json", StringComparison.CurrentCultureIgnoreCase))
            {
                return new CityJsonReader(filePath);
            }

            if (fileExtension.Equals(".xlsx", StringComparison.CurrentCultureIgnoreCase))
            {
                return new CityExcelReader(filePath);
            }

            return null;
        }
    }
}
