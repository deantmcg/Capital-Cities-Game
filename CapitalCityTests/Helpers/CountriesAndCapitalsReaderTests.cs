using CapitalCityProgram.Models;
using CapitalCityTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CapitalCityTests
{
    [TestClass]
    public class CountriesAndCapitalsReaderTests
    {
        [TestMethod]
        public void TestDeserializeCountriesFromRawJson()
        {
            // Define a raw JSON string for testing
            string rawJson = @"
            [
                {
                    ""Name"": ""France"",
                    ""AcceptedNames"": [ ""French Republic"" ],
                    ""CapitalCity"": {
                        ""Name"": ""Paris"",
                        ""AcceptedNames"": [ ""City of Lights"" ]
                    },
                    ""Difficulty"": ""Easy"",
                    ""Continent"": ""Europe"",
                    ""Population"": 67000000,
                    ""Hints"": [
                        ""This country is famous for the Eiffel Tower."",
                        ""It's known for its cuisine, including baguettes and croissants."",
                        ""The official language is French.""
                    ],
                    ""Languages"": [ ""French"" ],
                    ""NeighbouringCountries"": [ ""Germany"", ""Belgium"", ""Spain"", ""Italy"", ""Switzerland"", ""Luxembourg"" ]
                }
            ]";

            // Call the method with the raw JSON string
            List<Country> countries = CountriesAndCapitalsReader.DeserializeCountries(rawJson);

            // Validate the deserialization (example assertion)
            Assert.IsNotNull(countries);
            Assert.AreEqual(1, countries.Count);
            Assert.AreEqual("France", countries[0].Name);
            Assert.AreEqual("French Republic", countries[0].AcceptedNames[0]);
            Assert.AreEqual("Paris", countries[0].CapitalCity.Name);
            Assert.AreEqual(DifficultyLevel.Easy, countries[0].Difficulty);
            Assert.AreEqual(67000000, countries[0].Population);
            Assert.AreEqual(3, countries[0].Hints.Count());
            Assert.AreEqual(1, countries[0].Languages.Count());
            Assert.AreEqual(6, countries[0].NeighbouringCountries.Count());
        }
    }
}
