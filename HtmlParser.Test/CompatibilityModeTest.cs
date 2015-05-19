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
        [Theory]
        [InlineData(@"-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.ibm.com/data/dtd/v11/ibmxhtml1-transitional.dtd""", CompatibilityModeDoctype.Quirks)]
        [InlineData(@"Doctype: ""doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd""""", CompatibilityModeDoctype.LimitedQuirks)]
        [InlineData(@"doctype", CompatibilityModeDoctype.Quirks)]
        [InlineData(@"doctype html public", CompatibilityModeDoctype.Quirks)]
        [InlineData(@"doctype html system", CompatibilityModeDoctype.Quirks)]
        [InlineData(@"Doctype: ""doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd""""", CompatibilityModeDoctype.LimitedQuirks)]
        [InlineData(@"Doctype: ""doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http:www.w3.org/tr/htm14/frameset.dtd""""", CompatibilityModeDoctype.LimitedQuirks)]
        [InlineData(@"Doctype: ""doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd""""", CompatibilityModeDoctype.NoQuirks)]
        [InlineData(@"Doctype: ""doctype html public ""-//softquad//dtd hotmetal pro 4.0::19970916::extensions to html 4.0//en"" ""hmpro4.dtd""""", CompatibilityModeDoctype.NoQuirks)]
        [InlineData(@"Doctype: ""doctype html public ""-//ietf//dtd html//en""""", CompatibilityModeDoctype.Quirks)]
        [InlineData(@"Doctype: ""doctype html public @@-//w3c//dtd html 4.0//en@@""", CompatibilityModeDoctype.Quirks)]

        public void Test_Compatibility_Mode_From_Doctype(string doctype, CompatibilityModeDoctype expected)
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(doctype);
            Assert.Equal(expected, actual);
        }
    }
}
