using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HtmlParser.Test
{
    public class CompatibilityModeTest
    {
        #region Quirks

        [Fact]
        public void Test_Compatibility_Mode_Quirks_From_Doctype()
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(
                    @"Doctype: ""doctype html public ""-//w3c//dtd html 4.01 transitional//en""""");
            Assert.Equal("Quirks", actual);
        }

        [Fact]
        public void Test_Compatibility_Mode_Quirks_From_Specific_Doctype()
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(
                    @"Doctype: ""doctype html public '-//ietf//dtd html//en'""");
            Assert.Equal("Quirks", actual);
        }

        #endregion

        #region Limited Quirks

        [Fact]
        public void Test_Compatibility_Mode_Limited_Quirks_From_Doctype()
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(
                    @"Doctype: ""doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd""""");
            Assert.Equal("Limited Quirks", actual);
        }

        [Fact]
        public void Test_Compatibility_Mode_Limited_Quirks_From_Specific_Doctype()
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(
                    @"Doctype: ""doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http:www.w3.org/tr/htm14/frameset.dtd""""");
            Assert.Equal("Limited Quirks", actual);
        }

        #endregion

        #region No_Quirks

        [Fact]
        public void Test_Compatibility_Mode_No_Quirks_From_Doctype()
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(
                    @"Doctype: ""doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd""""");
            Assert.Equal("No Quirks", actual);
        }


        [Fact]
        public void Test_Compatibility_Mode_No_Quirks_From_Specific_Doctype()
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(
                    @"Doctype: ""doctype html public ""-//softquad//dtd hotmetal pro 4.0::19970916::extensions to html 4.0//en"" ""hmpro4.dtd""""");
            Assert.Equal("No Quirks", actual);
        }

        #endregion
    }
}
