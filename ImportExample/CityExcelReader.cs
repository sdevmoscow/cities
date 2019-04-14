using ImportExample.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ImportExample
{
    public class CityExcelReader : ICityReader
    {
        private string _path = string.Empty;

        public CityExcelReader(string path)
        {
            _path = path;
        }

        public List<CityItem> Read()
        {
            throw new NotImplementedException();
        }
    }
}
