﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HtmlParser.Test
{
    public class CompatibilityModeTest
    {
        [Fact]
        public void Test_CompatibilityMode_NoQuirks()
        {
            var data = new[]
            {
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/html4/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"" ""http://www.w3.org/tr/xhtml11/dtd/xhtml11.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 //en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0//en"" ""http://www.w3.org/tr/rec-html40/strict.dtd"">",
                @"<!doctype html public '-//w3c//dtd xhtml 1.0 strict//en' 'http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd'>",
                @"<!doctype html public ""-//sq//dtd html 2.0 + all extensions//en"" ""hmpro3.dtd"">",
                @"<!doctype html public ""-//ietf//dtd html 4.0//en"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 4.0::19970714::extensions to html 4.0//en"" ""hmpro4.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2 //en"">",
                @"<!doctype html public ""-//ietf//dtd html 3.2 level 3.2//en"">",
                @"<!doctype html public ""-//softquad software//dtd hotmetal pro 5.0::19981217::extensions to html 4.0//en"" ""hmpro5.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 final//en"">",
                @"<!doctype html public ""-//wc3//dtd html 4.0//en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"" >",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 5.0::19980907::extensions to html 4.0//en"" ""hmpro5.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.1 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/2000/rec-xhtml1-20000126/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//wc3//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/rec-html40/loose.dtd"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 5.0::19980626::extensions to html 4.0//en"" ""hmpro5.dtd"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 4.0::19970916::extensions to html 4.0//en"" ""hmpro4.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3o//dtd w3 html 2.0//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 strict//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 strict//en"" ""http://www.w3.org/tr/html4/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.1 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html system ""html.dtd"">",
                @"<!doctype html>",
                @"<!doctype html public ""+//isbn 82-7640-037::www//dtd html//en//2.0"" ""html.dtd"">",
                @"<!doctype html public ""-//w30//dtd w3 html2.0//en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml2/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"" ""xhtml11.dtd"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 5.0::19981022::extensions to html 4.0//en"" ""hmpro5.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 strict//en"">",
                @"<!doctype html public ""-//wc3//dtd html 3.2//en"">",
                @"<!doctype html public ""-//softquad//dtd html 2.0 + extensions for hotmetal light 3.0 19960703//en"" >",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3o/dtd html//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/1999/rec-html401-19991224/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/2002/rec-xhtml1-20020801/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml11.dtd"">",
                @"<!doctype html public ""-//wc3//dtd html 4.01 transitional//en"">",
                @"<!doctype html public ""-//ibm//dtd hpb html//en"">",
                @"<!doctype html public ""-//softquad//dtd html 3.2 + extensions for hotmetal pro 3.0(u) 19961211//en"" ""hmpro3.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3.0//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 draft//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/html40/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/rec-html40/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//de"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""xhtml1-strict.dtd"">",
                @"<!doctype html public""-//w3c//dtd html 4.0//en"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 4.0::19980408::extensions to html 4.0 for miva//en"" ""hmpro4.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3//en"">",
                @"<!doctype html public ""-//w3c//dtd html//en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3c.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//fr"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml basic 1.0//en"" ""http://www.w3.org/tr/xhtml-basic/xhtml-basic10.dtd"">",
                @"<!doctype html public ""-//wapforum//dtd xhtml mobile 1.0//en"" ""http://www.wapforum.org/dtd/xhtml-mobile10.dtd"">",
                @"<!doctype html public ""-//wc3//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/rec-html40/loose.dtd"">",
                @"<!doctype html public '-//w3c//dtd html 4.01//en' 'http://www.w3.org/tr/html4/strict.dtd'>",
                @"<!doctype html public "">",
                @"<!doctype html public ""-//sq//dtd html 2.0 + alle erweiterungen//en"" ""hmpro3.dtd"">",
                @"<!doctype html public ""-//w30//dtd w3 html 3.2//en"">",
                @"<!doctype html public ""-//w3c//dtd html 3.0 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional //en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 strict //en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/html4/dtd/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/html4/transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en"" ""http://www.w3.org/tr/rec-html4/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01//en""http://www.w3.org/tr/html4/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.1 frameset//en"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 nearly transitional//en"" "">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//da"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/2000/rec-xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 strict//nl"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional //en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"" ""http://www.w3.org/tr/2001/rec-xhtml11-20010531/dtd/xhtml11-flat.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.1//en"" ""http://www.w3.org/tr/xhtml11/dtd/xhtml11.dtd"" >",
                @"<!doctype html public ""-//w3c//html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3o//dtd w3 html 3.2//en"">",
                @"<!doctype html public ""-//wc3//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-/w3c/dtd html 4.01 transitional/en"">",
                @"<!doctype html public ""-w3//dtd html 4.0 final//en"">",
                @"<!doctype html public '-//w3c//dtd html 4.0 //en'>",
                @"<!doctype html public '-//w3c//dtd xhtml 1.0 strict//en' 'dtd/xhtml1-strict.dtd'>",
                @"<!doctype html public '-//w3c//dtd xhtml 1.1//en' 'http://www.w3.org/tr/xhtml11/dtd/xhtml11.dtd'>",
                @"<!doctype html public "" -//w3c//dtd html 4.0 transitional//en "">",
                @"<!doctype html public "" -//w3c//dtd html 4.01 frameset//en"" ""http://www.w3.org/tr/html14/frameset.dtd"">",
                @"<!doctype html public "" -//w3c//dtd html 4.01 transitional//en"">",
                @"<!doctype html public ""&#150;//w3c//dtd html 3.2//en"">",
                @"<!doctype html public ""&#150;//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/rec&#150;html40/loose.dtd"">",
                @"<!doctype html public ""+//isbn 82-7640-037::www//dtd html//en//2.0"" ""html.dtd"" >",
                @"<!doctype html public ""- //w3c//dtd html 4.01 transitional//en"">",
                @"<!doctype html public ""- w3c dtd xhtml 1.0 transitional en"" ""http: www.w3.org tr xhtml1 dtd xhtml1-transitional.dtd"" >",
                @"<!doctype html public ""-//att//dtd mozilla html 4.0//en"">",
                @"<!doctype html public ""-//extensions to html 4.0//en"">",
                @"<!doctype html public ""-//i3c//dtd html 4.0 transitional//en"">",
                @"<!doctype html public ""-//idf//dtd html 3.2//fr"">",
                @"<!doctype html public ""-//ieft//dtd html 4.0//en"">",
                @"<!doctype html public ""-//ieft//dtd html//en"">",
                @"<!doctype html public ""-//ieft//dtd html//en//2.0"">",
                @"<!doctype html public ""-//ietf//dtd html 2.1 experimental//en"">",
                @"<!doctype html public ""-//ietf//dtd html 2.1//en"">",
                @"<!doctype html public ""-//ietf//dtd html 2.2//en"">",
                @"<!doctype html public ""-//ietf//dtd html 4.0 draft//en"">",
                @"<!doctype html public ""-//ietf//dtd html 4.0//it"">",
                @"<!doctype html public ""-//ietf//dtd html 4.01 frameset//en"">",
                @"<!doctype html public ""-//ietf/dtd html 3.0//en"">",
                @"<!doctype html public ""-//lidovky//dtd html 4//en"" ""http://g.lidovky.cz/dtd/n3_uni.dtd"">",
                @"<!doctype html public ""-//netscape corp.//dtd html plus tables//en"" ""html-net.dtd"">",
                @"<!doctype html public ""-//netscape//dtd html"">",
                @"<!doctype html public ""-//securshred//dtd xhtml-with target//en"" ""http://www.securshred.com/dtd/xhtml-target.dtd"">",
                @"<!doctype html public ""-//simotime//dtd html 4.0 transitional//en"" ""hmpro6.dtd"">",
                @"<!doctype html public ""-//softquad software//dtd hotmetal pro 5.0::19981130::extensions to html 4.0//en"" ""hmpro5.dtd"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 4.0::19970617::extensions to html 3.2//en"" ""hmpro4.dtd"">",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 6.0::19970916::extensions to html 4.0//de"" ""hmpro4.dtd"">",
                @"<!doctype html public ""-//softquad//dtd html 3.2 + extensions for hotmetal pro 3.0 19961211//en"" ""hmpro3.dtd"">",
                @"<!doctype html public ""-//sq//dtd html 2.0 + all extensions//en"">",
                @"<!doctype html public ""-//tigris//dtd xhtml 1.0 transitional//en"" ""http://style.tigris.org/tigris_transitional.dtd"">",
                @"<!doctype html public ""-//tnet//dtd html 3 extended 960415//en"">",
                @"<!doctype html public ""-//w#c//dtd html 3.2 draft//en"">",
                @"<!doctype html public ""-//w3//dtd html 3.2 final//en"">",
                @"<!doctype html public ""-//w30//dtd w3 html 2.0//en"">",
                @"<!doctype html public ""-//w3c// dtd html 4.0 transitional//en"">",
                @"<!doctype html public ""-//w3c//d td xhtml 1.1//en"" ""http://www.w3.org/tr/xhtml11/dtd/xhtml11.dtd"">",
                @"<!doctype html public ""-//w3c//d xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dd html 4.0 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtc html 3.2//en"">",
                @"<!doctype html public ""-//w3c//dtd 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 1.0 loose//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 1.0 transitional//en"" ""http://www.w3.org/tr/html1/dtd/html1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 2.0 //de"">",
                @"<!doctype html public ""-//w3c//dtd html 3.0 transitional//en""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3.0 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtd html 3.01 transitional//en"">",
        
            };

            foreach (var doctype in data) {
                var actual = CompatibilityMode.GetCompatibilityModeFromDoctype(doctype.Trim(new[] { '<', '>', '!' }));
                Assert.Equal(CompatibilityModeDoctype.NoQuirks, actual);
            }
        }


        [Fact]
        public void Test_CompatibilityMode_LimitedQuirks()
        {
            var data = new[]
            {
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http://www.w3.org/tr/html4/frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 frameset//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/1999/rec-html401-19991224/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3c.org/tr/1999/rec-html401-19991224/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html40/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/2000/rec-xhtml1-20000126/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/rec-html40/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public '-//w3c//dtd xhtml 1.0 transitional//en' 'http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd'>",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http:\\www.w3.org\tr\html\loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html40/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"" >",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd "">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html401/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"" >",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/2002/rec-xhtml1-20020801/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http://www.w3.org/tr/1999/rec-html401-19991224/frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""hmpro6.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 frameset//en"" ""dtd/xhtml1-frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1- transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3c.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en""""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public '-//w3c//dtd html 4.01 transitional//en' 'http://www.w3.org/tr/html4/loose.dtd'>",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml11/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www/w3.org/tr/xhtml/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/dtd/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" >",
                @"<!doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/1999/rec-html40119991224/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/rec-html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""dtd/xhtml-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/1999/pr-xhtml1-19991210/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/html1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml2/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""xhtml1-transitional.dtd"">",
                @"<!doctype html public '-//w3c//dtd xhtml 1.0 transitional//en' 'http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd' >",
                @"<!doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http://www.w3.org/tr/rec-html40/frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 frameset//en"" ""http://www.w3c.org/tr/1999/rec-html401-19991224/frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""c:\program files\softquad\xmetal 2\rules\loose-4.01.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.or g/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/xhtml4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3c.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""dtd/xhtml1-transitional.dtd"" >",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/1999/xhtml/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/2000/rec-xhtml1-200000126/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml-transitional.dtd"">",
                @"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-trans.dtd"">",
                @"<!doctype html public '-//w3c//dtd xhtml 1.0 transitional//en' 'dtd/xhtml1-transitional.dtd'>",
            };
            foreach (var doctype in data)
            {
                var actual = CompatibilityMode.GetCompatibilityModeFromDoctype(doctype.Trim(new[] {'<', '>', '!'}));
                Assert.Equal(CompatibilityModeDoctype.LimitedQuirks, actual);
            }
        }

        [Fact]
        public void Test_CompatibilityMode_Quirks()
        {
            var data = new[]
            {
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2//en"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2 final//en"">",
                @"<!doctype html public ""-//ietf//dtd html//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/rec-html40/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 frameset//en"">",
                @"<!doctype html public ""-//ietf//dtd html 2.0//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 frameset//en"">",
                @"<!doctype html public ""-//softquad software//dtd hotmetal pro 6.0::19990601::extensions to html 4.0//en"" ""hmpro6.dtd"">",
                @"<!doctype html public ""-//""aol hometown//html 3.0 transitional//en"">",
                @"<!doctype doctype public ""-//w3c//dtd html 4.0 transitional//en"">",
                @"<!doctype html public ""-//ietf//dtd html//en//2.0"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" >",
                @"<!doctype html public ""-//softquad//dtd hotmetal pro 4.0::19971010::extensions to html 4.0//en"" ""hmpro4.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/html40/loose.dtd"">",
                @"<!doctype html public '-//w3c//dtd html 4.01 transitional//en'>",
                @"<!doctype html public ""-//w3c//dtd html 4.0 frameset//en"" ""http://www.w3.org/tr/rec-html40/frameset.dtd"">",
                @"<!doctype html public '-//w3c//dtd html 4.0 transitional//en'>",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en""",
                @"<!doctype html public ""-//ietf//dtd html 3.0//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" """" >",
                @"<!doctype html public ""-//ietf//dtd html 3.2//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/1998/rec-html40-19980424/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2 draft//en"">",
                @"<!doctype html public>",
                @"<!doctype html public ""-//ietf//dtd html 3.0//en"" ""html.dtd"">",
                @"<!doctype html public ""-//netscape comm. corp.//dtd html//en"">",
                @"<!doctype html public ""-//sq//dtd html 2.0 hotmetal + extensions//en"">",
                @"<!doctype html public ""-//ietf//dtd html 3.2 final//en"">",
                @"<!doctype html public ""-//ietf//dtd html//en//3.0"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2 final//en"" ""http://www.w3.org/markup/wilbur/html32.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/rec-html40 loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd w3 html//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/html4/strict.dtd"">",
                @"<!doctype html public ""-//ietf//dtd html 3.2//en"" ""html.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2//en"" ""hmpro6.dtd"">",
                @"<!doctype html public ""-//ietf//dtd html//en"" ""hmpro6.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 3.2 final//en"" ""hmpro6.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"" />",
                @"<!doctype html public""-//w3c//dtd html 3.2//en"">",
                @"<!doctype html system>",
                @"<!doctype html public ""-//""aol hometown//html 3.0 transitional//fr"">",
                @"<!doctype html public ""-//sq//dtd html 2.0 hotmetal + extensions//en"" ""hmpro6.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 frameset//en"" ""http://www.w3.org/tr/rec-html40/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3.org/tr/rec-html40/strict.dtd"">",
                @"<!doctype html public ""-/w3c/dtd html 4.0 transitional/en"">",
                @"<!doctype html public '-//ietf//dtd html//en'>",
                @"<!doctype html public \""-//w3c//dtd html 4.0 transitional//en\"">",
                @"<!doctype>",
                @"<!doctype htm public ""-//w3c//dtd html 4.0 transitional//en"">",
                //@"<!doctype html ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                //@"<!doctype html public ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//ietf//dtd html 3.0//en//"">",
                @"<!doctype html public ""-//microsoft//dtd internet explorer 3.0 tables//en"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 frameset//en"" ""http://www.w3.org/tr/html4/frameset.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" ""http://www.w3c.org/tr/rec-html40/loose.dtd"">",
                @"<!doctype html public ""-//w3c//dtd html 4.0 transitional//en"" />",
              
                @"<!doctype html public '-//w3c//dtd html 3.2//en'>",
                @"<!doctype html public ""-//w3c//dtd html 4.01 transitional//en>""",
                @"<!doctype html public @@-//w3c//dtd html 3.2 final//en@@>",
                @"<!doctype html public""-//w3c//dtd html 3.2 final//en"">",
                @"<!doctype html public=""-//w3c//dtd html 4.0 transitional//en"">",
                //@"<!doctype ""html public""/>",
            
                @"<!doctype doctype public ""-//w3c//dtd html 4.0 transitional//cat"">",
                @"<!doctype doctype public ""-//w3c//dtd html 4.01 transitional//en"">",
                //@"<!doctype doctype public ""-//w3w//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/transitional.dtd"">",
                @"<!doctype ht<!doctype html public ""-//w3c//dtd html 4.01 transitional//en"">",
                //@"<!doctype htlm public ""-//w3c//dtd xhtm 1.0 strict//en ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype htm public ""-//w3c//dtd html 4.01 frameset//en"">",
                //@"<!doctype htm public ""-//w3c//dtd html 4.01 transitional//en"" ""http://www.w3.org/tr/html4/loose.dtd"">",
                @"<!doctype htm# public ""-//w3c//dtd html 4.01 transitional//en"">",
                @"<!doctype html ""-//ietf//dtd html 3.0//en"">",
                @"<!doctype html american oldies ""-//w3c//dtd html 3.2//rm"">",
                //@"<!doctype html lic ""-//w3c//dtd xhtml 1.0 strict//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-strict.dtd"">",
                @"<!doctype html media ""-//w3c//dtd html 4.01 transitional//en"">",
                @"<!doctype html pubblic""-//w3c//dtd html 3.2//en"">",
                //@"<!doctype html pubdivc ""-//w3c//dtd xhtml 1.0 transitional//en"" ""http://www.w3.org/tr/xhtml1/dtd/xhtml1-transitional.dtd"">",
                @"<!doctype html public ""-//ietf//dtd html 3.0//en"" ""c:\icspider\default.dtd"">",
                @"<!doctype html public ""-//ietf//dtd html 3.0//en//"" entity %>",
                @"<!doctype html public ""-//ietf//dtd html level 2//en//2.0"">",
                @"<!doctype html public ""-//ietf//dtd html//en"" />",
                @"<!doctype html public ""-//ietf//dtd html//en//4.2"" w.s.>",
                @"<!doctype html public ""-//netscape comm. corp.//dtd html//en"" >",
                @"<!doctype html public ""-//softquad software//dtd hotmetal pro 6.0::19990601::extensions to html 4.0//en"">",
                @"<!doctype html public ""-//w3o//dtd w3 html 3.0//en"" -->",
                //@"<!doctype html public ""-//w3c// dtd xhtml 1.0 frameset//en"" http://www.w3.org/tr/xhtml1/dtd/xhtml-frameset.dtd>",
              
                @"<!doctype html public ""-//w3c//dtd html 3.2//en"" >",
                @"<!doctype html public ""-//w3c//dtd html 3.2//en""-->",


            };
            foreach (var doctype in data)
            {
                var actual = CompatibilityMode.GetCompatibilityModeFromDoctype(doctype.Trim(new[] {'<', '>', '!'}));
                Assert.Equal(CompatibilityModeDoctype.Quirks, actual);
            }
        }


    }
}
