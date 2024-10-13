using CapitalCityProgram.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CapitalCityTests.Helpers
{
    public class CountriesAndCapitalsReader
    {
        private const string fileName = "countries_and_capitals.json";
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameFiles", fileName);

        public static List<Country> GetCountries()
        {
            try
            {
                // Read the content of the JSON file
                string jsonString = File.ReadAllText(filePath);

                // Reuse the new method to deserialize from a string
                return DeserializeCountries(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading countries from file: {ex.Message}");
                return new List<Country>();
            }
        }

        public static List<Country> DeserializeCountries(string jsonString)
        {
            try
            {
                // Deserialize the JSON content into a list of Country objects
                return JsonConvert.DeserializeObject<List<Country>>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing countries from JSON string: {ex.Message}");
                return new List<Country>(); // Return an empty list in case of an error
            }
        }
    }
}