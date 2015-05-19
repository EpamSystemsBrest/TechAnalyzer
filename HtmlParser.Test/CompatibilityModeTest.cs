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
        [InlineData(@"Doctype: ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.ibm.com/data/dtd/v11/ibmxhtml1-transitional.dtd""""""", "Quirks")]
        [InlineData(@"Doctype: ""doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd""""", "Limited Quirks")]
        [InlineData(@"Doctype: ""doctype""", "Quirks")]
        [InlineData(@"Doctype: ""doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd""""", "Limited Quirks")]
        [InlineData(@"Doctype: ""doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http:www.w3.org/tr/htm14/frameset.dtd""""", "Limited Quirks")]
        [InlineData( @"Doctype: ""doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd""""", "No Quirks")]
        [InlineData( @"Doctype: ""doctype html public ""-//softquad//dtd hotmetal pro 4.0::19970916::extensions to html 4.0//en"" ""hmpro4.dtd""""", "No Quirks")]
        [InlineData(@"Doctype: ""doctype html public ""-//ietf//dtd html//en""""", "Quirks")]
      
        public void Test_Compatibility_Mode_From_Doctype(string doctype, string expected)
        {
            var actual =
                CompatibilityMode.GetCompatibilityModeFromDoctype(doctype);
            Assert.Equal(expected, actual);
        }
    }
}
