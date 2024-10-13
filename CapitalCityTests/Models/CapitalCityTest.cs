using CapitalCityProgram.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapitalCityTests.Models
{
    [TestClass]
    public class CapitalCityTest
    {
        [TestMethod]
        public void IsAnswerAccepted_CorrectAnswerWithoutAccent_ReturnsTrue()
        {
            CapitalCity city = new CapitalCity
            {
                Name = "Brasília"
            };

            var answer = "Brasilia"; // Without accent

            Assert.IsTrue(city.IsAnswerAccepted(answer));
        }

        [TestMethod]
        public void IsAnswerAccepted_CorrectAnswerWithLeadingAndTrailingSpaces_ReturnsTrue()
        {
            CapitalCity city = new CapitalCity
            {
                Name = "Brasília"
            };

            var answer = " Brasilia "; // Without accent and leading and trailing spaces

            Assert.IsTrue(city.IsAnswerAccepted(answer));
        }

        [TestMethod]
        public void IsAnswerAccepted_AnswerIncludedInOtherAcceptedNames_ReturnsTrue()
        {
            CapitalCity city = new CapitalCity
            {
                Name = "Pretoria",
                AcceptedNames = new string[] { "Tshwane" }
            };

            var answer = "Tshwane";

            city.IsAnswerAccepted(answer);
        }
    }
}