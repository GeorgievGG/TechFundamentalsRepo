using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main()
        {
            var inputRows = int.Parse(Console.ReadLine());
            var citiesDict = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < inputRows; i++)
            {
                var input = Console.ReadLine().Split(' ');
                AddCityToDict(citiesDict, input[0], input[1], input[2]);
            }
            foreach (var continent in citiesDict)
            {
                Console.WriteLine(continent.Key + ":");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
        private static void AddCityToDict(Dictionary<string, Dictionary<string, List<string>>> citiesDict, string continent, string country, string city)
        {
            if (!citiesDict.ContainsKey(continent))
            {
                citiesDict.Add(continent, new Dictionary<string, List<string>>());
                citiesDict[continent].Add(country, new List<string>());
                citiesDict[continent][country].Add(city);
            }
            else
            {
                if (!citiesDict[continent].ContainsKey(country))
                {
                    citiesDict[continent].Add(country, new List<string>());
                    citiesDict[continent][country].Add(city);
                }
                else
                {
                    citiesDict[continent][country].Add(city);
                }
            }
        }
    }
}
