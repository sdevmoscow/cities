using ImportExample.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace ImportExample
{
    public class CityParser
    {
        private string _filePath;

        public CityParser(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Reads json file and parse it data
        /// </summary>
        public void Parse()
        {
            CityStore cityStore = new CityStore();

            ICityReader cityReader = CityReader.GetReader(_filePath);

            foreach (var cityItem in cityReader.Read())
            {
                cityStore.Save(cityItem);
            }
        }


    }
}
