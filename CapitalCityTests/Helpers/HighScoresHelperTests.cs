using CapitalCityProgram.Models;
using CapitalCityTests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CapitalCityTests
{
    [TestClass]
    public class HighScoresHelperTests
    {
        [TestMethod]
        public void TestDeserializeHighScoresFromRawJson()
        {
            // Define a raw JSON string for testing
            string rawJson = @"
            [
                {
                    ""Username"": ""QuantumQuill"",
                    ""Score"": 420,
                    ""Timestamp"": ""2024-10-13T15:00:00Z""
                  },
                  {
                    ""Username"": ""TurboRogue"",
                    ""Score"": 400,
                    ""Timestamp"": ""2024-10-13T15:02:00Z""
                  },
                  {
                    ""Username"": ""LightningFury"",
                    ""Score"": 410,
                    ""Timestamp"": ""2024-10-13T15:01:00Z""
                  }
            ]";

            // Call the method with the raw JSON string
            List<HighScore> highScores = HighScoresHelper.DeserializeHighScores(rawJson);

            // Validate the deserialization 
            Assert.IsNotNull(highScores);
            Assert.AreEqual(3, highScores.Count);
            Assert.IsTrue(highScores[0].Score > highScores[1].Score);
            Assert.IsTrue(highScores[1].Score > highScores[2].Score);
        }
    }
}
