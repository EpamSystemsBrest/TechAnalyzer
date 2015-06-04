using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CssParser.CssProperties
{
    public class CssProperty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Initial { get; set; }
        public string AppliesTo { get; set; }
        public bool Inherited { get; set; }
        public CssVersion Version { get; set; }
        public MediaGroups Media { get; set; }
        public CssAnimatable Animatable { get; set; }
        public Categories Categories { get; set; }
        public string ContentModel { get; set; }
        public string Attributes { get; set; }
        public CssModule Module { get; set; }
        public string Url { get { return Module.Url + "#" + Name; }
        }
    }

    [Flags]
    public enum CssVersion
    {
        Css3 = 1,
        Css2 = 2
    }

    public enum Categories
    {
        None = 0,
        FilterPrimitiveElement = 1,
        TransferFunctionElement = 2,
        LightSourceElement = 3,
    }

    public class CssModule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }

    [Flags]
    public enum CssAnimatable
    {
        No = 2,
        Yes = 4,
        AsColor = 6,
        AsLength = 8,
        AsWidth = 10,
        AsInteger = 12,
        AsNumber = 14,
        AsRepeat = 16,
        AsTwoValues = 18,
        AsShadowlist = 20,
        AsRectangle = 22,
        AsTransform = 24,
        AsFontweight = 26,
        AsFontStretch = 28,
        AsLengthPercentageOrCalc = 30,
        AsSpecifiedForBasicShape = 32,
        YesBetweenGrids = 34,
        LengthOrPercentage = 36
    }

    [Flags]
    public enum MediaGroups
    {
        None = 0,
        Visual = 2,
        Speech = 4,
        Interactive = 6,
        Paged = 8,
        Continuous = 10
    }
}
