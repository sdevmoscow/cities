using ImportExample.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace ImportExample
{
    class CityJsonReader : ICityReader
    {
        private string _path = string.Empty;

        public CityJsonReader(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Reads json file and return array of items
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<CityItem> Read()
        {
            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                List<CityItem> items = JsonConvert.DeserializeObject<List<CityItem>>(json);
                return items;
            }
        }
    }
}
