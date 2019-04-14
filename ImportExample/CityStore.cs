using ImportExample.Interface;
using ImportExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImportExample
{
    public class CityStore : ICityStore
    {
        /// <summary>
        /// Saves a record to database
        /// </summary>
        /// <param name="item"></param>
        public void Save(CityItem item)
        {
            citiesContext ctx = new citiesContext();

            string[] cities = item.City.Split(" .,".ToArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (string city in cities)
            {
                int cityId = SaveCity(city.Trim(), ctx);

                ctx.Facts.Add(new Facts
                {
                    CityId = cityId,
                    Value = item.Value
                });
            }

            ctx.SaveChanges();
        }

        /// <summary>
        /// Checks if a city exists and saves it otherwise
        /// </summary>
        /// <param name="cityName"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public int SaveCity(string cityName, citiesContext ctx)
        {
            Cities city = ctx.Cities.FirstOrDefault(c => c.Name.Equals(cityName, StringComparison.CurrentCultureIgnoreCase));

            if (city == null)
            {
                city = new Cities
                {
                    Name = cityName
                };
                ctx.Cities.Add(city);
                ctx.SaveChanges();
            }

            return city.Id;
        }

        /// <summary>
        /// Saves 'Fact' portion of record to database
        /// </summary>
        /// <param name="cityName"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public int SaveFact(string cityName, citiesContext ctx)
        {
            Cities city = ctx.Cities.FirstOrDefault(c => c.Name.Equals(cityName, StringComparison.CurrentCultureIgnoreCase));

            if (city == null)
            {
                city = new Cities
                {
                    Name = cityName
                };

                ctx.SaveChanges();
            }

            return city.Id;
        }

    }
}