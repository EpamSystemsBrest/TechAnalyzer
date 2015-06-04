using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CssParser.CssProperties
{
    public static class ConstantsProperties
    {
        private static readonly CssModule[] CssModule =
        {
            new CssModule()
            {
                Id = 1,
                Name = "CSS Backgrounds and Borders Module Level 3",
                Url = "http://www.w3.org/TR/css3-background/"
            },
            new CssModule()
            {
                Id = 2,
                Name = "CSS Image Values and Replaced Content Module Level 3",
                Url = "http://www.w3.org/TR/css3-images/"
            },
            new CssModule()
            {
                Id = 3,
                Name = "CSS Multi-column Layout Module",
                Url = "http://www.w3.org/TR/css3-multicol/"
            },
            new CssModule()
            {
                Id = 4,
                Name = "CSS Speech Module",
                Url = "http://www.w3.org/TR/css3-speech/"
            },
            new CssModule()
            {
                Id = 5,
                Name = "CSS Flexible Box Layout Module Level 1",
                Url = "http://www.w3.org/TR/css3-flexbox/"
            },
            new CssModule()
            {
                Id = 6,
                Name = "CSS Text Decoration Module Level 3",
                Url = "http://www.w3.org/TR/css-text-decor-3/"
            },
            new CssModule()
            {
                Id = 7,
                Name = "CSS Cascading and Inheritance Level 3",
                Url = "http://www.w3.org/TR/css3-cascade/"
            },
            new CssModule()
            {
                Id = 8,
                Name = "CSS Fonts Module Level 3",
                Url = "http://www.w3.org/TR/css3-fonts/"
            },
            new CssModule()
            {
                Id = 9,
                Name = "CSS Writing Modes Level 3",
                Url = "http://www.w3.org/TR/css3-writing-modes/"
            },
            new CssModule()
            {
                Id = 10,
                Name = "CSS Shapes Module Level 1",
                Url = "http://www.w3.org/TR/css-shapes-1/"
            },
            new CssModule()
            {
                Id = 11,
                Name = "CSS Masking Module Level 1",
                Url = "http://www.w3.org/TR/css-masking/"
            },
            new CssModule()
            {
                Id = 12,
                Name = "CSS Animations",
                Url = "http://www.w3.org/TR/css3-animations/"
            },
            new CssModule()
            {
                Id = 13,
                Name = "CSS Text Module Level 3",
                Url = "http://www.w3.org/TR/css3-text/"
            },
            new CssModule()
            {
                Id = 14,
                Name = "CSS Fragmentation Module Level 3",
                Url = "http://www.w3.org/TR/css3-break/"
            },
            new CssModule()
            {
                Id = 15,
                Name = "CSS Transforms Module Level 1",
                Url = "http://www.w3.org/TR/css3-transforms/"
            },
            new CssModule()
            {
                Id = 16,
                Name = "CSS Transitions",
                Url = "http://www.w3.org/TR/css3-transitions/"
            },
            new CssModule()
            {
                Id = 17,
                Name = "CSS Custom Properties for Cascading Variables Module Level 1",
                Url = "http://www.w3.org/TR/css-variables/"
            },
            new CssModule()
            {
                Id = 18,
                Name = "Compositing and Blending Level 1",
                Url = "http://www.w3.org/TR/compositing-1/"
            },
            new CssModule()
            {
                Id = 19,
                Name = "CSS Basic User Interface Module Level 3 (CSS3 UI)",
                Url = "http://www.w3.org/TR/css3-ui/"
            },
            new CssModule()
            {
                Id = 20,
                Name = "CSS Will Change Module Level 1",
                Url = "http://www.w3.org/TR/css-will-change-1/"
            },
            new CssModule()
            {
                Id = 21,
                Name = "CSS Box Alignment Module Level 3",
                Url = "http://www.w3.org/TR/css3-align/"
            },
            new CssModule()
            {
                Id = 22,
                Name = "CSS Grid Layout Module Level 1",
                Url = "http://www.w3.org/TR/css3-grid-layout/"
            },
            new CssModule()
            {
                Id = 23,
                Name = "CSS Paged Media Module Level 3",
                Url = "http://www.w3.org/TR/css3-page/"
            },
            new CssModule()
            {
                Id = 24,
                Name = "CSS Device Adaptation",
                Url = "http://www.w3.org/TR/css-device-adapt/"
            },
            new CssModule()
            {
                Id = 25,
                Name = "CSS Exclusions Module Level 1",
                Url = "http://www.w3.org/TR/css3-exclusions/"
            },
            new CssModule()
            {
                Id = 26,
                Name = "CSS Generated Content for Paged Media Module",
                Url = "http://www.w3.org/TR/css3-gcpm/"
            },
            new CssModule()
            {
                Id = 27,
                Name = "Filter Effects Module Level 1",
                Url = "http://www.w3.org/TR/filter-effects/"
            },
            new CssModule()
            {
                Id = 28,
                Name = "CSS Line Grid Module Level 1",
                Url = "http://www.w3.org/TR/css-line-grid-1/"
            },
            new CssModule()
            {
                Id = 29,
                Name = "CSS Positioned Layout Module Level 3",
                Url = "http://www.w3.org/TR/css3-positioning/"
            },
            new CssModule()
            {
                Id = 30,
                Name = "CSS Ruby Layout Module Level 1",
                Url = "http://www.w3.org/TR/css3-ruby/"
            },
            new CssModule()
            {
                Id = 31,
                Name = "CSS Overflow Module Level 3",
                Url = "http://www.w3.org/TR/css-overflow-3/"
            },
            new CssModule()
            {
                Id = 32,
                Name = "CSS Display Module Level 3",
                Url = "http://www.w3.org/TR/css-display-3/"
            },
            new CssModule()
            {
                Id = 33,
                Name = "Motion Path Module Level 1",
                Url = "http://www.w3.org/TR/motion-1/"
            },
            new CssModule()
            {
                Id = 34,
                Name = "CSS Scroll Snap Points Module Level 1",
                Url = "http://www.w3.org/TR/css-snappoints-1/"
            },
            new CssModule()
            {
                Id = 35,
                Name = "CSS basic box model",
                Url = "http://www.w3.org/TR/css3-box/"
            },
            new CssModule()
            {
                Id = 36,
                Name = "CSS3 Generated and Replaced Content Module",
                Url = "http://www.w3.org/TR/css3-content/"
            },
            new CssModule()
            {
                Id = 37,
                Name = "CSS3 module: line",
                Url = "http://www.w3.org/TR/css3-linebox/"
            },
            new CssModule()
            {
                Id = 38,
                Name = "CSS Presentation Levels Module",
                Url = "http://www.w3.org/TR/css3-preslev/"
            },
            new CssModule()
            {
                Id = 39,
                Name = "CSS Counter Styles Level 3",
                Url = "http://www.w3.org/TR/css-counter-styles-3/"
            },
            new CssModule()
            {
                Id = 40,
                Name = "CSS Template Layout Module",
                Url = "http://www.w3.org/TR/css-template-3/"
            },
            new CssModule()
            {
                Id = 41,
                Name = "CSS Lists and Counters Module Level 3",
                Url = "http://www.w3.org/TR/css3-lists/"
            },
            new CssModule()
            {
                Id = 42,
                Name = "CSS Intrinsic & Extrinsic Sizing Module Level 3",
                Url = "http://www.w3.org/TR/css3-sizing/"
            },
            new CssModule()
            {
                Id = 43,
                Name = "CSS Regions Module Level 1",
                Url = "http://www.w3.org/TR/css3-regions/"
            }
        };

        private static readonly string[] CssComputedValue =
        {
            "as specified but with URIs made absolute",
            "A list each item consisting of: two keywords one per dimension",
            "as specified",
            "A list each item consisting of: a pair of offsets (horizontal andvertical) from the top left origin each given",
            "as specified but with lengths made absolute and omitted ‘auto’ keywords filled in",
            "the computed color",
            "see individual properties",
            "specified value",
            "four values each a percentage number ‘auto’ keyword or <length> made absolute",
            "absolute length; ‘0’ if the border styleis ‘none’ or ‘hidden’",
            "two absolute <length> or percentages",
            "‘none’ or the image with its URI madeabsolute",
            "as four values each a number or percentage and optionally a ‘fill’keyword",
            "four values each a number or <length> madeabsolute",
            "two keywords one for each axis",
            "any <length> made absolute; any specified color computed;otherwise as specified",
            "specified value rounded and normalized (see text)",
            "the absolute length zero or larger",
            "absolute length or ‘normal’",
            "the same as the computed value for the ‘color’ property [CSS21]",
            "absolute length; ‘0’ if thecolumn rule style is ‘none’ or‘hidden’",
            "‘silent’ or a keyword valueand optionally also a decibel offset (if not zero)",
            "the specified value resolved to a <number> between‘-100’ and ‘100’ (inclusive)",
            "the percentage as specified or the absolute length plus anykeywords as specified",
            "N/A",
            "a keyword value and optionally also a percentage relative to thekeyword (if not 100%)",
            "specified value with lengths made absolute ",
            "specified keyword plus integer if digits",
            "auto computes to parent’s align-items value; otherwise as specified ",
            "‘none’ a pair of keywordsrepresenting the shape and fill or a string",
            "numeric weight value (see description)",
            "Consists of: two keywords one per dimension",
            "two keywords representing the origin and two offsets",
            "all <length>s made absolute otherwise as specified",
            "For <length> the absolute value otherwise a percentage",
            "specified value except for ‘match-parent’ which computes as defined below",
            "The computed value for invert is invert.",
            "as specified except with any relative Urls converted to absolute",
            "The computed value for auto is auto.",
            "specified value except for auto (see prose)",
            "see Track Sizing ",
            "‘auto’ ‘device-width’‘device-height’ an absolute length or apercentage as specified",
            "‘auto’ or a positive number orpercentage as specified.",
            "‘zoom’ or ‘fixed’ as specified.",
            "‘auto’ ‘portrait’ or‘landscape’as specified.",
            "‘auto’ ‘device’ or aresolution value as specified.",
            "specified value if keyword specified else as defined in [CSS21]",
            "computed value fo the <image> or none",
            "see prose otherwise same as normal",
            "see below",
            "a keyword",
            "see prose",
            "<length>",
            "the percentage as specified or the absolute length or ‘auto’",
            "the percentage as specified or the absolute length or ‘none’",
            "ltr or rtl",
            "see text",
            "integer"
        };

        public static readonly CssProperty[] CssProperties =
        {
            new CssProperty
            {
                Id = 1,
                Name = "background-color",
                Version = CssVersion.Css2,
                Value = "<color>",
                Initial = "transparent",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 2,
                Name = "background-image",
                Version = CssVersion.Css2,
                Value = "<bg-image> [<bg-image> ]*",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 3,
                Name = "background-repeat",
                Version = CssVersion.Css2,
                Value = "<repeat-style> [ <repeat-style> ]*",
                Initial = "repeat",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 4,
                Name = "background-attachment",
                Version = CssVersion.Css2,
                Value = "<attachment> [<attachment> ]*",
                Initial = "scroll",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 5,
                Name = "background-position",
                Version = CssVersion.Css2,
                Value = "<position> [<position> ]*",
                Initial = "0% 0%",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsRepeat,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 6,
                Name = "background-clip",
                Version = CssVersion.Css3,
                Value = "<box> [<box> ]*",
                Initial = "border-box",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 7,
                Name = "background-origin",
                Version = CssVersion.Css3,
                Value = "<box> [<box> ]*",
                Initial = "padding-box",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 8,
                Name = "background-size",
                Version = CssVersion.Css3,
                Value = "<bg-size> [<bg-size> ]*",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 9,
                Name = "background",
                Version = CssVersion.Css2,
                Value = "[ <bg-layer>]* <final-bg-layer>",
                Initial = "see individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 10,
                Name = "border-top-color",
                Version = CssVersion.Css2,
                Value = "<color>",
                Initial = "currentColor",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 11,
                Name = "border-right-color",
                Version = CssVersion.Css2,
                Value = "<color>",
                Initial = "currentColor",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 12,
                Name = "border-bottom-color",
                Version = CssVersion.Css2,
                Value = "<color>",
                Initial = "currentColor",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 13,
                Name = "border-left-color",
                Version = CssVersion.Css2,
                Value = "<color>",
                Initial = "currentColor",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 14,
                Name = "border-color",
                Version = CssVersion.Css2,
                Value = "<color>{14}",
                Initial = "see individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 15,
                Name = "border-top-style",
                Version = CssVersion.Css2,
                Value = "<line-style>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 16,
                Name = "border-right-style",
                Version = CssVersion.Css2,
                Value = "<line-style>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 17,
                Name = "border-bottom-style",
                Version = CssVersion.Css2,
                Value = "<line-style>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 18,
                Name = "border-left-style",
                Version = CssVersion.Css2,
                Value = "<line-style>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 19,
                Name = "border-style",
                Version = CssVersion.Css2,
                Value = "<line-style>{14}",
                Initial = "see individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 20,
                Name = "border-top-width",
                Version = CssVersion.Css2,
                Value = "<line-width>",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 21,
                Name = "border-right-width",
                Version = CssVersion.Css2,
                Value = "<line-width>",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 22,
                Name = "border-bottom-width",
                Version = CssVersion.Css2,
                Value = "<line-width>",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 23,
                Name = "border-left-width",
                Version = CssVersion.Css2,
                Value = "<line-width>",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 24,
                Name = "border-width",
                Version = CssVersion.Css2,
                Value = "<line-width>{14}",
                Initial = "see individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 25,
                Name = "border-top",
                Version = CssVersion.Css2,
                Value = "<line-width> || <line-style> ||<color>",
                Initial = "See individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 26,
                Name = "border-right",
                Version = CssVersion.Css2,
                Value = "<line-width> || <line-style> ||<color>",
                Initial = "See individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 27,
                Name = "border-left",
                Version = CssVersion.Css2,
                Value = "<line-width> || <line-style> ||<color>",
                Initial = "See individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 28,
                Name = "border-bottom",
                Version = CssVersion.Css2,
                Value = "<line-width> || <line-style> ||<color>",
                Initial = "See individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 29,
                Name = "border",
                Version = CssVersion.Css2,
                Value = "<line-width> || <line-style> ||<color>",
                Initial = "See individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 30,
                Name = "border-top-left-radius",
                Version = CssVersion.Css3,
                Value = "[ <length> | <percentage> ]{12}",
                Initial = "0",
                AppliesTo = "all elements (but see prose)",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsTwoValues,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 31,
                Name = "border-top-right-radius",
                Version = CssVersion.Css3,
                Value = "[ <length> | <percentage> ]{12}",
                Initial = "0",
                AppliesTo = "all elements (but see prose)",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsTwoValues,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 32,
                Name = "border-bottom-left-radius",
                Version = CssVersion.Css3,
                Value = "[ <length> | <percentage> ]{12}",
                Initial = "0",
                AppliesTo = "all elements (but see prose)",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsTwoValues,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 33,
                Name = "border-radius",
                Version = CssVersion.Css3,
                Value = "[ <length> | <percentage> ]{14} [/ [ <length> | <percentage> ]{14} ]?",
                Initial = "see individual properties",
                AppliesTo = "all elements (but see prose)",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 34,
                Name = "border-image-source",
                Version = CssVersion.Css3,
                Value = "none | <image>",
                Initial = "none",
                AppliesTo = "All elements except internal table elements when ‘border-collapse’ is ‘collapse’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0], // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 35,
                Name = "border-image-slice",
                Version = CssVersion.Css3,
                Value = "[<number> | <percentage>]{14}&& fill?",
                Initial = "100%",
                AppliesTo = "All elements except internal table elements when ‘border-collapse’ is ‘collapse’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 36,
                Name = "border-image-width",
                Version = CssVersion.Css3,
                Value = "[ <length> | <percentage> |<number> | auto ]{14}",
                Initial = "1",
                AppliesTo = "All elements except table elements when ‘border-collapse’ is ‘collapse’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 37,
                Name = "border-image-outset",
                Version = CssVersion.Css3,
                Value = "[ <length> | <number> ]{14}",
                Initial = "0",
                AppliesTo = "All elements except internal table elements when ‘border-collapse’ is ‘collapse’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 38,
                Name = "border-image-repeat",
                Version = CssVersion.Css3,
                Value = "[ stretch | repeat | round | space ]{12}",
                Initial = "stretch",
                AppliesTo = "All elements except internal table elements when ‘border-collapse’ is ‘collapse’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 39,
                Name = "border-image",
                Version = CssVersion.Css3,
                Value =
                    "<border-image-source>|<border-image-slice>|<border-image-width>|<border-image-width>|<border-image-outset>|<border-image-repeat>",
                Initial = "See individual properties",
                AppliesTo = "See individual properties",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 40,
                Name = "box-shadow",
                Version = CssVersion.Css3,
                Value = "none | <shadow> [<shadow> ]*",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsShadowlist,
                Module = CssModule[0] // CSS Backgrounds and Borders Module Level 3
            },
            new CssProperty
            {
                Id = 41,
                Name = "object-fit",
                Version = CssVersion.Css3,
                Value = "fill | contain | cover | none | scale-down",
                Initial = "fill",
                AppliesTo = "replaced elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[1] //CSS Image Values and Replaced Content Module Level 3
            },
            new CssProperty
            {
                Id = 42,
                Name = "object-position",
                Version = CssVersion.Css3,
                Value = "<position>",
                Initial = "50% 50%",
                AppliesTo = "replaced elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[1] //CSS Image Values and Replaced Content Module Level 3
            },
            new CssProperty
            {
                Id = 43,
                Name = "image-resolution",
                Version = CssVersion.Css3,
                Value = "[from-image || <resolution>] && snap?",
                Initial = "1dppx",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[1] //CSS Image Values and Replaced Content Module Level 3
            },
            new CssProperty
            {
                Id = 44,
                Name = "image-orientation",
                Version = CssVersion.Css3,
                Value = "<angle>",
                Initial = "0deg",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[1] //CSS Image Values and Replaced Content Module Level 3
            },
            new CssProperty
            {
                Id = 45,
                Name = "column-width",
                Version = CssVersion.Css3,
                Value = "<length> | auto | ‘min-content’| ‘max-content’ |‘fill-available’ | ‘fit-content’",
                Initial = "auto",
                AppliesTo =
                    "non-replaced block-level elements (except table elements) tablecells and inline-block elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 46,
                Name = "column-count",
                Version = CssVersion.Css3,
                Value = "<integer> | auto",
                Initial = "auto",
                AppliesTo =
                    "non-replaced block-level elements (except table elements) tablecells and inline-block elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 47,
                Name = "columns",
                Version = CssVersion.Css3,
                Value = "<‘column-width’> || <‘column-count’>",
                Initial = "see individual properties",
                AppliesTo =
                    "non-replaced block-level elements (except table elements) tablecells and inline-block elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 48,
                Name = "column-gap",
                Version = CssVersion.Css3,
                Value = "<length> | normal",
                Initial = "normal",
                AppliesTo = "multicol elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2], //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 49,
                Name = "column-rule-color",
                Version = CssVersion.Css3,
                Value = "<color>",
                Initial = "same as for ‘color’ property[CSS21]",
                AppliesTo = "multicol elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 50,
                Name = "column-rule-style",
                Version = CssVersion.Css3,
                Value = "<border-style>",
                Initial = "none",
                AppliesTo = "multicol elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 51,
                Name = "column-rule-width",
                Version = CssVersion.Css3,
                Value = "<border-width>",
                Initial = "medium",
                AppliesTo = "multicol elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 52,
                Name = "column-rule",
                Version = CssVersion.Css3,
                Value = "<‘column-rule-width’> || <‘column-rule-style’> || [ <‘column-rule-color’> | transparent ]",
                Initial = "see individual properties",
                AppliesTo = "multicol elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2], //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 53,
                Name = "break-before",
                Version = CssVersion.Css2,
                Value =
                    "auto |always|avoid|any|avoid-page|left|right|page|column|avoid-page|avoid-column| avoid-region | region|recto | verso",
                Initial = "auto",
                AppliesTo = "block-level elements table row groups table rows (but see prose)",
                Inherited = false,
                Media = MediaGroups.Paged | MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 54,
                Name = "break-after",
                Version = CssVersion.Css2,
                Value =
                    "auto |always|avoid|any|avoid-page|left|right|page|column|avoid-page|avoid-column| avoid-region | region|recto | verso",
                Initial = "auto",
                AppliesTo = "block-level elements table row groups table rows (but see prose)",
                Inherited = false,
                Media = MediaGroups.Paged | MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 55,
                Name = "break-inside",
                Version = CssVersion.Css2,
                Value = "auto | avoid | avoid-page | avoid-column |avoid-region",
                Initial = "auto",
                AppliesTo =
                    "block-level elements in the normal flow that that establish formatting contextsor are block containers table row groups",
                Inherited = false,
                Media = MediaGroups.Paged | MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 56,
                Name = "column-span",
                Version = CssVersion.Css3,
                Value = "none | all",
                Initial = "none",
                AppliesTo = "block-level elements except floating and absolutely positionedelements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 57,
                Name = "column-fill",
                Version = CssVersion.Css3,
                Value = "auto | balance",
                Initial = "balance",
                AppliesTo = "multicol elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[2] //CSS Multi-column Layout Module
            },
            new CssProperty
            {
                Id = 58,
                Name = "voice-volume",
                Version = CssVersion.Css3,
                Value = "silent | [[x-soft | soft | medium | loud | x-loud] ||<decibel>]",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 59,
                Name = "voice-balance",
                Version = CssVersion.Css3,
                Value = "<number> | left | center | right | leftwards | rightwards",
                Initial = "center",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 60,
                Name = "speak",
                Version = CssVersion.Css2,
                Value = "auto | none | normal",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 61,
                Name = "speak-as",
                Version = CssVersion.Css2,
                Value =
                    "normal | spell-out || digits || [ literal-punctuation |no-punctuation ] ||auto | bullets | numbers | words | spell-out | <counter-style-name>",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 62,
                Name = "pause-before",
                Version = CssVersion.Css2,
                Value = "<time> | none | x-weak | weak | medium | strong | x-strong",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 63,
                Name = "pause-after",
                Version = CssVersion.Css2,
                Value = "<time> | none | x-weak | weak | medium | strong | x-strong",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 64,
                Name = "pause",
                Version = CssVersion.Css2,
                Value = "<‘pause-before’> <‘pause-after’>?",
                Initial = "N/A (see individual properties)",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 65,
                Name = "rest-before",
                Version = CssVersion.Css3,
                Value = "<time> | none | x-weak | weak | medium | strong | x-strong",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 66,
                Name = "rest-after",
                Version = CssVersion.Css3,
                Value = "<time> | none | x-weak | weak | medium | strong | x-strong",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 67,
                Name = "rest",
                Version = CssVersion.Css3,
                Value = "<‘rest-before’> <‘rest-after’>?",
                Initial = "N/A (see individual properties)",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 68,
                Name = "cue-before",
                Version = CssVersion.Css2,
                Value = "<uri> <decibel>? | none",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 69,
                Name = "cue-after",
                Version = CssVersion.Css2,
                Value = "<uri> <decibel>? | none",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 70,
                Name = "cue",
                Version = CssVersion.Css2,
                Value = "<‘cue-before’> <‘cue-after’>?",
                Initial = "N/A (see individual properties)",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 71,
                Name = "voice-family",
                Version = CssVersion.Css2,
                Value = " [[<name> | <generic-voice>]]* [<name> |<generic-voice>] | preserve",
                Initial = "implementation-dependent",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 72,
                Name = "voice-rate",
                Version = CssVersion.Css3,
                Value = "[normal | x-slow | slow | medium | fast | x-fast] ||<percentage>",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 73,
                Name = "voice-pitch",
                Version = CssVersion.Css3,
                Value =
                    "<frequency> && absolute | [[x-low | low | medium |high | x-high] || [<frequency> | <semitones> |<percentage>]]",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 74,
                Name = "voice-range",
                Version = CssVersion.Css3,
                Value =
                    "<frequency> && absolute | [[x-low | low | medium |high | x-high] || [<frequency> | <semitones> |<percentage>]]",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 75,
                Name = "voice-stress",
                Version = CssVersion.Css3,
                Value = "normal | strong | moderate | none | reduced",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 76,
                Name = "voice-duration",
                Version = CssVersion.Css3,
                Value = "auto | <time>",
                Initial = " auto",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Speech,
                Animatable = CssAnimatable.No,
                Module = CssModule[3] //CSS Speech Module
            },
            new CssProperty
            {
                Id = 77,
                Name = "display",
                Version = CssVersion.Css2,
                Value =
                    "inline | block | inline-block | list-item | run-in | compact | table| inline-table | table-row-group | table-header-group |table-footer-group | table-row | table-column-group | table-column |table-cell | table-caption | ruby | " +
                    "ruby-base | ruby-text |ruby-base-group | ruby-text-group ruby-base-container | ruby-text-container | <template>| none" +
                    "[ <‘display-inside’> || <‘display-outside’> || <display-list> ] | inline | inline-list-item|inline-table|inline-flex|inline-grid",
                Initial = "inline",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 78,
                Name = "min-width",
                Value = "fill-available | max-content | min-content | fit-content | <viewport-length>, contain-floats",
                Version = CssVersion.Css2,
                Initial = "auto",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 79,
                Name = "min-height",
                Value =
                    "‘fill-available’ | ‘max-content’ | ‘min-content’ | ‘fit-content’ | contain-floats | <viewport-length>",
                Version = CssVersion.Css2,
                Initial = "auto",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 80,
                Name = "flex-direction",
                Version = CssVersion.Css3,
                Value = "row | row-reverse | column | column-reverse ",
                Initial = "row ",
                AppliesTo = "flex containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 81,
                Name = "flex-wrap",
                Version = CssVersion.Css3,
                Value = "nowrap | wrap | wrap-reverse ",
                Initial = "nowrap ",
                AppliesTo = "flex containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 82,
                Name = "flex-flow",
                Version = CssVersion.Css3,
                Value = "<flex-direction> || <flex-wrap> ",
                Initial = "see individual properties ",
                AppliesTo = "see individual properties ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 83,
                Name = "order",
                Version = CssVersion.Css3,
                Value = "<integer> ",
                Initial = "0 ",
                AppliesTo = "flex items and absolutely-positioned children of flex containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 84,
                Name = "flex",
                Version = CssVersion.Css3,
                Value = "none | [ <‘flex-grow’> <‘flex-shrink’>? || <‘flex-basis’> ] ",
                Initial = "see individual properties ",
                AppliesTo = "flex items ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 85,
                Name = "flex-grow",
                Version = CssVersion.Css3,
                Value = "<number> ",
                Initial = "0 ",
                AppliesTo = "flex items ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 86,
                Name = "flex-shrink",
                Version = CssVersion.Css3,
                Value = "<number> ",
                Initial = "1 ",
                AppliesTo = "flex items ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 87,
                Name = "flex-basis",
                Version = CssVersion.Css3,
                Value = "content | <‘width’> ",
                Initial = "auto ",
                AppliesTo = "flex items ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsWidth,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 88,
                Name = "justify-content",
                Version = CssVersion.Css3,
                Value =
                    "flex-start | flex-end | center | space-between | space-around | auto | <baseline-position> |<content-distribution> || [ <overflow-position>? && <content-position> ]",
                Initial = "flex-start ",
                AppliesTo = "block containers flex containers and grid containers",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 89,
                Name = "align-items",
                Version = CssVersion.Css3,
                Value =
                    "flex-start | flex-end | center | baseline | stretch |auto | stretch | <baseline-position> | [ <item-position> && <overflow-position>? ] ",
                Initial = "stretch,auto",
                AppliesTo = "flex containers and block-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 90,
                Name = "align-self",
                Version = CssVersion.Css3,
                Value =
                    "auto | flex-start | flex-end | center | baseline | stretch | <baseline-position> | [ <overflow-position>? && <item-position> ]",
                Initial = "auto ",
                AppliesTo = "flex items grid items and absolutely-positioned boxes",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 91,
                Name = "align-content",
                Version = CssVersion.Css3,
                Value =
                    "flex-start | flex-end | center | space-between | space-around | stretch auto | <baseline-position> |<content-distribution> || [ <overflow-position>? && <content-position> ]",
                Initial = "stretch ",
                AppliesTo = "multi-line flex containers and block containers flex containers and grid containers",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[4] //CSS Flexible Box Layout Module Level 1
            },
            new CssProperty
            {
                Id = 92,
                Name = "text-decoration-line",
                Version = CssVersion.Css3,
                Value = "none | [ underline || overline || line-through || blink ]",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 93,
                Name = "text-decoration-color",
                Version = CssVersion.Css3,
                Value = "<color>",
                Initial = "currentColor",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 94,
                Name = "text-decoration-style",
                Version = CssVersion.Css3,
                Value = "solid | double | dotted | dashed | wavy",
                Initial = "solid",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 95,
                Name = "text-decoration",
                Version = CssVersion.Css2,
                Value = "<text-decoration-line> ||<text-decoration-style>|| <text-decoration-color>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 96,
                Name = "text-decoration-skip",
                Version = CssVersion.Css3,
                Value = "none | [ objects || spaces || ink || edges || box-decoration ]",
                Initial = "objects",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 97,
                Name = "text-underline-position",
                Version = CssVersion.Css3,
                Value = "auto | [ under || [ left | right ] ]",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 98,
                Name = "text-emphasis-style",
                Version = CssVersion.Css3,
                Value = "none | [ [ filled | open ] || [ dot | circle | double-circle |triangle | sesame ] ] | <string>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 99,
                Name = "text-emphasis-color",
                Version = CssVersion.Css3,
                Value = "<color>",
                Initial = "currentColor",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 100,
                Name = "text-emphasis",
                Version = CssVersion.Css3,
                Value = "‘<text-emphasis-style>’ ||‘<text-emphasis-color>’",
                Initial = "see individual properties",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 101,
                Name = "text-emphasis-position",
                Version = CssVersion.Css3,
                Value = "[ over | under ] && [ right | left ]",
                Initial = "over right",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 102,
                Name = "text-shadow",
                Version = CssVersion.Css3,
                Value = "none | [ <length>{23} && <color>? ]#",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsShadowlist,
                Module = CssModule[5] //CSS Text Decoration Module Level 3
            },
            new CssProperty
            {
                Id = 103,
                Name = "all",
                Version = CssVersion.Css2,
                Value = "initial | inherit | unset ",
                Initial = "See individual properties ",
                AppliesTo = "See individual properties ",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[6] //CSS Cascading and Inheritance Level 3
            },
            new CssProperty
            {
                Id = 104,
                Name = "font-family",
                Version = CssVersion.Css2,
                Value = "[ <family-name> |<generic-family> ]#",
                Initial = "depends on user agent",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 105,
                Name = "font-weight",
                Version = CssVersion.Css2,
                Value = "normal | bold | bolder | lighter | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsFontweight,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 106,
                Name = "font-stretch",
                Version = CssVersion.Css2,
                Value =
                    " normal | ultra-condensed | extra-condensed |condensed |semi-condensed |semi-expanded |expanded |extra-expanded|ultra-expanded",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsFontStretch,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 107,
                Name = "font-style",
                Version = CssVersion.Css2,
                Value = "normal | italic |oblique",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 108,
                Name = "font-size",
                Version = CssVersion.Css2,
                Value = "<absolute-size>| <relative-size> |<length> | <percentage>",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 109,
                Name = "font-size-adjust",
                Version = CssVersion.Css2,
                Value = "none | <number>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsNumber,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 110,
                Name = "font",
                Version = CssVersion.Css2,
                Value =
                    "<font-style>|<font-variant-css21>|<font-weight>|<font-stretch>|<font-size>|<line-height>|<font-family>|small-caption|status-bar",
                Initial = "see individual properties",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 111,
                Name = "font-synthesis",
                Version = CssVersion.Css3,
                Value = "none | [ weight || style ]",
                Initial = "weight style",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 112,
                Name = "font-kerning",
                Version = CssVersion.Css3,
                Value = "auto | normal | none",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 113,
                Name = "font-variant-ligatures",
                Version = CssVersion.Css3,
                Value =
                    "normal | none | [ <common-lig-values> ||<discretionary-lig-values>|| <historical-lig-values>|| <contextual-alt-values>]",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 114,
                Name = "font-variant-position",
                Version = CssVersion.Css3,
                Value = "normal | sub | super",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 115,
                Name = "font-variant-caps",
                Version = CssVersion.Css3,
                Value = "normal | small-caps | all-small-caps | petite-caps | all-petite-caps | unicase | titling-caps",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 116,
                Name = "font-variant-numeric",
                Version = CssVersion.Css3,
                Value =
                    "normal | [ <numeric-figure-values>|| <numeric-spacing-values>|| <numeric-fraction-values>|| ordinal || slashed-zero ]",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 117,
                Name = "font-variant-alternates",
                Version = CssVersion.Css3,
                Value =
                    "normal |stylistic|| historical-forms || styleset || character-variant || swash || ornaments || annotation(<feature-value-name>) ]",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 118,
                Name = "font-variant-east-asian",
                Version = CssVersion.Css3,
                Value = "normal | [ <east-asian-variant-values>|| <east-asian-width-values>|| ruby ]",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 119,
                Name = "font-variant",
                Version = CssVersion.Css2,
                Value =
                    "normal | none | [<common-lig-values>|| <discretionary-lig-values>|| <historical-lig-values>|| <contextual-alt-values>||ruby ]",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 120,
                Name = "font-feature-settings",
                Version = CssVersion.Css3,
                Value = "normal | <feature-tag-value> #",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 121,
                Name = "font-language-override",
                Version = CssVersion.Css3,
                Value = "normal | <string>",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[7] //CSS Fonts Module Level 3
            },
            new CssProperty
            {
                Id = 122,
                Name = "direction",
                Version = CssVersion.Css2,
                Value = "ltr | rtl",
                Initial = "ltr",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[8] //CSS Writing Modes Level 3
            },
            new CssProperty
            {
                Id = 123,
                Name = "unicode-bidi",
                Version = CssVersion.Css2,
                Value = "normal | embed | isolate | bidi-override | isolate-override | plaintext",
                Initial = "normal",
                AppliesTo = "all elements but see prose",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[8] //CSS Writing Modes Level 3
            },
            new CssProperty
            {
                Id = 124,
                Name = "writing-mode",
                Version = CssVersion.Css3,
                Value = "horizontal-tb | vertical-rl | vertical-lr",
                Initial = "horizontal-tb",
                AppliesTo = "All elements except table row groups table column groups table rows and table columns",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[8] //CSS Writing Modes Level 3
            },
            new CssProperty
            {
                Id = 125,
                Name = "text-orientation",
                Version = CssVersion.Css3,
                Value = "mixed | upright | sideways-right | sideways-left | sideways | use-glyph-orientation",
                Initial = "mixed",
                AppliesTo = "all elements except table row groups rows column groups and columns",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[8] //CSS Writing Modes Level 3
            },
            new CssProperty
            {
                Id = 126,
                Name = "caption-side",
                Version = CssVersion.Css2,
                Initial = "N/A",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[8] //CSS Writing Modes Level 3
            },
            new CssProperty
            {
                Id = 127,
                Name = "text-combine-upright",
                Version = CssVersion.Css3,
                Value = "none | all | [ digits <integer>? ]",
                Initial = "none",
                AppliesTo = "non-replaced inline elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[8] //CSS Writing Modes Level 3
            },
            new CssProperty
            {
                Id = 128,
                Name = "shape-outside",
                Version = CssVersion.Css3,
                Value = "none | [ <basic-shape> || <shape-box> ] | <image>",
                Initial = "none",
                AppliesTo = "floats",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLengthPercentageOrCalc,
                Module = CssModule[9] //CSS Shapes Module Level 1
            },
            new CssProperty
            {
                Id = 129,
                Name = "shape-image-threshold",
                Version = CssVersion.Css3,
                Value = "<number>",
                Initial = "0.0",
                AppliesTo = "floats",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsNumber,
                Module = CssModule[9] //CSS Shapes Module Level 1
            },
            new CssProperty
            {
                Id = 130,
                Name = "shape-margin",
                Version = CssVersion.Css3,
                Value = "<length> | <percentage>",
                Initial = "0",
                AppliesTo = "floats",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsSpecifiedForBasicShape,
                Module = CssModule[9] //CSS Shapes Module Level 1
            },
            new CssProperty
            {
                Id = 131,
                Name = "clipPath",
                Version = CssVersion.Css3,
                Value = "<clip-source> | [ <basic-shape> || <geometry-box> ] | none",
                Initial = "none",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsRectangle,
                Categories = Categories.None,
                ContentModel =
                    "Any number of the following elements, in any order: descriptive — <desc>, <title>, <metadata> animation — <animate>, <animateColor>, <animateMotion>, <animateTransform>, <set> shape — <circle>, <ellipse>, <line>, <path>, <polygon>, <polyline>, <rect> <text> <use> <script>",
                Attributes =
                    "conditional processing attributes — ‘requiredFeatures’, ‘requiredExtensions’, ‘systemLanguage’ core attributes — ‘id’, ‘xml:base’, ‘xml:lang’, ‘xml:space’ presentation attributes — alignment-baseline, baseline-shift, clip, clip-path, clip-rule, color, color-interpolation, color-interpolation-filters, color-profile, color-rendering, cursor, direction, display, dominant-baseline, enable-background, fill, fill-opacity, fill-rule, filter, flood-color, flood-opacity, font, font-family, font-size, font-size-adjust, font-stretch, font-style, font-variant, font-weight, glyph-orientation-horizontal, glyph-orientation-vertical, image-rendering, kerning, letter-spacing, lighting-color, marker, marker-end, marker-mid, marker-start, mask, opacity, overflow, pointer-events, shape-rendering, stop-color, stop-opacity, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity, stroke-width, text-anchor, text-decoration, text-rendering, unicode-bidi, visibility, word-spacing, writing-mode' ‘class’ ‘externalResourcesRequired’ ‘transform’ ‘clipPathUnits’",
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 132,
                Name = "clip-path",
                Version = CssVersion.Css3,
                Value = "<clip-source> | [ <basic-shape> || <geometry-box> ] | none",
                Initial = "none",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsRectangle,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 133,
                Name = "clip-rule",
                Version = CssVersion.Css3,
                Value = "nonzero | evenodd",
                Initial = "nonzero",
                AppliesTo = "Applies to SVG graphics elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 134,
                Name = "mask-image",
                Version = CssVersion.Css3,
                Value = "<mask-reference>#",
                Initial = "none",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 135,
                Name = "mask-mode",
                Version = CssVersion.Css3,
                Value = "<masking-mode>#",
                Initial = "auto",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 136,
                Name = "mask-repeat",
                Version = CssVersion.Css3,
                Value = "<repeat-style>#",
                Initial = "no-repeat",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 137,
                Name = "mask-position",
                Version = CssVersion.Css3,
                Value = "<position>#",
                Initial = "center",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsSpecifiedForBasicShape,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 138,
                Name = "mask-clip",
                Version = CssVersion.Css3,
                Value = "[ <geometry-box> | no-clip ]#",
                Initial = "border-box",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 139,
                Name = "mask-origin",
                Version = CssVersion.Css3,
                Value = "<geometry-box>#",
                Initial = "border-box",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 140,
                Name = "mask-size",
                Version = CssVersion.Css3,
                Value = "<bg-size>#",
                Initial = "auto",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsRepeat,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 141,
                Name = "mask-composite",
                Version = CssVersion.Css3,
                Value = "<compositing-operator>#",
                Initial = "add",
                AppliesTo =
                    "All elements. In SVG it applies to container elements without the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 142,
                Name = "mask",
                Version = CssVersion.Css3,
                Value = "<mask-layer>#",
                Initial = "see individual properties",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 143,
                Name = "mask-border-source",
                Version = CssVersion.Css3,
                Value = "none | <image>",
                Initial = "none",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 144,
                Name = "mask-border-mode",
                Version = CssVersion.Css3,
                Value = "luminance | alpha",
                Initial = "alpha",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 145,
                Name = "mask-border-slice",
                Version = CssVersion.Css3,
                Value = "[<number> | <percentage>]{14} fill?",
                Initial = "0",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 146,
                Name = "mask-border-width",
                Version = CssVersion.Css3,
                Value = "[ <length> | <percentage> | <number> | auto ]{14}",
                Initial = "auto",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 147,
                Name = "mask-border-outset",
                Version = CssVersion.Css3,
                Value = "[ <length> | <number> ]{14}",
                Initial = "0",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 148,
                Name = "mask-border-repeat",
                Version = CssVersion.Css3,
                Value = "[ stretch | repeat | round | space ]{12}",
                Initial = "stretch",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the <defs> element and all graphics elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 149,
                Name = "mask-border",
                Version = CssVersion.Css3,
                Value =
                    "<‘mask-border-source’> || <mask-border-slice>|<mask-border-width>|<mask-border-outset>|<mask-border-repeat>|<mask-border-mode>",
                Initial = "See individual properties",
                AppliesTo = "See individual properties",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 150,
                Name = "mask-type",
                Version = CssVersion.Css3,
                Value = "luminance | alpha",
                Initial = "luminance",
                AppliesTo = "mask elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 151,
                Name = "clip",
                Version = CssVersion.Css2,
                Value = "<rect()> | auto",
                Initial = "auto",
                AppliesTo = "Absolutely positioned elements.",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsTransform,
                Module = CssModule[10] //CSS Masking Module Level 1
            },
            new CssProperty
            {
                Id = 152,
                Name = "animation-name",
                Version = CssVersion.Css3,
                Value = "<single-animation-name> [‘’ <single-animation-name> ]*",
                Initial = "‘none’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 153,
                Name = "animation-duration",
                Version = CssVersion.Css3,
                Value = " <time> [ <time>]*",
                Initial = "‘0s’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 154,
                Name = "animation-timing-function",
                Version = CssVersion.Css3,
                Value = "<single-timing-function> [ ‘’ <single-timing-function> ]*",
                Initial = "‘ease’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 155,
                Name = "animation-iteration-count",
                Version = CssVersion.Css3,
                Value = "<single-animation-iteration-count>[ ‘’ <single-animation-iteration-count>]*",
                Initial = "‘1’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 156,
                Name = "animation-direction",
                Version = CssVersion.Css3,
                Value = "<single-animation-direction>[ ‘’ <single-animation-direction>]*",
                Initial = "‘normal’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 157,
                Name = "animation-play-state",
                Version = CssVersion.Css3,
                Value = "<single-animation-play-state>[ ‘’ <single-animation-play-state>]*",
                Initial = "‘running’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 158,
                Name = "animation-delay",
                Version = CssVersion.Css3,
                Value = " <time> [ <time>]*",
                Initial = "‘0s’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 159,
                Name = "animation-fill-mode",
                Version = CssVersion.Css3,
                Value = "<single-animation-fill-mode>[ ‘’ <single-animation-fill-mode>]*",
                Initial = "‘none’",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 160,
                Name = "animation",
                Version = CssVersion.Css3,
                Value = "<single-animation> [ ‘’ <single-animation> ]*",
                Initial = "see individual properties",
                AppliesTo = "all elements ::before and ::after pseudo-elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[11] //CSS Animations
            },
            new CssProperty
            {
                Id = 161,
                Name = "text-transform",
                Version = CssVersion.Css2,
                Value = "none | capitalize | uppercase | lowercase | full-width",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 162,
                Name = "white-space",
                Version = CssVersion.Css2,
                Value = "normal | pre | nowrap | pre-wrap | pre-line",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 163,
                Name = "tab-size",
                Version = CssVersion.Css3,
                Value = "<integer> | <length>",
                Initial = "8",
                AppliesTo = "block containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 164,
                Name = "line-break",
                Version = CssVersion.Css3,
                Value = "auto | loose | normal | strict",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 165,
                Name = "word-break",
                Version = CssVersion.Css3,
                Value = "normal | keep-all | break-all",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 166,
                Name = "hyphens",
                Version = CssVersion.Css3,
                Value = "none | manual | auto",
                Initial = "manual",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 167,
                Name = "overflow-wrap",
                Version = CssVersion.Css3,
                Value = "normal | break-word",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 168,
                Name = "text-align",
                Version = CssVersion.Css2,
                Value = "start | end | left | right | center | justify | match-parent | startend",
                Initial = "start",
                AppliesTo = "block containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 169,
                Name = "text-align-last",
                Version = CssVersion.Css3,
                Value = "auto | start | end | left | right | center | justify",
                Initial = "auto",
                AppliesTo = "block containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 170,
                Name = "text-justify",
                Version = CssVersion.Css3,
                Value = "auto | none | inter-word | distribute",
                Initial = "auto",
                AppliesTo = "block containers and optionally inline elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 171,
                Name = "word-spacing",
                Version = CssVersion.Css2,
                Value = "[ normal | <length> |<percentage>]",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsSpecifiedForBasicShape,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 172,
                Name = "letter-spacing",
                Version = CssVersion.Css2,
                Value = "normal | <length>",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 173,
                Name = "text-indent",
                Version = CssVersion.Css2,
                Value = "[ <length>| <percentage>] && hanging? && each-line?",
                Initial = "0",
                AppliesTo = "block containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsSpecifiedForBasicShape,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 174,
                Name = "hanging-punctuation",
                Version = CssVersion.Css3,
                Value = "none | [ first || [ force-end | allow-end ] || last ]",
                Initial = "none",
                AppliesTo = "inline elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 175,
                Name = "orphans",
                Version = CssVersion.Css2,
                Value = "<integer>",
                Initial = "2",
                AppliesTo = "block containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[13] //CSS Fragmentation Module Level 3
            },
            new CssProperty
            {
                Id = 176,
                Name = "box-decoration-break",
                Version = CssVersion.Css3,
                Value = "slice | clone",
                Initial = "slice",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[13] //CSS Fragmentation Module Level 3
            },
            new CssProperty
            {
                Id = 177,
                Name = "transform",
                Version = CssVersion.Css3,
                Value = "none | <transform-list>",
                Initial = "none",
                AppliesTo = "transformable elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.YesBetweenGrids,
                Module = CssModule[14] //CSS Transforms Module Level 1
            },
            new CssProperty
            {
                Id = 178,
                Name = "transform-origin",
                Version = CssVersion.Css3,
                Value = "[ left | center | right | top | bottom | <percentage> | <length> ]",
                Initial = "50% 50%",
                AppliesTo = "transformable elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsTwoValues,
                Module = CssModule[14], //CSS Transforms Module Level 1
            },
            new CssProperty
            {
                Id = 179,
                Name = "transform-style",
                Version = CssVersion.Css3,
                Value = "flat | preserve-3d",
                Initial = "flat",
                AppliesTo = "transformable elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[14] //CSS Transforms Module Level 1
            },
            new CssProperty
            {
                Id = 180,
                Name = "perspective",
                Version = CssVersion.Css3,
                Value = "none | <length>",
                Initial = "none",
                AppliesTo = "transformable elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[14] //CSS Transforms Module Level 1
            },
            new CssProperty
            {
                Id = 181,
                Name = "perspective-origin",
                Version = CssVersion.Css3,
                Value = "[ left | center | right | top | bottom | <percentage> | <length> ]",
                Initial = "50% 50%",
                AppliesTo = "transformable elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsTwoValues,
                Module = CssModule[14] //CSS Transforms Module Level 1
            },
            new CssProperty
            {
                Id = 182,
                Name = "backface-visibility",
                Version = CssVersion.Css3,
                Value = "visible | hidden",
                Initial = "visible",
                AppliesTo = "transformable elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[14] //CSS Transforms Module Level 1
            },
            new CssProperty
            {
                Id = 183,
                Name = "transition-property",
                Version = CssVersion.Css3,
                Value = " none | <single-transition-property>[ ‘’ <single-transition-property>]*",
                Initial = " all",
                AppliesTo = " all elements :before and :after pseudo elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[15] //CSS Transitions
            },
            new CssProperty
            {
                Id = 184,
                Name = "transition-duration",
                Version = CssVersion.Css3,
                Value = " <time> [ <time>]*",
                Initial = " 0s",
                AppliesTo = " all elements :before and :after pseudo elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[15] //CSS Transitions
            },
            new CssProperty
            {
                Id = 185,
                Name = "transition-timing-function",
                Version = CssVersion.Css3,
                Value = " <single-transition-timing-function>[ ‘’ <single-transition-timing-function>]*",
                Initial = " ease",
                AppliesTo = " all elements :before and :after pseudo elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[15] //CSS Transitions
            },
            new CssProperty
            {
                Id = 186,
                Name = "transition-delay",
                Version = CssVersion.Css3,
                Value = " <time> [ <time>]*",
                Initial = " 0s",
                AppliesTo = " all elements :before and :after pseudo elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[15] //CSS Transitions
            },
            new CssProperty
            {
                Id = 187,
                Name = "transition",
                Version = CssVersion.Css3,
                Value = " <single-transition> [‘’ <single-transition> ]*",
                Initial = " see individual properties",
                AppliesTo = " all elements :before and :after pseudo elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[15] //CSS Transitions
            },
            new CssProperty
            {
                Id = 188,
                Name = "--*",
                Version = CssVersion.Css3,
                Value = "<any-value>",
                Initial = "(nothing see prose)",
                AppliesTo = "all elements",
                Inherited = true,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[16] //CSS Custom Properties for Cascading Variables Module Level 1
            },
            new CssProperty
            {
                Id = 189,
                Name = "mix-blend-mode",
                Version = CssVersion.Css3,
                Value = "<blend-mode>",
                Initial = "normal",
                AppliesTo = "All elements.",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[17] //Compositing and Blending Level 1
            },
            new CssProperty
            {
                Id = 190,
                Name = "isolation",
                Version = CssVersion.Css3,
                Value = "<isolation-mode>",
                Initial = "auto",
                AppliesTo = "All elements.",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[17] //Compositing and Blending Level 1
            },
            new CssProperty
            {
                Id = 191,
                Name = "background-blend-mode",
                Version = CssVersion.Css3,
                Value = "<blend-mode>",
                Initial = "normal",
                AppliesTo = "All HTML elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[17] //Compositing and Blending Level 1
            },
            new CssProperty
            {
                Id = 192,
                Name = "box-sizing",
                Version = CssVersion.Css3,
                Value = "content-box |padding-box |border-box",
                Initial = "content-box",
                AppliesTo = "all elements that accept width or height",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 193,
                Name = "outline",
                Version = CssVersion.Css2,
                Value = "[ <outline-color> || <outline-style> ||<outline-width> ]",
                Initial = "see individual properties",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 194,
                Name = "outline-style",
                Version = CssVersion.Css2,
                Value = "auto | <‘border-style’>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 195,
                Name = "outline-color",
                Version = CssVersion.Css2,
                Value = "<color> | invert",
                Initial = "invert",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 196,
                Name = "outline-width",
                Version = CssVersion.Css2,
                Value = "<‘border-width’>",
                Initial = "medium",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 197,
                Name = "outline-offset",
                Version = CssVersion.Css2,
                Value = "<length>",
                Initial = "0",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsLength,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 198,
                Name = "resize",
                Version = CssVersion.Css3,
                Value = "none | both | horizontal | vertical",
                Initial = "none",
                AppliesTo = "elements with overflow other than visible",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 199,
                Name = "text-overflow",
                Version = CssVersion.Css3,
                Value = " [clip |ellipsis |<string>]{12}",
                Initial = "clip",
                AppliesTo = "block containers",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 200,
                Name = "cursor",
                Version = CssVersion.Css2,
                Value =
                    "[ [<Url> [<x> <y>]?]* [ auto | default | none | context-menu | help | pointer | progress | wait |cell | crosshair | text | vertical-text |alias | copy | move | no-drop | not-allowed | grab | grabbing |e-resize | n-resize | ne-resize | nw-resize | s-resize | se-resize | sw-resize | w-resize | ew-resize | ns-resize | " +
                    "nesw-resize | nwse-resize | col-resize | row-resize | all-scroll| zoom-in | zoom-out] ] ",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual | MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 201,
                Name = "caret-color",
                Version = CssVersion.Css3,
                Value = "auto | <color>",
                Initial = "auto",
                AppliesTo = "elements that accept input",
                Inherited = true,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.AsColor,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 202,
                Name = "nav-up",
                Version = CssVersion.Css3,
                Value = "auto | <id> [ current | root | <target-name> ]? ",
                Initial = "auto",
                AppliesTo = "all enabled elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 203,
                Name = "nav-down",
                Version = CssVersion.Css3,
                Value = "auto | <id> [ current | root | <target-name> ]? ",
                Initial = "auto",
                AppliesTo = "all enabled elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 204,
                Name = "will-change",
                Version = CssVersion.Css3,
                Value = "auto | <animateable-feature>#",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[19] //CSS Will Change Module Level 1
            },
            new CssProperty
            {
                Id = 205,
                Name = "justify-self",
                Version = CssVersion.Css3,
                Value = "auto | stretch | <baseline-position> | [ <overflow-position>? && <item-position> ]",
                Initial = "auto",
                AppliesTo = "block-level boxes absolutely-positioned boxes and grid items",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[20] //CSS Box Alignment Module Level 3
            },
            new CssProperty
            {
                Id = 206,
                Name = "justify-items",
                Version = CssVersion.Css3,
                Value =
                    "auto | stretch | <baseline-position> | [ <item-position> && <overflow-position>? ] | [ legacy && [ left | right | center ] ]",
                Initial = "auto",
                AppliesTo = "block containers flex containers and grid containers",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[20] //CSS Box Alignment Module Level 3
            },
            new CssProperty
            {
                Id = 207,
                Name = "grid-template-columns",
                Version = CssVersion.Css3,
                Value = "none | <track-list> | subgrid <line-name-list>? |auto | <col-width>+",
                Initial = "auto",
                AppliesTo = "block container elements and grid container elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No | CssAnimatable.YesBetweenGrids,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 208,
                Name = "grid-template-rows",
                Version = CssVersion.Css3,
                Value = "none | <track-list> | subgrid <line-name-list>? |auto | <row-height>+",
                Initial = "auto",
                AppliesTo = "block container elements and grid container elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.YesBetweenGrids,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 209,
                Name = "grid-template-areas",
                Version = CssVersion.Css3,
                Value = "none | <string>+ ",
                Initial = "none",
                AppliesTo = "block container elements and grid container elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 210,
                Name = "grid-template",
                Version = CssVersion.Css3,
                Value =
                    "none | subgrid | <‘grid-template-columns’> <‘grid-template-rows’> <track-list> <line-names> <string> <track-size> <line-names>",
                Initial = "see individual properties ",
                AppliesTo = "grid containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 211,
                Name = "grid-auto-columns",
                Version = CssVersion.Css3,
                Value = "<track-size> ",
                Initial = "auto ",
                AppliesTo = "grid containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 212,
                Name = "grid-auto-rows",
                Version = CssVersion.Css3,
                Value = "<track-size> ",
                Initial = "auto ",
                AppliesTo = "grid containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 213,
                Name = "grid-auto-flow",
                Version = CssVersion.Css3,
                Value = "[ row | column ] || dense ",
                Initial = "row ",
                AppliesTo = "grid containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 214,
                Name = "grid",
                Version = CssVersion.Css3,
                Value =
                    "<‘grid-template’> | [ <‘grid-auto-flow’> [ <‘grid-auto-columns’> [ / <‘grid-auto-rows’> ]? ]? ] ",
                Initial = "see individual properties ",
                AppliesTo = "grid containers ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 215,
                Name = "grid-row-start",
                Version = CssVersion.Css3,
                Value = "<grid-line> ",
                Initial = "auto ",
                AppliesTo = "grid items and absolutely-positioned boxes whose containing block is a grid container ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 216,
                Name = "grid-column-start",
                Version = CssVersion.Css3,
                Value = "<grid-line> ",
                Initial = "auto ",
                AppliesTo = "grid items and absolutely-positioned boxes whose containing block is a grid container ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 217,
                Name = "grid-row-end",
                Version = CssVersion.Css3,
                Value = "<grid-line> ",
                Initial = "auto ",
                AppliesTo = "grid items and absolutely-positioned boxes whose containing block is a grid container ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 218,
                Name = "grid-column-end",
                Version = CssVersion.Css3,
                Value = "<grid-line> ",
                Initial = "auto ",
                AppliesTo = "grid items and absolutely-positioned boxes whose containing block is a grid container ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 219,
                Name = "grid-row",
                Version = CssVersion.Css3,
                Value = "<grid-line> [ / <grid-line> ]? ",
                Initial = "see individual properties ",
                AppliesTo = "grid items and absolutely-positioned boxes whose containing block is a grid container ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 220,
                Name = "grid-area",
                Version = CssVersion.Css3,
                Value = "<grid-line> [ / <grid-line> ]{03} ",
                Initial = "see individual properties ",
                AppliesTo = "grid items and absolutely-positioned boxes whose containing block is a grid container ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 221,
                Name = "size",
                Version = CssVersion.Css3,
                Value = "<length>{12} | auto | [ <page-size> || [ portrait |landscape] ]",
                Initial = "auto",
                AppliesTo = "page context",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[22] //CSS Paged Media Module Level 3
            },
            new CssProperty
            {
                Id = 222,
                Name = "page",
                Version = CssVersion.Css3,
                Value = "auto | <identifier>",
                Initial = "auto",
                AppliesTo = "boxes that create class 1 breakpoints",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[22] //CSS Paged Media Module Level 3
            },
            new CssProperty
            {
                Id = 223,
                Name = "max-width",
                Version = CssVersion.Css2,
                Value =
                    "<viewport-length> | ‘fit-content’|<length> | <percentage> | auto  | fill-available | max-content | min-content | fit-content",
                Initial = "auto",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 224,
                Name = "width",
                Version = CssVersion.Css2,
                Value =
                    "<viewport-length>{12}|<length> | <percentage> | auto  | fill-available | max-content | min-content | fit-content",
                Initial = "See individual properties",
                AppliesTo = "all elements but non-replaced inline elements table rows and rowgroups",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 225,
                Name = "height",
                Version = CssVersion.Css2,
                Value =
                    "<viewport-length>{12} | ‘fill-available’ | ‘max-content’ | ‘min-content’ | ‘fit-content’|<length> | <percentage> | auto",
                Initial = "auto",
                AppliesTo = "all elements but non-replaced inline elements table columns andcolumn groups",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 226,
                Name = "zoom",
                Version = CssVersion.Css3,
                Value = "auto | <number> | <percentage>",
                Initial = "auto",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 227,
                Name = "min-zoom",
                Version = CssVersion.Css3,
                Value = "auto | <number> | <percentage>",
                Initial = "auto",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 228,
                Name = "max-zoom",
                Version = CssVersion.Css3,
                Value = "auto | <number> | <percentage>",
                Initial = "auto",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 229,
                Name = "user-zoom",
                Version = CssVersion.Css3,
                Value = "zoom | fixed",
                Initial = "zoom",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 230,
                Name = "orientation",
                Version = CssVersion.Css3,
                Value = "auto | portrait | landscape",
                Initial = "auto",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 231,
                Name = "resolution",
                Version = CssVersion.Css3,
                Value = "auto | device | <resolution>",
                Initial = "auto",
                AppliesTo = "N/A",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 232,
                Name = "wrap-flow",
                Version = CssVersion.Css3,
                Value = "auto | both | start | end | minimum | maximum | clear",
                Initial = "auto",
                AppliesTo = "block-level elements.",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[24] //CSS Exclusions Module Level 1
            },
            new CssProperty
            {
                Id = 233,
                Name = "wrap-through",
                Version = CssVersion.Css3,
                Value = "wrap | none",
                Initial = "wrap",
                AppliesTo = "block-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[24] //CSS Exclusions Module Level 1
            },
            new CssProperty
            {
                Id = 234,
                Name = "string-set",
                Version = CssVersion.Css3,
                Value = "[[ <custom-ident> <content-list>] [ <custom-ident> <content-list>]* ] | none",
                Initial = "none",
                AppliesTo = "all elements but not pseudo-elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[25] //CSS Generated Content for Paged Media Module
            },
            new CssProperty
            {
                Id = 235,
                Name = "footnote-display",
                Version = CssVersion.Css3,
                Value = "block | inline | compact",
                Initial = "block",
                AppliesTo = "elements",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[25] //CSS Generated Content for Paged Media Module
            },
            new CssProperty
            {
                Id = 236,
                Name = "footnote-policy",
                Version = CssVersion.Css3,
                Value = "auto | line | block",
                Initial = "auto",
                AppliesTo = "elements",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[25] //CSS Generated Content for Paged Media Module
            },
            new CssProperty
            {
                Id = 237,
                Name = "bookmark-level",
                Version = CssVersion.Css3,
                Value = "none | <integer>",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[25] //CSS Generated Content for Paged Media Module
            },
            new CssProperty
            {
                Id = 238,
                Name = "bookmark-label",
                Version = CssVersion.Css3,
                Value = "<content-list> | none",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[25] //CSS Generated Content for Paged Media Module
            },
            new CssProperty
            {
                Id = 239,
                Name = "bookmark-state",
                Version = CssVersion.Css3,
                Value = "open | closed",
                Initial = "open",
                AppliesTo = "block-level elements",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[25] //CSS Generated Content for Paged Media Module
            },
            new CssProperty
            {
                Id = 240,
                Name = "running",
                Version = CssVersion.Css3,
                Value = "<custom-ident>",
                Initial = "none",
                AppliesTo = "elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[25] //CSS Generated Content for Paged Media Module
            },
            new CssProperty
            {
                Id = 241,
                Name = "flood-color",
                Version = CssVersion.Css3,
                Value = "<color>",
                Initial = "black",
                AppliesTo = "feFlood and feDropShadow elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[26] //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 242,
                Name = "flood-opacity",
                Version = CssVersion.Css3,
                Value = "<number> | <percentage>",
                Initial = "1",
                AppliesTo = "feFlood and feDropShadow elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[26] //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 243,
                Name = "color-interpolation-filters",
                Version = CssVersion.Css3,
                Value = "auto | sRGB | linearRGB",
                Initial = "auto",
                AppliesTo = "All filter primitives",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[26] //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 244,
                Name = "lighting-color",
                Version = CssVersion.Css3,
                Value = "<color>",
                Initial = "white",
                AppliesTo = "feDiffuseLighting and feSpecularLighting elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[26] //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 245,
                Name = "flow",
                Version = CssVersion.Css3,
                Value = "auto | <identifier> | <string> | ‘*’ | same",
                Initial = "auto",
                AppliesTo = "elements that have a grid ancestor andwhose ‘position’ is ‘static’ or ‘relative’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[39] //CSS Template Layout Module
            },
            new CssProperty
            {
                Id = 246,
                Name = "chains",
                Version = CssVersion.Css3,
                Value = "none | <identifier>+ [ <identifier>+ ]*",
                Initial = "none",
                AppliesTo = "grid elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[39] //CSS Template Layout Module
            },
            new CssProperty
            {
                Id = 247,
                Name = "line-grid",
                Version = CssVersion.Css3,
                Value = "match-parent | create",
                Initial = "match-parent",
                AppliesTo = "block containers",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[27] //CSS Line Grid Module Level 1
            },
            new CssProperty
            {
                Id = 248,
                Name = "line-snap",
                Version = CssVersion.Css3,
                Value = "none | baseline | contain",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[27] //CSS Line Grid Module Level 1
            },
            new CssProperty
            {
                Id = 249,
                Name = "box-snap",
                Version = CssVersion.Css3,
                Value = "none | block-start | block-end | center | first-baseline | last-baseline",
                Initial = "none",
                AppliesTo = "block-level boxes and internal table elements except table cells",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[27] //CSS Line Grid Module Level 1
            },
            new CssProperty
            {
                Id = 250,
                Name = "list-style-image",
                Version = CssVersion.Css2,
                Value = "<image> | none",
                Initial = "none",
                AppliesTo = "list items",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3"
            },
            new CssProperty
            {
                Id = 251,
                Name = "list-style-type",
                Version = CssVersion.Css2,
                Value = "<counter-style> | <string> | none",
                Initial = "disc",
                AppliesTo = "list items",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3
            },
            new CssProperty
            {
                Id = 252,
                Name = "list-style-position",
                Version = CssVersion.Css2,
                Value = "inside | outside",
                Initial = "outside",
                AppliesTo = "list items",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3"
            },
            new CssProperty
            {
                Id = 253,
                Name = "list-style",
                Version = CssVersion.Css2,
                Value = "<‘list-style-type’> || <‘list-style-position’> || <‘list-style-image’>",
                Initial = "see individual properties",
                AppliesTo = "list items",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3
            },
            new CssProperty
            {
                Id = 254,
                Name = "marker-side",
                Version = CssVersion.Css3,
                Value = "list-item | list-container",
                Initial = "list-item",
                AppliesTo = "list items",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3
            },
            new CssProperty
            {
                Id = 255,
                Name = "counter-reset",
                Version = CssVersion.Css3 | CssVersion.Css2,
                Value = "[ <custom-ident> <integer>? ]+ | none",
                Initial = "none",
                AppliesTo =
                    "all elements ::before ::after ::alternate ::marker ::line-markermargin areas @footnote areas and page context",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3
            },
            new CssProperty
            {
                Id = 256,
                Name = "counter-set",
                Version = CssVersion.Css3,
                Value = "[ <custom-ident> <integer>? ]+ | none",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3
            },
            new CssProperty
            {
                Id = 257,
                Name = "counter-increment",
                Version = CssVersion.Css2 | CssVersion.Css3,
                Value = "[ <custom-ident> <integer>? ]+ | none",
                Initial = "none",
                AppliesTo =
                    "all elements ::before ::after ::alternate ::marker ::line-markermargin areas @footnote areas and page context",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[40] //CSS Lists and Counters Module Level 3
            },
            new CssProperty
            {
                Id = 258,
                Name = "position",
                Version = CssVersion.Css2,
                Value = "static | relative | absolute | sticky | center | page | fixed ",
                Initial = "static",
                AppliesTo = "all elements except table-column-group and table-column ",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 259,
                Name = "top",
                Version = CssVersion.Css2,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 260,
                Name = "right",
                Version = CssVersion.Css2,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 261,
                Name = "bottom",
                Version = CssVersion.Css2,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 262,
                Name = "left",
                Version = CssVersion.Css2,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 263,
                Name = "offset-before",
                Version = CssVersion.Css3,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 264,
                Name = "offset-end",
                Version = CssVersion.Css3,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 265,
                Name = "offset-after",
                Version = CssVersion.Css3,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 266,
                Name = "offset-start",
                Version = CssVersion.Css3,
                Value = "auto | <length> | <percentage> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.LengthOrPercentage,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 267,
                Name = "z-index",
                Version = CssVersion.Css2,
                Value = "auto | <integer> ",
                Initial = "auto ",
                AppliesTo = "positioned elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsInteger,
                Module = CssModule[28] //CSS Positioned Layout Module Level 3
            },
            new CssProperty
            {
                Id = 268,
                Name = "flow-into",
                Version = CssVersion.Css3,
                Value = "none | <ident> [element|content]?",
                Initial = "none",
                AppliesTo =
                    "All elements but not pseudo-elements such as ::first-line ::first-letter ::before or ::after.",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[42] //CSS Regions Module Level 1
            },
            new CssProperty
            {
                Id = 269,
                Name = "flow-from",
                Version = CssVersion.Css3,
                Value = "<ident> | none | inherit",
                Initial = "none",
                AppliesTo = "Non-replaced block containers.",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[42] //CSS Regions Module Level 1
            },
            new CssProperty
            {
                Id = 270,
                Name = "region-fragment",
                Version = CssVersion.Css3,
                Value = "auto | break",
                Initial = "auto",
                AppliesTo = "CSS Regions",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[42] //CSS Regions Module Level 1
            },
            new CssProperty
            {
                Id = 271,
                Name = "ruby-position",
                Version = CssVersion.Css3,
                Value = "[ over | under | inter-character ] && [ right | left ]",
                Initial = "over right",
                AppliesTo = "ruby annotation containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[29] //CSS Ruby Layout Module Level 1
            },
            new CssProperty
            {
                Id = 272,
                Name = "ruby-merge",
                Version = CssVersion.Css3,
                Value = "separate | collapse | auto",
                Initial = "separate",
                AppliesTo = "ruby annotation containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[29] //CSS Ruby Layout Module Level 1
            },
            new CssProperty
            {
                Id = 273,
                Name = "ruby-align",
                Version = CssVersion.Css3,
                Value = "start | center | space-between | space-around",
                Initial = "space-around",
                AppliesTo = "ruby bases ruby annotations ruby base containers ruby annotation containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[29] //CSS Ruby Layout Module Level 1
            },
            new CssProperty
            {
                Id = 274,
                Name = "overflow",
                Version = CssVersion.Css2,
                Value =
                    "visible | hidden | scroll | auto | paged-x | paged-y |paged-x-controls | paged-y-controls | fragments ",
                Initial = "see individual properties",
                AppliesTo =
                    "block containers and non-replaced block-level elements and non-replaced ‘inline-block’ elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[30] //CSS Overflow Module Level 3
            },
            new CssProperty
            {
                Id = 275,
                Name = "max-lines",
                Version = CssVersion.Css3,
                Value = "none | <integer>",
                Initial = "none",
                AppliesTo = "fragment boxes",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.AsInteger,
                Module = CssModule[30] //CSS Overflow Module Level 3
            },
            new CssProperty
            {
                Id = 276,
                Name = "display-inside",
                Version = CssVersion.Css3,
                Value = "auto | block | table | flex | grid | ruby",
                Initial = "auto",
                AppliesTo = "all elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[31] //CSS Display Module Level 3
            },
            new CssProperty
            {
                Id = 277,
                Name = "display-outside",
                Version = CssVersion.Css3,
                Value =
                    "block-level | inline-level | run-in | contents | none | table-row-group | table-header-group | table-footer-group | table-row | table-cell | table-column-group | table-column |" +
                    " table-caption | ruby-base | ruby-text | ruby-base-container | ruby-text-container",
                Initial = "inline-level",
                AppliesTo = "all elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[31] //CSS Display Module Level 3
            },
            new CssProperty
            {
                Id = 278,
                Name = "display-list",
                Version = CssVersion.Css3,
                Value = "none | list-item",
                Initial = "none",
                AppliesTo = "all elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[31] //CSS Display Module Level 3
            },
            new CssProperty
            {
                Id = 279,
                Name = "box-suppress",
                Version = CssVersion.Css3,
                Value = "show | discard | hide",
                Initial = "show",
                AppliesTo = "all elements",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[31] //CSS Display Module Level 3
            },
            new CssProperty
            {
                Id = 280,
                Name = "motion-path",
                Version = CssVersion.Css3,
                Value = "<Url> | [ <basic-shape> | <path()> ] || <geometry-box> | none ",
                Initial = "none ",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the defs element and all graphics elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[32] //Motion Path Module Level 1
            },
            new CssProperty
            {
                Id = 281,
                Name = "motion-offset",
                Version = CssVersion.Css3,
                Value = "<length> | <percentage> ",
                Initial = "0 ",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the defs element and all graphics elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[32] //Motion Path Module Level 1
            },
            new CssProperty
            {
                Id = 282,
                Name = "motion-rotation",
                Version = CssVersion.Css3,
                Value = "[ auto | reverse ] && <angle> ",
                Initial = "auto ",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the defs element and all graphics elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[32] //Motion Path Module Level 1
            },
            new CssProperty
            {
                Id = 283,
                Name = "motion",
                Version = CssVersion.Css3,
                Value = "<motion-path> && <motion-offset> && <motion-rotation> ",
                Initial = "see individual properties ",
                AppliesTo =
                    "All elements. In SVG it applies to container elements excluding the defs element and all graphics elements ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[32] //Motion Path Module Level 1
            },
            new CssProperty
            {
                Id = 284,
                Name = "scroll-snap-type",
                Version = CssVersion.Css3,
                Value = "none | mandatory | proximity ",
                Initial = "none ",
                AppliesTo = "scroll containers ",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[33] //CSS Scroll Snap Points Module Level 1
            },
            new CssProperty
            {
                Id = 285,
                Name = "scroll-snap-points-x",
                Version = CssVersion.Css3,
                Value = "none | repeat(<length>) ",
                Initial = "none ",
                AppliesTo = "scroll containers ",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[33] //CSS Scroll Snap Points Module Level 1
            },
            new CssProperty
            {
                Id = 286,
                Name = "scroll-snap-points-y",
                Version = CssVersion.Css3,
                Value = "none | repeat(<length>) ",
                Initial = "none ",
                AppliesTo = "scroll containers ",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[33] //CSS Scroll Snap Points Module Level 1
            },
            new CssProperty
            {
                Id = 287,
                Name = "scroll-snap-destination",
                Version = CssVersion.Css3,
                Value = "<position> ",
                Initial = "0px 0px ",
                AppliesTo = "scroll containers ",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[33] //CSS Scroll Snap Points Module Level 1
            },
            new CssProperty
            {
                Id = 288,
                Name = "scroll-snap-coordinate",
                Version = CssVersion.Css3,
                Value = "none | <position># ",
                Initial = "none ",
                AppliesTo = "all elements ",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.Yes,
                Module = CssModule[33] //CSS Scroll Snap Points Module Level 1
            },
            new CssProperty
            {
                Id = 289,
                Name = "padding",
                Version = CssVersion.Css2,
                Value = "[ <length> |<percentage> ]{14}",
                Initial = "(see individual properties)",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 290,
                Name = "padding-top",
                Version = CssVersion.Css2,
                Value = "[ <length> |<percentage> ]",
                Initial = "0",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 291,
                Name = "padding-right",
                Version = CssVersion.Css2,
                Value = "[ <length> |<percentage> ]",
                Initial = "0",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 292,
                Name = "padding-bottom",
                Version = CssVersion.Css2,
                Value = "[ <length> |<percentage> ]",
                Initial = "0",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 293,
                Name = "padding-left",
                Version = CssVersion.Css2,
                Value = "[ <length> |<percentage> ]",
                Initial = "0",
                AppliesTo = "all elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 294,
                Name = "margin-top",
                Version = CssVersion.Css2,
                Value = "<length> |<percentage> | auto",
                Initial = "0",
                AppliesTo = "see text",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 295,
                Name = "margin-right",
                Version = CssVersion.Css2,
                Value = "<length> |<percentage> | auto",
                Initial = "0",
                AppliesTo = "see text",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 296,
                Name = "margin-bottom",
                Version = CssVersion.Css2,
                Value = "<length> |<percentage> | auto",
                Initial = "0",
                AppliesTo = "see text",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 297,
                Name = "margin-left",
                Version = CssVersion.Css2,
                Value = "<length> |<percentage> | auto",
                Initial = "0",
                AppliesTo = "see text",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 298,
                Name = "margin",
                Version = CssVersion.Css2,
                Value = "[ <length> |<percentage> | auto ]{14}",
                Initial = "(see individual properties)",
                AppliesTo = "see text",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 299,
                Name = "max-height",
                Version = CssVersion.Css2,
                Value =
                    "<length> |<percentage> | none | ‘fill-available’ | ‘max-content’ | ‘min-content’ | ‘fit-content’ | <viewport-length>",
                Initial = "auto",
                AppliesTo = "all elements but non-replaced inline elements table rows and rowgroups",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[23] //CSS Device Adaptation
            },
            new CssProperty
            {
                Id = 300,
                Name = "float",
                Version = CssVersion.Css2,
                Value = "left | right | none | <page-floats>",
                Initial = "none",
                AppliesTo = "all but see 9.7",
                Inherited = false,
                Media = MediaGroups.Visual | MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 301,
                Name = "clear",
                Version = CssVersion.Css2,
                Value = "none | left | right | both",
                Initial = "none",
                AppliesTo = "block-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 302,
                Name = "overflow-x",
                Version = CssVersion.Css3,
                Value =
                    "hidden | no-display | no-content |visible | hidden | scroll | auto | paged-x | paged-y |paged-x-controls | paged-y-controls | fragments",
                Initial = "visible",
                AppliesTo = "non-replaced block-levelelements and non-replaced ‘inline-block’ elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 303,
                Name = "overflow-y",
                Version = CssVersion.Css3,
                Value =
                    "hidden | no-display | no-content |visible | hidden | scroll | auto | paged-x | paged-y |paged-x-controls | paged-y-controls | fragments",
                Initial = "visible",
                AppliesTo = "non-replaced block-levelelements and non-replaced ‘inline-block’ elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 304,
                Name = "overflow-style",
                Version = CssVersion.Css3,
                Value = "auto | [scrollbar | panner | move | marquee] [ [scrollbar | panner| move | marquee]]*",
                Initial = "auto",
                AppliesTo = "same as ‘overflow’",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 305,
                Name = "marquee-style",
                Version = CssVersion.Css3,
                Value = "scroll | slide | alternate",
                Initial = "scroll",
                AppliesTo = "same as ‘overflow’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 306,
                Name = "marquee-loop",
                Version = CssVersion.Css3,
                Value = "<non-negative-integer> | infinite",
                Initial = "1",
                AppliesTo = "same as ‘overflow’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 307,
                Name = "marquee-direction",
                Version = CssVersion.Css3,
                Value = "forward | reverse",
                Initial = "reverse",
                AppliesTo = "same as ‘overflow’",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 308,
                Name = "marquee-speed",
                Version = CssVersion.Css3,
                Value = "slow | normal | fast",
                Initial = "normal",
                AppliesTo = "same as ‘overflow’",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 309,
                Name = "visibility",
                Version = CssVersion.Css2,
                Value = "visible | hidden | collapse",
                Initial = " visible",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 310,
                Name = "rotation",
                Version = CssVersion.Css3,
                Value = "<angle>",
                Initial = "0",
                AppliesTo = "block-level elements inline-table andinline-block",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model
            },
            new CssProperty
            {
                Id = 311,
                Name = "rotation-point",
                Version = CssVersion.Css3,
                Value = "<bg-position>",
                Initial = "50% 50%",
                AppliesTo = "block-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[34] //CSS basic box model"
            },
            new CssProperty
            {
                Id = 312,
                Name = "move-to",
                Version = CssVersion.Css3,
                Value = "normal | here | <identifier>",
                Initial = "normal",
                AppliesTo = "all elements ::before ::after and ::alternate",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[35] //CSS3 Generated and Replaced Content Module
            },
            new CssProperty
            {
                Id = 313,
                Name = "quotes",
                Version = CssVersion.Css2,
                Value = "foo | bar",
                Initial = "text",
                AppliesTo =
                    "all elements ::before ::after ::alternate ::marker ::line-markermargin areas and @footnote areas",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[35] //CSS3 Generated and Replaced Content Module
            },
            new CssProperty
            {
                Id = 314,
                Name = "page-policy",
                Version = CssVersion.Css3,
                Value = "start | first | last",
                Initial = "start",
                AppliesTo = "@counter and @string blocks",
                Inherited = false,
                Media = MediaGroups.Paged,
                Animatable = CssAnimatable.No,
                Module = CssModule[35] //CSS3 Generated and Replaced Content Module
            },
            new CssProperty
            {
                Id = 315,
                Name = "content",
                Version = CssVersion.Css3,
                Value = "[ <uri> '' ]* [ normal | none | inhibit | <content-list> ]",
                Initial = "normal",
                AppliesTo =
                    "all elements ::before ::after ::alternate ::marker ::line-markermargin areas and @footnote areas",
                Inherited = false,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[35] //CSS3 Generated and Replaced Content Module
            },
            new CssProperty
            {
                Id = 316,
                Name = "crop",
                Version = CssVersion.Css3,
                Value = "<shape> | auto",
                Initial = "auto",
                AppliesTo = "replaced elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[35] //CSS3 Generated and Replaced Content Module
            },
            new CssProperty
            {
                Id = 317,
                Name = "text-height",
                Version = CssVersion.Css3,
                Value = "auto | font-size | text-size | max-size",
                Initial = "auto",
                AppliesTo = "inline elements and parents of element with display:ruby-text",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 318,
                Name = "line-height",
                Version = CssVersion.Css2,
                Value = "normal |<number> |<length> |<percentage> | none",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 319,
                Name = "line-stacking-strategy",
                Version = CssVersion.Css3,
                Value = "inline-line-height | block-line-height | max-height | grid-height",
                Initial = "inline-line-height",
                AppliesTo = "block-level elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 320,
                Name = "line-stacking-ruby",
                Version = CssVersion.Css3,
                Value = "exclude-ruby | include-ruby",
                Initial = "exclude-ruby",
                AppliesTo = "block-level elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 321,
                Name = "line-stacking-shift",
                Version = CssVersion.Css3,
                Value = "consider-shifts | disregard-shifts",
                Initial = "consider-shifts",
                AppliesTo = "block-level elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 322,
                Name = "line-stacking",
                Version = CssVersion.Css3,
                Value = "<'line-stacking-strategy'> || <'line-stacking-ruby'> || <'line-stacking-shift'>",
                Initial = "see individual properties",
                AppliesTo = "block-level elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 323,
                Name = "dominant-baseline",
                Version = CssVersion.Css3,
                Value =
                    "auto |use-script|no-change|reset-size|alphabetic|hanging|ideographic|mathematical|central|middle|text-after-edge|text-before-edge",
                Initial = "auto",
                AppliesTo = "inline-level elements (but see prose)",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 324,
                Name = "alignment-baseline",
                Version = CssVersion.Css3,
                Value =
                    "baseline|use-script|before-edge|text-before-edge|after-edge|central|middle|ideographic|alphabetic|hanging|mathematical",
                Initial = "baseline",
                AppliesTo = "inline-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 325,
                Name = "alignment-adjust",
                Version = CssVersion.Css3,
                Value =
                    "auto |baseline|before-edge|text-before-edge|middle|central|after-edge|text-after-edge|ideographic|alphabetic|hanging|mathematical",
                Initial = "auto",
                AppliesTo = "inline-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 326,
                Name = "baseline-shift",
                Version = CssVersion.Css3,
                Value = "baseline | sub | super | <percentage> | <length>",
                Initial = "baseline",
                AppliesTo = "inline-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 327,
                Name = "vertical-align",
                Version = CssVersion.Css2,
                Value =
                    "auto | use-script | baseline | sub | super | top | text-top | central |middle | bottom | text-bottom | <percentage> | <length>",
                Initial = "not defined for shorthand properties",
                AppliesTo = "inline-level and 'table-cell' elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 328,
                Name = "inline-box-align",
                Version = CssVersion.Css3,
                Value = "initial | last | <integer>",
                Initial = "last",
                AppliesTo = "inline-block-level elements",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 329,
                Name = "drop-initial-value",
                Version = CssVersion.Css3,
                Value = "initial | <integer>",
                Initial = "initial",
                AppliesTo = "::first-letter pseudo element",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 330,
                Name = "drop-initial-size",
                Version = CssVersion.Css3,
                Value = "auto | <line> | <length> | <percentage>",
                Initial = "auto",
                AppliesTo = "::first-letter pseudo element",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 331,
                Name = "drop-initial-after-align",
                Version = CssVersion.Css3,
                Value = "<'alignment-baseline'>",
                Initial = "baseline",
                AppliesTo = "::first-letter pseudo element",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 332,
                Name = "drop-initial-after-adjust",
                Version = CssVersion.Css3,
                Value =
                    "central | middle | after-edge | text-after-edge | ideographic |alphabetic | mathematical | <percentage> | <length>",
                Initial = "text-after-edge",
                AppliesTo = "::first-letter pseudo element",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 333,
                Name = "drop-initial-before-align",
                Version = CssVersion.Css3,
                Value = "caps-height | <'alignment-baseline'>",
                Initial = "caps-height",
                AppliesTo = "::first-letter pseudo element",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 334,
                Name = "drop-initial-before-adjust",
                Version = CssVersion.Css3,
                Value =
                    "before-edge | text-before-edge | central | middle | hanging |mathematical | <percentage> | <length>",
                Initial = "text-before-edge",
                AppliesTo = "::first-letter pseudo element",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[36] //CSS3 module: line
            },
            new CssProperty
            {
                Id = 335,
                Name = "presentation-level",
                Version = CssVersion.Css3,
                Value = "<integer> | same | increment",
                Initial = "0",
                AppliesTo = "all elements",
                Inherited = true,
                Media =
                    MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive | MediaGroups.Paged |
                    MediaGroups.Continuous | MediaGroups.Visual | MediaGroups.Speech | MediaGroups.Interactive |
                    MediaGroups.Paged | MediaGroups.Continuous,
                Animatable = CssAnimatable.No,
                Module = CssModule[37] //SS Presentation Levels Module
            },
            new CssProperty
            {
                Id = 336,
                Name = "negative",
                Version = CssVersion.Css3,
                Value = "<symbol> <symbol>?",
                Initial = @"""\2D"" (""-"" hyphen-minus)",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38] //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 337,
                Name = "system",
                Version = CssVersion.Css3,
                Value =
                    "cyclic | numeric | alphabetic | symbolic | additive | [fixed <integer>?] | [ extends <counter-style-name> ]",
                Initial = @"symbolic",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 338,
                Name = "prefix",
                Version = CssVersion.Css3,
                Value = "<symbol>",
                Initial = @""""" (the empty string)",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 339,
                Name = "suffix",
                Version = CssVersion.Css3,
                Value = "<symbol>",
                Initial = @"( full stop followed by a space)",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 340,
                Name = "range",
                Version = CssVersion.Css3,
                Value = "[ [ <integer> | infinite ]{2} ]# | auto",
                Initial = @"auto",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 341,
                Name = "pad",
                Version = CssVersion.Css3,
                Value = "<integer> && <symbol>",
                Initial = @"0 """,
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 342,
                Name = "fallback",
                Version = CssVersion.Css3,
                Value = "<counter-style-name>",
                Initial = @"decimal",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 343,
                Name = "symbols",
                Version = CssVersion.Css3,
                Value = "<symbol>+",
                Initial = @"n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 344,
                Name = "additive-symbols",
                Version = CssVersion.Css3,
                Value = "[ <integer> && <symbol> ]#",
                Initial = @"n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[38], //CSS Counter Styles Level 3
            },
            new CssProperty
            {
                Id = 345,
                Name = "filter",
                Version = CssVersion.Css3,
                Value = "none | <filter-function-list>",
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.Yes,
                AppliesTo =
                    "All elements. In SVG it applies to container elements without the <defs> element and all graphics elements",
                Categories = Categories.None,
                ContentModel =
                    "Any number of the following elements, in any order: descriptive — desc, title, metadata filter primitive — feBlend, feFlood, feColorMatrix, feComponentTransfer, feComposite, feConvolveMatrix, feDiffuseLighting, feDisplacementMap, feDropShadow, feGaussianBlur, feImage, feMerge, feMorphology, feOffset, feSpecularLighting, feTile, feTurbulence animate script set",
                Attributes =
                    "core attributes — ‘id’, ‘xml:base’, ‘xml:lang’, ‘xml:space’ presentation attributes — alignment-baseline, baseline-shift, clip, clip-path, clip-rule, color, color-interpolation,"
                    +
                    " color-interpolation-filters, color-rendering, cursor, direction, display, dominant-baseline, enable-background, fill, fill-opacity, fill-rule, filter, flood-color, flood-opacity, font, font-family, font-size,"
                    +
                    " font-size-adjust, font-stretch, font-style, font-variant, font-weight, glyph-orientation-horizontal, glyph-orientation-vertical, image-rendering, isolation, kerning, letter-spacing, lighting-color, marker, marker-end, marker-mid," +
                    " marker-start, mask, opacity, overflow, pointer-events, shape-rendering, stop-color, stop-opacity, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity, stroke-width, text-anchor, text-decoration, text-rendering, unicode-bidi, visibility, word-spacing, writing-mode ‘class’ ‘style’ ‘externalResourcesRequired’ x y width height filterUnits primitiveUnits",
                Module = CssModule[26] //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 346,
                Name = "feBlend",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements, in any order: animate script set",
                Attributes =
                    "core attributes — ‘id’, ‘xml:base’, ‘xml:lang’, ‘xml:space’ presentation attributes — alignment-baseline, baseline-shift, clip, clip-path, clip-rule, color, color-interpolation, color-interpolation-filters, color-rendering, cursor, direction, display, dominant-baseline, enable-background, fill, fill-opacity, fill-rule, filter, flood-color, flood-opacity, font, font-family, font-size, font-size-adjust, font-stretch, font-style, font-variant, font-weight, glyph-orientation-horizontal, glyph-orientation-vertical, image-rendering, isolation, kerning, letter-spacing, lighting-color, marker, marker-end, marker-mid, marker-start, mask, opacity, overflow, pointer-events, shape-rendering, stop-color, stop-opacity, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity, stroke-width, text-anchor, text-decoration, text-rendering, unicode-bidi, visibility, word-spacing, writing-mode filter primitive attributes — x, y, width, height, result ‘class’ ‘style’ in in2 mode",
            },
            new CssProperty
            {
                Id = 347,
                Name = "feColorMatrix",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements, in any order: animate script set",
                Attributes =
                    "core attributes — ‘id’, ‘xml:base’, ‘xml:lang’, ‘xml:space’ presentation attributes — alignment-baseline, baseline-shift, clip, clip-path, clip-rule, color, color-interpolation, color-interpolation-filters, color-rendering, cursor, direction, display, dominant-baseline, enable-background, fill, fill-opacity, fill-rule, filter, flood-color, flood-opacity, font, font-family, font-size, font-size-adjust, font-stretch, font-style, font-variant, font-weight, glyph-orientation-horizontal, glyph-orientation-vertical, image-rendering, isolation, kerning, letter-spacing, lighting-color, marker, marker-end, marker-mid, marker-start, mask, opacity, overflow, pointer-events, shape-rendering, stop-color, stop-opacity, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity, stroke-width, text-anchor, text-decoration, text-rendering, unicode-bidi, visibility, word-spacing, writing-mode filter primitive attributes — x, y, width, height, result ‘class’ ‘style’ in type values"
            },
            new CssProperty
            {
                Id = 348,
                Name = "feComponentTransfer",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.FilterPrimitiveElement,
                ContentModel =
                    "Any number of the following elements, in any order: feFuncR feFuncG feFuncB feFuncA script",
                Attributes =
                    "core attributes — ‘id’,‘xml:base’, ‘xml:lang’, ‘xml:space’ presentation attributes — alignment-baseline, baseline-shift, clip, clip-path, clip-rule, color, color-interpolation, color-interpolation-filters, color-rendering, cursor, direction, display, dominant-baseline, enable-background, fill, fill-opacity, fill-rule, filter, flood-color, flood-opacity, font, font-family, font-size, font-size-adjust, font-stretch, font-style, font-variant, font-weight, glyph-orientation-horizontal, glyph-orientation-vertical, image-rendering, isolation, kerning, letter-spacing, lighting-color, marker, marker-end, marker-mid, marker-start, mask, opacity, overflow, pointer-events, shape-rendering, stop-color, stop-opacity, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity, stroke-width, text-anchor, text-decoration, text-rendering, unicode-bidi, visibility, word-spacing, writing-mode filter primitive attributes — x, y, width, height, result ‘class’ ‘style’ in"
            },
            new CssProperty
            {
                Id = 349,
                Name = "feFuncR",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.TransferFunctionElement,
                ContentModel =
                    "Any number of the following elements, in any order: feFuncR feFuncG feFuncB feFuncA script",
                Attributes =
                    "core attributes — ‘id’,‘xml:base’, ‘xml:lang’, ‘xml:space’ transfer function element attributes — type, tableValues, slope, intercept, amplitude, exponent, offset"
            },
            new CssProperty
            {
                Id = 350,
                Name = "feFuncG",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.TransferFunctionElement,
                ContentModel =
                    "Any number of the following elements, in any order: feFuncR feFuncG feFuncB feFuncA script",
                Attributes =
                    "core attributes — ‘id’,‘xml:base’, ‘xml:lang’, ‘xml:space’ transfer function element attributes — type, tableValues, slope, intercept, amplitude, exponent, offset"
            },
            new CssProperty
            {
                Id = 351,
                Name = "feFuncB",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.TransferFunctionElement,
                ContentModel =
                    "Any number of the following elements, in any order: feFuncR feFuncG feFuncB feFuncA script",
                Attributes =
                    "core attributes — ‘id’,‘xml:base’, ‘xml:lang’, ‘xml:space’ transfer function element attributes — type, tableValues, slope, intercept, amplitude, exponent, offset"
            },
            new CssProperty
            {
                Id = 352,
                Name = "feFuncA",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.TransferFunctionElement,
                ContentModel =
                    "Any number of the following elements, in any order: feFuncR feFuncG feFuncB feFuncA script",
                Attributes =
                    "core attributes — ‘id’,‘xml:base’, ‘xml:lang’, ‘xml:space’ transfer function element attributes — type, tableValues, slope, intercept, amplitude, exponent, offset"
            },
            new CssProperty
            {
                Id = 353,
                Name = "feComposite",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.TransferFunctionElement,
                ContentModel =
                    "Any number of the following elements, in any order: feFuncR feFuncG feFuncB feFuncA script",
                Attributes =
                    "core attributes — ‘id’,‘xml:base’, ‘xml:lang’, ‘xml:space’ presentation attributes — alignment-baseline, baseline-shift, clip, clip-path, clip-rule, color, color-interpolation, color-interpolation-filters, color-rendering, cursor, direction, display, dominant-baseline, enable-background, fill, fill-opacity, fill-rule, filter, flood-color, flood-opacity, font, font-family, font-size, font-size-adjust, font-stretch, font-style, font-variant, font-weight, glyph-orientation-horizontal, glyph-orientation-vertical, image-rendering, isolation, kerning, letter-spacing, lighting-color, marker, marker-end, marker-mid, marker-start, mask, opacity, overflow, pointer-events, shape-rendering, stop-color, stop-opacity, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity, stroke-width, text-anchor, text-decoration, text-rendering, unicode-bidi, visibility, word-spacing, writing-mode filter primitive attributes — x, y, width, height, result ‘class’ ‘style’ in in2 operator k1 k2 k3 k4"
            },
            new CssProperty
            {
                Id = 354,
                Name = "feConvolveMatrix",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.TransferFunctionElement,
                ContentModel =
                    "Any number of the following elements, in any order: feFuncR feFuncG feFuncB feFuncA script",
                Attributes =
                    "core attributes — ‘id’,‘xml:base’, ‘xml:lang’, ‘xml:space’ presentation attributes — alignment-baseline, baseline-shift, clip, clip-path, clip-rule, color, color-interpolation, color-interpolation-filters, color-rendering, cursor, direction, display, dominant-baseline, enable-background, fill, fill-opacity, fill-rule, filter, flood-color, flood-opacity, font, font-family, font-size, font-size-adjust, font-stretch, font-style, font-variant, font-weight, glyph-orientation-horizontal, glyph-orientation-vertical, image-rendering, isolation, kerning, letter-spacing, lighting-color, marker, marker-end, marker-mid, marker-start, mask, opacity, overflow, pointer-events, shape-rendering, stop-color, stop-opacity, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity, stroke-width, text-anchor, text-decoration, text-rendering, unicode-bidi, visibility, word-spacing, writing-mode filter primitive attributes — x, y, width, height, result ‘class’ ‘style’ in order kernelMatrix divisor bias targetX targetY edgeMode kernelUnitLength preserveAlpha"
            },
            new CssProperty
            {
                Id = 355,
                Name = "feDiffuseLighting",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.FilterPrimitiveElement,
                ContentModel =
                    "Any number of descriptive elements <script>and exactly one light source element in any order.",
                Attributes = "SVGFEDiffuseLightingElement"
            },
            new CssProperty
            {
                Id = 356,
                Name = "feDisplacementMap",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEDisplacementMapElement"
            },
            new CssProperty
            {
                Id = 357,
                Name = "feDropShadow",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEDropShadowElement"
            },
            new CssProperty
            {
                Id = 358,
                Name = "feFlood",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Module = CssModule[26], //Filter Effects Module Level 1
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEFloodElement"
            },
            new CssProperty
            {
                Id = 359,
                Name = "feGaussianBlur",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEGaussianBlurElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 360,
                Name = "feImage",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animateanimateTransformscriptset",
                Attributes = "SVGFEImageElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 361,
                Name = "feMerge",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: feMergeNodescript",
                Attributes = "SVGFEMergeElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 362,
                Name = "feMergeNode",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.None,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEMergeNodeElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 363,
                Name = "feMorphology",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEMorphologyElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 364,
                Name = "feOffset",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEOffsetElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 365,
                Name = "feSpecularLighting",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel =
                    "Any number of descriptive elements <script>and exactly one light source element in any order.",
                Attributes = "SVGFESpecularLightingElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 366,
                Name = "feTile",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFETileElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 367,
                Name = "feTurbulence",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.FilterPrimitiveElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFETurbulenceElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 368,
                Name = "feDistantLight",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.LightSourceElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEDistantLightElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 369,
                Name = "fePointLight",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.LightSourceElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFEPointLightElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 370,
                Name = "feSpotLight",
                Version = CssVersion.Css3,
                Initial = "n/a",
                Inherited = false,
                Media = MediaGroups.None,
                Animatable = CssAnimatable.No,
                Categories = Categories.LightSourceElement,
                ContentModel = "Any number of the following elements in any order: animatescriptset",
                Attributes = "SVGFESpotLightElement",
                Module = CssModule[26], //Filter Effects Module Level 1
            },
            new CssProperty
            {
                Id = 371,
                Name = "grid-column",
                Version = CssVersion.Css3,
                Value = "<grid-line> [ / <grid-line> ]? ",
                Initial = "see individual properties ",
                AppliesTo = "grid items and absolutely-positioned boxes whose containing block is a grid container ",
                Inherited = false,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[21] //CSS Grid Layout Module Level 1
            },
            new CssProperty
            {
                Id = 372,
                Name = "word-wrap",
                Version = CssVersion.Css3,
                Value = "normal | break-word",
                Initial = "normal",
                AppliesTo = "all elements",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[12] //CSS Text Module Level 3
            },
            new CssProperty
            {
                Id = 373,
                Name = "widows",
                Version = CssVersion.Css2,
                Value = "<integer>",
                Initial = "2",
                AppliesTo = "block containers",
                Inherited = true,
                Media = MediaGroups.Visual,
                Animatable = CssAnimatable.No,
                Module = CssModule[13] //CSS Fragmentation Module Level 3
            },
            new CssProperty
            {
                Id = 374,
                Name = "nav-right",
                Version = CssVersion.Css3,
                Value = "auto | <id> [ current | root | <target-name> ]? ",
                Initial = "auto",
                AppliesTo = "all enabled elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            },
            new CssProperty
            {
                Id = 375,
                Name = "nav-left",
                Version = CssVersion.Css3,
                Value = "auto | <id> [ current | root | <target-name> ]? ",
                Initial = "auto",
                AppliesTo = "all enabled elements",
                Inherited = false,
                Media = MediaGroups.Interactive,
                Animatable = CssAnimatable.No,
                Module = CssModule[18] //CSS Basic User Interface Module Level 3 (CSS3 UI)
            }
        };
    }
}
