using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapitalCityTests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void TestNormalize_AllAccentedCharactersAreNormalized()
        {
            var input = "á Á à À â Â ä Ä ã Ã å Å æ Æ ç Ç é É è È ê Ê ë Ë í Í ì Ì î Î ï Ï ñ Ñ ó Ó ò Ò ô Ô ö Ö õ Õ ø Ø œ Œ ß ú Ú ù Ù û Û ü Ü";
            var expected = "A A A A A A A A A A A A Æ Æ C C E E E E E E E E I I I I I I I I N N O O O O O O O O O O Ø Ø Œ Œ SS U U U U U U U U";

            Assert.AreEqual(expected, StringHelper.Normalize(input, true));
        }

        [TestMethod]
        public void TestNormalize_LeadingAndTrailingSpacesRemoved()
        {
            Assert.AreEqual("LEADING SPACES REMOVED", StringHelper.Normalize(" LEADING SPACES REMOVED "), true);
        }
    }
}