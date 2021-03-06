﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlParser.Test.Infrastructure;
using Xunit;


namespace HtmlParser.Test
{
 
    public class HtmlLexerTest
    {

        #region Tags

        [Fact]
        public void Parsing_Simple_Open_Tag()
        {
            "<a>".ShouldReturn("Tag: <a>");
        }

       [Fact]
        public void Parsing_Self_Closing_Tag()
        {
            "<br />".ShouldReturn("Tag: <br>", "Tag: </br>");
        }

        [Fact]
         public void Parsing_Closed_Tag()
        {
            "</a>".ShouldReturn("Tag: </a>");
        }

        [Fact]
        public void Parsing_Nested_Tags()
        {
            "<p><span></span></p>"
            .ShouldReturn(
               "Tag: <p>",
               "Tag: <span>",
               "Tag: </span>",
               "Tag: </p>"
             );
        }

        #endregion Tags

        #region Comments
        [Fact]
        public void Parsing_Simple_Comment()
        {
            "<!--  Test Comment  -->"
            .ShouldReturn(
                "Comment: <!--  Test Comment  -->"
            );
        }

       [Fact]
        public void Parsing_Conditional_Comment()
        {
            "<!--[if !IE]> IE conditional <![Endif]-->"
            .ShouldReturn(
                 "Comment: <!--[if !IE]> IE conditional <![Endif]-->"
            );
        }

        [Fact]
        public void Parsing_Wrapped_Comment()
        {
            "<p><!-- Wrapped Comment--></p>"
            .ShouldReturn(
                 "Tag: <p>",
                 "Comment: <!-- Wrapped Comment-->",
                 "Tag: </p>"
             );
        }

        [Fact]
        public void Parsing_Comment_With_Tags_Inside()
        {
            "<!-- <p>Commented para</p> -->"
            .ShouldReturn(
                "Comment: <!-- <p>Commented para</p> -->"
            );
        }

        #endregion Comments

        #region Attributes

        [Fact]
        public void Parsing_Attribute_Without_Value()
        {
            "<script async>"
            .ShouldReturn(
                @"*",
                @"Attr: async="""""
            );
        }

        [Fact]
        public void Parsing_Attribute_With_Value()
        {
            @"<a href=""http://name.domain.com"">"
            .ShouldReturn(
                @"*",
                @"Attr: href=""http://name.domain.com"""
            );
        }

        [Fact]
        public void Parsing_Attribute_With_Signgle_Quoted_Value()
        {
            @"<a href='http://name.domain.com'>"
            .ShouldReturn(
                @"*",
                @"Attr: href=""http://name.domain.com"""
             );
        }

        [Fact]
        public void Parsing_Several_Attributes()
        {
            @"<a href=""http://name.domain.com"" title=""Title"">"
            .ShouldReturn(
                @"*",
                @"Attr: href=""http://name.domain.com""", @"Attr: title=""Title"""
            );
        }

        [Fact]
        public void Parsing_Style_Attribute()
        {
            @"<div style=""background-image:url('/images/image.jpg'); height: 28px;width: 425px;"" >"
            .ShouldReturn(
                @"*",
                @"Attr: style=""background-image:url('/images/image.jpg'); height: 28px;width: 425px;"""
            );
        }

        [Fact]
        public void Parsing_Attribute_with_Special_Chars_Inside()
        {
            @"<meta http-equiv=""Content-Type"">"
            .ShouldReturn(
                @"*",
                @"Attr: http-equiv=""Content-Type"""
            );

            // Custom attributes can include underscore
            @"<div display_row=""3"" >"
            .ShouldReturn(
                @"*",
                @"Attr: display_row=""3"""
            );
        }


        #endregion Attributes


        #region Text

        [Fact]
        public void Parsing_Simple_Text()
        {
            "Some Text".ShouldReturn(@"Text: ""Some Text""");
        }

        [Fact]
        public void Parsing_Simple_Text_Inside_Tag()
        {
            "<p>Some Text</p>"
            .ShouldReturn(
                @"*",
                @"Text: ""Some Text""",
                @"*"
            );
        }

        [Fact]
        public void Parsing_WhiteSpaces_Inside_Tag()
        {
            "<p>   \t \n \r   </p>"
            .ShouldReturn(
                "Tag: <p>",
                "Tag: </p>"
             );
        }

        [Fact]
        public void Parsing_Text_Should_Return_Trimmed_Value()
        {
            "<p> \t  Some Text \n  </p>"
            .ShouldReturn(
                @"*",
                @"Text: ""Some Text""",
                @"*"
             );
        }


        [Fact(Skip = "Inconclusive")]
        public void Parsing_Text_Should_Decode_Entities()
        {
            //Assert.Inconclusive("TODO");
            "<p>&lt;&gt;&amp;&nbsp;&quote;</p>"
            .ShouldReturn(
                @"*",
                @"<>& """,
                @"*"
             );
        }

        //[Fact]
     [Fact(Skip = "Inconclusive")]
        public void Parsing_Text_Should_Decode_Hex_Chars()
        {
            //Assert.Inconclusive("TODO");
            "<p>&#x00AE;&#x00A9;</p>"
            .ShouldReturn(
                @"*",
                @"®©""",
                @"*"
             );
        }

        [Fact(Skip = "Inconclusive")]
        public void Parsing_Text_Should_Decode_Decimal_Chars()
        {
            //Assert.Inconclusive("TODO");
            "<p>&#174;&#169;</p>"
            .ShouldReturn(
                @"*",
                @"®©""",
                @"*"
             );
        }

        #endregion Text

        #region Script

        [Fact]
        public void Parsing_Simple_Script()
        {
            "<script> var value = window.document; </script>"
            .ShouldReturn(
                @"Tag: <script>",
                @"Script:  var value = window.document; ",
                @"Tag: </script>"
             );
        }

        [Fact]
        public void Parsing_Script_with_Href()
        {
            @"<script href=""http://domain.com/script.js""></script>"
            .ShouldReturn(
                @"Tag: <script>",
                @"Attr: href=""http://domain.com/script.js""",
                @"Tag: </script>"
             );
        }

        [Fact]
        public void Parsing_Script_with_Tags_Inside()
        {
            @"<script>
                  this.AccessDatas = [{""data"":""<a href=\""/business/?SmRcid=ss_s_st_top_left\"" id=\""hsh_tx_setuzoku106no\"">法人インターネット</a></h3>\r\n""}];
             </script>"
            .ShouldReturn(
                @"Tag: <script>",
                @"Script: 
                  this.AccessDatas = [{""data"":""<a href=\""/business/?SmRcid=ss_s_st_top_left\"" id=\""hsh_tx_setuzoku106no\"">法人インターネット</a></h3>\r\n""}];
             ",
                @"Tag: </script>"
             );
        }

         [Fact]
        public void Parsing_Specific_Script()
        {
            @"<script>
                    alert(""Hello, \"" World"");
             </script>"
            .ShouldReturn(
                @"Tag: <script>",
                @"Script: 
                    alert(""Hello, \"" World"");
             ",
                @"Tag: </script>"
             );
        }

      
        [Fact]
        public void Parsing_Several_Scripts()
        {
            @"<script>
                  this.AccessDatas = [{""data"":""<a href=\""/business/?SmRcid=ss_s_st_top_left\"" id=\""hsh_tx_setuzoku106no\"">法人インターネット</a></h3>\r\n""}];
             </script>
<script> var value = window.document; </script>"
            .ShouldReturn(
                @"Tag: <script>",
                @"Script: 
                  this.AccessDatas = [{""data"":""<a href=\""/business/?SmRcid=ss_s_st_top_left\"" id=\""hsh_tx_setuzoku106no\"">法人インターネット</a></h3>\r\n""}];
             ",
                @"Tag: </script>",
                   @"Tag: <script>",
                @"Script:  var value = window.document; ",
                @"Tag: </script>"
             );

        }

        #endregion Script

        #region Style

        [Fact]
        public void Parsing_Style_with_Tags_Inside()
        {
            @"<style> 
                .sli1 {
                    filter: url(""data:image/svg+xml;utf8,<svg xmlns=\'http://www.w3.org/2000/svg\'><filter id=\'grayscale\'><feColorMatrix type=\'matrix\' values=\'0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0 0 0 1 0\'/></filter></svg>#grayscale"");
                }
              </style>"
             .ShouldReturn(
                @"Tag: <style>",
                @"Style:  
                .sli1 {
                    filter: url(""data:image/svg+xml;utf8,<svg xmlns=\'http://www.w3.org/2000/svg\'><filter id=\'grayscale\'><feColorMatrix type=\'matrix\' values=\'0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0 0 0 1 0\'/></filter></svg>#grayscale"");
                }
              ",
                @"Tag: </style>"
            );
        }

        [Fact]
        public void Parsing_Several__Style()
        {
            @"<style> 
                .sli1 {
                    filter: url(""data:image/svg+xml;utf8,<svg xmlns=\'http://www.w3.org/2000/svg\'><filter id=\'grayscale\'><feColorMatrix type=\'matrix\' values=\'0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0 0 0 1 0\'/></filter></svg>#grayscale"");
                }
div {
    height: 200px;
    width: 200px;
    overflow: auto;
    padding-left: 15px;
    background: url(images/hand.png) repeat-y #fc0; 
   }
              </style>
            <style>
                    div { 
                      height: 200px; 
                    }
            </style>"
                .ShouldReturn(
                    @"Tag: <style>",
                    @"Style:  
                .sli1 {
                    filter: url(""data:image/svg+xml;utf8,<svg xmlns=\'http://www.w3.org/2000/svg\'><filter id=\'grayscale\'><feColorMatrix type=\'matrix\' values=\'0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0.3333 0.3333 0.3333 0 0 0 0 0 1 0\'/></filter></svg>#grayscale"");
                }
div {
    height: 200px;
    width: 200px;
    overflow: auto;
    padding-left: 15px;
    background: url(images/hand.png) repeat-y #fc0; 
   }
              ",
                    @"Tag: </style>",
                    @"Tag: <style>",
                    @"Style: 
                    div { 
                      height: 200px; 
                    }
            ",
             @"Tag: </style>"
                );
        }



        #endregion Style

        #region Doctype
    
        [Fact]
        public void Parsing_Simple_Doctype()
        {
            @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">".ShouldReturn(@"Doctype: ""doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd""""");
        }


        [Fact]
        public void Parsing_Empty_Doctype()
        {
            @"<!doctype>".ShouldReturn(@"Doctype: ""doctype""");
        }

        [Fact]
        public void Parsing_Specific_Doctype()
        {
            @"<!doctype html public>".ShouldReturn(@"Doctype: ""doctype html public""");
        }

        #endregion 

        //        [Fact]
//        public void Parsing_Script_And_Tags()
//        {
//            @"<link rel=""stylesheet"" href=""https://abs.twimg.com/a/1431362606/css/t1/twitter_core.bundle.css"">
//    <link rel=""stylesheet"" href=""https://abs.twimg.com/a/1431362606/css/t1/twitter_logged_out.bundle.css"">
// <meta name=""robots"" content=""NOODP"">
//  <link rel=""alternate"" media=""handheld, only screen and (max-width: 640px)"" href=""https://mobile.twitter.com/"">"

//            .ShouldReturn(
//             "Doctype: \"DOCTYPE html\"",
//               "Tag: <head>",
//               "Tag: <script>",
//               "Attr: id=\"resolve_inline_redirects\"",
//                @"Script: 
//                  this.AccessDatas = [{""data"":""<a href=\""/business/?SmRcid=ss_s_st_top_left\"" id=\""hsh_tx_setuzoku106no\"">法人インターネット</a></h3>\r\n""}];
//             ",
//                @"Tag: </script>"
//             );



//        }

    }
}
