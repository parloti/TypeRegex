#undef UNSUPORTED
/// <summary>
/// Not supported in .Net 4.8.
/// </summary>

using System;

namespace FluentRegex
{
    /// <summary>
    /// Unicode named blocks values list.
    /// </summary>
    /// <remarks>
    /// Based on: 
    /// https://www.unicode.org/Public/UNIDATA/Blocks.txt, 
    /// https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions?view=netframework-4.3#supported-named-blocks and 
    /// https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions?view=netframework-4.8#supported-named-blocks.
    /// Accessed in: 26/05/2019.
    /// </remarks>
    public class NegativeUnicodeBlock : NegativeUnicodeGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeUnicodeBlock"/> class.
        /// </summary>
        /// <param name="name">The block name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/></exception>
        private NegativeUnicodeBlock(string name) : base(name)
        {
        }

        /// <summary>
        /// 0000 - 007F. Value: "\p{IsBasicLatin}".
        /// </summary>
        public static NegativeUnicodeBlock BasicLatin { get; } = new NegativeUnicodeBlock("IsBasicLatin");

        /// <summary>
        /// 0080 - 00FF. Value: "\p{IsLatin-1Supplement}".
        /// </summary>
        public static NegativeUnicodeBlock Latin1Supplement { get; } = new NegativeUnicodeBlock("IsLatin-1Supplement");

        /// <summary>
        /// 0100 - 017F. Value: "\p{IsLatinExtended-A}".
        /// </summary>
        public static NegativeUnicodeBlock LatinExtendedA { get; } = new NegativeUnicodeBlock("IsLatinExtended-A");

        /// <summary>
        /// 0180 - 024F. Value: "\p{IsLatinExtended-B}".
        /// </summary>
        public static NegativeUnicodeBlock LatinExtendedB { get; } = new NegativeUnicodeBlock("IsLatinExtended-B");

        /// <summary>
        /// 0250 - 02AF. Value: "\p{IsIPAExtensions}".
        /// </summary>
        public static NegativeUnicodeBlock IPAExtensions { get; } = new NegativeUnicodeBlock("IsIPAExtensions");

        /// <summary>
        /// 02B0 - 02FF. Value: "\p{IsSpacingModifierLetters}".
        /// </summary>
        public static NegativeUnicodeBlock SpacingModifierLetters { get; } = new NegativeUnicodeBlock("IsSpacingModifierLetters");

        /// <summary>
        /// 0300 - 036F. Value: "\p{IsCombiningDiacriticalMarks}".
        /// </summary>
        public static NegativeUnicodeBlock CombiningDiacriticalMarks { get; } = new NegativeUnicodeBlock("IsCombiningDiacriticalMarks");

        /// <summary>
        /// 0370 - 03FF. Value: "\p{IsGreek}".
        /// </summary>
        public static NegativeUnicodeBlock GreekandCoptic { get; } = new NegativeUnicodeBlock("IsGreek");

        /// <summary>
        /// 0370 - 03FF. Value: "\p{IsGreekandCoptic}".
        /// </summary>
        public static NegativeUnicodeBlock IsGreekandCoptic { get; } = new NegativeUnicodeBlock("IsGreekandCoptic");

        /// <summary>
        /// 0400 - 04FF. Value: "\p{IsCyrillic}".
        /// </summary>
        public static NegativeUnicodeBlock Cyrillic { get; } = new NegativeUnicodeBlock("IsCyrillic");

        /// <summary>
        /// 0500 - 052F. Value: "\p{IsCyrillicSupplement}".
        /// </summary>
        public static NegativeUnicodeBlock CyrillicSupplement { get; } = new NegativeUnicodeBlock("IsCyrillicSupplement");

        /// <summary>
        /// 0530 - 058F. Value: "\p{IsArmenian}".
        /// </summary>
        public static NegativeUnicodeBlock Armenian { get; } = new NegativeUnicodeBlock("IsArmenian");

        /// <summary>
        /// 0590 - 05FF. Value: "\p{IsHebrew}".
        /// </summary>
        public static NegativeUnicodeBlock Hebrew { get; } = new NegativeUnicodeBlock("IsHebrew");

        /// <summary>
        /// 0600 - 06FF. Value: "\p{IsArabic}".
        /// </summary>
        public static NegativeUnicodeBlock Arabic { get; } = new NegativeUnicodeBlock("IsArabic");

        /// <summary>
        /// 0700 - 074F. Value: "\p{IsSyriac}".
        /// </summary>
        public static NegativeUnicodeBlock Syriac { get; } = new NegativeUnicodeBlock("IsSyriac");

#if UNSUPORTED
        /// <summary>
        /// 0750 - 077F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ArabicSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 0780 - 07BF. Value: "\p{IsThaana}".
        /// </summary>
        public static NegativeUnicodeBlock Thaana { get; } = new NegativeUnicodeBlock("IsThaana");

#if UNSUPORTED
        /// <summary>
        /// 07C0 - 07FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock NKo{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 0800 - 083F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Samaritan{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 0840 - 085F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Mandaic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 0860 - 086F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SyriacSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 08A0 - 08FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ArabicExtendedA{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 0900 - 097F. Value: "\p{IsDevanagari}".
        /// </summary>
        public static NegativeUnicodeBlock Devanagari { get; } = new NegativeUnicodeBlock("IsDevanagari");

        /// <summary>
        /// 0980 - 09FF. Value: "\p{IsBengali}".
        /// </summary>
        public static NegativeUnicodeBlock Bengali { get; } = new NegativeUnicodeBlock("IsBengali");

        /// <summary>
        /// 0A00 - 0A7F. Value: "\p{IsGurmukhi}".
        /// </summary>
        public static NegativeUnicodeBlock Gurmukhi { get; } = new NegativeUnicodeBlock("IsGurmukhi");

        /// <summary>
        /// 0A80 - 0AFF. Value: "\p{IsGujarati}".
        /// </summary>
        public static NegativeUnicodeBlock Gujarati { get; } = new NegativeUnicodeBlock("IsGujarati");

        /// <summary>
        /// 0B00 - 0B7F. Value: "\p{IsOriya}".
        /// </summary>
        public static NegativeUnicodeBlock Oriya { get; } = new NegativeUnicodeBlock("IsOriya");

        /// <summary>
        /// 0B80 - 0BFF. Value: "\p{IsTamil}".
        /// </summary>
        public static NegativeUnicodeBlock Tamil { get; } = new NegativeUnicodeBlock("IsTamil");

        /// <summary>
        /// 0C00 - 0C7F. Value: "\p{IsTelugu}".
        /// </summary>
        public static NegativeUnicodeBlock Telugu { get; } = new NegativeUnicodeBlock("IsTelugu");

        /// <summary>
        /// 0C80 - 0CFF. Value: "\p{IsKannada}".
        /// </summary>
        public static NegativeUnicodeBlock Kannada { get; } = new NegativeUnicodeBlock("IsKannada");

        /// <summary>
        /// 0D00 - 0D7F. Value: "\p{IsMalayalam}".
        /// </summary>
        public static NegativeUnicodeBlock Malayalam { get; } = new NegativeUnicodeBlock("IsMalayalam");

        /// <summary>
        /// 0D80 - 0DFF. Value: "\p{IsSinhala}".
        /// </summary>
        public static NegativeUnicodeBlock Sinhala { get; } = new NegativeUnicodeBlock("IsSinhala");

        /// <summary>
        /// 0E00 - 0E7F. Value: "\p{IsThai}".
        /// </summary>
        public static NegativeUnicodeBlock Thai { get; } = new NegativeUnicodeBlock("IsThai");

        /// <summary>
        /// 0E80 - 0EFF. Value: "\p{IsLao}".
        /// </summary>
        public static NegativeUnicodeBlock Lao { get; } = new NegativeUnicodeBlock("IsLao");

        /// <summary>
        /// 0F00 - 0FFF. Value: "\p{IsTibetan}".
        /// </summary>
        public static NegativeUnicodeBlock Tibetan { get; } = new NegativeUnicodeBlock("IsTibetan");

        /// <summary>
        /// 1000 - 109F. Value: "\p{IsMyanmar}".
        /// </summary>
        public static NegativeUnicodeBlock Myanmar { get; } = new NegativeUnicodeBlock("IsMyanmar");

        /// <summary>
        /// 10A0 - 10FF. Value: "\p{IsGeorgian}".
        /// </summary>
        public static NegativeUnicodeBlock Georgian { get; } = new NegativeUnicodeBlock("IsGeorgian");

        /// <summary>
        /// 1100 - 11FF. Value: "\p{IsHangulJamo}".
        /// </summary>
        public static NegativeUnicodeBlock HangulJamo { get; } = new NegativeUnicodeBlock("IsHangulJamo");

        /// <summary>
        /// 1200 - 137F. Value: "\p{IsEthiopic}".
        /// </summary>
        public static NegativeUnicodeBlock Ethiopic { get; } = new NegativeUnicodeBlock("IsEthiopic");

#if UNSUPORTED
        /// <summary>
        /// 1380 - 139F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EthiopicSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 13A0 - 13FF. Value: "\p{IsCherokee}".
        /// </summary>
        public static NegativeUnicodeBlock Cherokee { get; } = new NegativeUnicodeBlock("IsCherokee");

        /// <summary>
        /// 1400 - 167F. Value: "\p{IsUnifiedCanadianAboriginalSyllabics}".
        /// </summary>
        public static NegativeUnicodeBlock UnifiedCanadianAboriginalSyllabics { get; } = new NegativeUnicodeBlock("IsUnifiedCanadianAboriginalSyllabics");

        /// <summary>
        /// 1680 - 169F. Value: "\p{IsOgham}".
        /// </summary>
        public static NegativeUnicodeBlock Ogham { get; } = new NegativeUnicodeBlock("IsOgham");

        /// <summary>
        /// 16A0 - 16FF. Value: "\p{IsRunic}".
        /// </summary>
        public static NegativeUnicodeBlock Runic { get; } = new NegativeUnicodeBlock("IsRunic");

        /// <summary>
        /// 1700 - 171F. Value: "\p{IsTagalog}".
        /// </summary>
        public static NegativeUnicodeBlock Tagalog { get; } = new NegativeUnicodeBlock("IsTagalog");

        /// <summary>
        /// 1720 - 173F. Value: "\p{IsHanunoo}".
        /// </summary>
        public static NegativeUnicodeBlock Hanunoo { get; } = new NegativeUnicodeBlock("IsHanunoo");

        /// <summary>
        /// 1740 - 175F. Value: "\p{IsBuhid}".
        /// </summary>
        public static NegativeUnicodeBlock Buhid { get; } = new NegativeUnicodeBlock("IsBuhid");

        /// <summary>
        /// 1760 - 177F. Value: "\p{IsTagbanwa}".
        /// </summary>
        public static NegativeUnicodeBlock Tagbanwa { get; } = new NegativeUnicodeBlock("IsTagbanwa");

        /// <summary>
        /// 1780 - 17FF. Value: "\p{IsKhmer}".
        /// </summary>
        public static NegativeUnicodeBlock Khmer { get; } = new NegativeUnicodeBlock("IsKhmer");

        /// <summary>
        /// 1800 - 18AF. Value: "\p{IsMongolian}".
        /// </summary>
        public static NegativeUnicodeBlock Mongolian { get; } = new NegativeUnicodeBlock("IsMongolian");

#if UNSUPORTED
        /// <summary>
        /// 18B0 - 18FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock UnifiedCanadianAboriginalSyllabicsExtended{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 1900 - 194F. Value: "\p{IsLimbu}".
        /// </summary>
        public static NegativeUnicodeBlock Limbu { get; } = new NegativeUnicodeBlock("IsLimbu");

        /// <summary>
        /// 1950 - 197F. Value: "\p{IsTaiLe}".
        /// </summary>
        public static NegativeUnicodeBlock TaiLe { get; } = new NegativeUnicodeBlock("IsTaiLe");

#if UNSUPORTED
        /// <summary>
        /// 1980 - 19DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock NewTaiLue{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 19E0 - 19FF. Value: "\p{IsKhmerSymbols}".
        /// </summary>
        public static NegativeUnicodeBlock KhmerSymbols { get; } = new NegativeUnicodeBlock("IsKhmerSymbols");

#if UNSUPORTED
        /// <summary>
        /// 1A00 - 1A1F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Buginese{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1A20 - 1AAF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock TaiTham{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1AB0 - 1AFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CombiningDiacriticalMarksExtended{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B00 - 1B7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Balinese{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B80 - 1BBF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Sundanese{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BC0 - 1BFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Batak{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C00 - 1C4F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Lepcha{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C50 - 1C7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OlChiki{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C80 - 1C8F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CyrillicExtendedC{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C90 - 1CBF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock GeorgianExtended{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1CC0 - 1CCF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SundaneseSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1CD0 - 1CFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock VedicExtensions{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 1D00 - 1D7F. Value: "\p{IsPhoneticExtensions}".
        /// </summary>
        public static NegativeUnicodeBlock PhoneticExtensions { get; } = new NegativeUnicodeBlock("IsPhoneticExtensions");

#if UNSUPORTED
        /// <summary>
        /// 1D80 - 1DBF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock PhoneticExtensionsSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1DC0 - 1DFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CombiningDiacriticalMarksSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 1E00 - 1EFF. Value: "\p{IsLatinExtendedAdditional}".
        /// </summary>
        public static NegativeUnicodeBlock LatinExtendedAdditional { get; } = new NegativeUnicodeBlock("IsLatinExtendedAdditional");

        /// <summary>
        /// 1F00 - 1FFF. Value: "\p{IsGreekExtended}".
        /// </summary>
        public static NegativeUnicodeBlock GreekExtended { get; } = new NegativeUnicodeBlock("IsGreekExtended");

        /// <summary>
        /// 2000 - 206F. Value: "\p{IsGeneralPunctuation}".
        /// </summary>
        public static NegativeUnicodeBlock GeneralPunctuation { get; } = new NegativeUnicodeBlock("IsGeneralPunctuation");

        /// <summary>
        /// 2070 - 209F. Value: "\p{IsSuperscriptsandSubscripts}".
        /// </summary>
        public static NegativeUnicodeBlock SuperscriptsandSubscripts { get; } = new NegativeUnicodeBlock("IsSuperscriptsandSubscripts");

        /// <summary>
        /// 20A0 - 20CF. Value: "\p{IsCurrencySymbols}".
        /// </summary>
        public static NegativeUnicodeBlock CurrencySymbols { get; } = new NegativeUnicodeBlock("IsCurrencySymbols");

        /// <summary>
        /// 20D0 - 20FF. Value: "\p{IsCombiningDiacriticalMarksforSymbols}".
        /// </summary>
        public static NegativeUnicodeBlock CombiningDiacriticalMarksforSymbols { get; } = new NegativeUnicodeBlock("IsCombiningDiacriticalMarksforSymbols");

        /// <summary>
        /// 20D0 - 20FF. Value: "\p{"IsCombiningMarksforSymbols"}".
        /// </summary>
        public static NegativeUnicodeBlock IsCombiningMarksforSymbols { get; } = new NegativeUnicodeBlock("IsCombiningMarksforSymbols");

        /// <summary>
        /// 2100 - 214F. Value: "\p{IsLetterlikeSymbols}".
        /// </summary>
        public static NegativeUnicodeBlock LetterlikeSymbols { get; } = new NegativeUnicodeBlock("IsLetterlikeSymbols");

        /// <summary>
        /// 2150 - 218F. Value: "\p{IsNumberForms}".
        /// </summary>
        public static NegativeUnicodeBlock NumberForms { get; } = new NegativeUnicodeBlock("IsNumberForms");

        /// <summary>
        /// 2190 - 21FF. Value: "\p{IsArrows}".
        /// </summary>
        public static NegativeUnicodeBlock Arrows { get; } = new NegativeUnicodeBlock("IsArrows");

        /// <summary>
        /// 2200 - 22FF. Value: "\p{IsMathematicalOperators}".
        /// </summary>
        public static NegativeUnicodeBlock MathematicalOperators { get; } = new NegativeUnicodeBlock("IsMathematicalOperators");

        /// <summary>
        /// 2300 - 23FF. Value: "\p{IsMiscellaneousTechnical}".
        /// </summary>
        public static NegativeUnicodeBlock MiscellaneousTechnical { get; } = new NegativeUnicodeBlock("IsMiscellaneousTechnical");

        /// <summary>
        /// 2400 - 243F. Value: "\p{IsControlPictures}".
        /// </summary>
        public static NegativeUnicodeBlock ControlPictures { get; } = new NegativeUnicodeBlock("IsControlPictures");

        /// <summary>
        /// 2440 - 245F. Value: "\p{IsOpticalCharacterRecognition}".
        /// </summary>
        public static NegativeUnicodeBlock OpticalCharacterRecognition { get; } = new NegativeUnicodeBlock("IsOpticalCharacterRecognition");

        /// <summary>
        /// 2460 - 24FF. Value: "\p{IsEnclosedAlphanumerics}".
        /// </summary>
        public static NegativeUnicodeBlock EnclosedAlphanumerics { get; } = new NegativeUnicodeBlock("IsEnclosedAlphanumerics");

        /// <summary>
        /// 2500 - 257F. Value: "\p{IsBoxDrawing}".
        /// </summary>
        public static NegativeUnicodeBlock BoxDrawing { get; } = new NegativeUnicodeBlock("IsBoxDrawing");

        /// <summary>
        /// 2580 - 259F. Value: "\p{IsBlockElements}".
        /// </summary>
        public static NegativeUnicodeBlock BlockElements { get; } = new NegativeUnicodeBlock("IsBlockElements");

        /// <summary>
        /// 25A0 - 25FF. Value: "\p{IsGeometricShapes}".
        /// </summary>
        public static NegativeUnicodeBlock GeometricShapes { get; } = new NegativeUnicodeBlock("IsGeometricShapes");

        /// <summary>
        /// 2600 - 26FF. Value: "\p{IsMiscellaneousSymbols}".
        /// </summary>
        public static NegativeUnicodeBlock MiscellaneousSymbols { get; } = new NegativeUnicodeBlock("IsMiscellaneousSymbols");

        /// <summary>
        /// 2700 - 27BF. Value: "\p{IsDingbats}".
        /// </summary>
        public static NegativeUnicodeBlock Dingbats { get; } = new NegativeUnicodeBlock("IsDingbats");

        /// <summary>
        /// 27C0 - 27EF. Value: "\p{IsMiscellaneousMathematicalSymbols-A}".
        /// </summary>
        public static NegativeUnicodeBlock MiscellaneousMathematicalSymbolsA { get; } = new NegativeUnicodeBlock("IsMiscellaneousMathematicalSymbols-A");

        /// <summary>
        /// 27F0 - 27FF. Value: "\p{IsSupplementalArrows-A}".
        /// </summary>
        public static NegativeUnicodeBlock SupplementalArrowsA { get; } = new NegativeUnicodeBlock("IsSupplementalArrows-A");

        /// <summary>
        /// 2800 - 28FF. Value: "\p{IsBraillePatterns}".
        /// </summary>
        public static NegativeUnicodeBlock BraillePatterns { get; } = new NegativeUnicodeBlock("IsBraillePatterns");

        /// <summary>
        /// 2900 - 297F. Value: "\p{IsSupplementalArrows-B}".
        /// </summary>
        public static NegativeUnicodeBlock SupplementalArrowsB { get; } = new NegativeUnicodeBlock("IsSupplementalArrows-B");

        /// <summary>
        /// 2980 - 29FF. Value: "\p{IsMiscellaneousMathematicalSymbols-B}".
        /// </summary>
        public static NegativeUnicodeBlock MiscellaneousMathematicalSymbolsB { get; } = new NegativeUnicodeBlock("IsMiscellaneousMathematicalSymbols-B");

        /// <summary>
        /// 2A00 - 2AFF. Value: "\p{IsSupplementalMathematicalOperators}".
        /// </summary>
        public static NegativeUnicodeBlock SupplementalMathematicalOperators { get; } = new NegativeUnicodeBlock("IsSupplementalMathematicalOperators");

        /// <summary>
        /// 2B00 - 2BFF. Value: "\p{IsMiscellaneousSymbolsandArrows}".
        /// </summary>
        public static NegativeUnicodeBlock MiscellaneousSymbolsandArrows { get; } = new NegativeUnicodeBlock("IsMiscellaneousSymbolsandArrows");

#if UNSUPORTED
        /// <summary>
        /// 2C00 - 2C5F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Glagolitic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2C60 - 2C7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock LatinExtendedC{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2C80 - 2CFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Coptic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D00 - 2D2F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock GeorgianSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D30 - 2D7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Tifinagh{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D80 - 2DDF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EthiopicExtended{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2DE0 - 2DFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CyrillicExtendedA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2E00 - 2E7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SupplementalPunctuation{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 2E80 - 2EFF. Value: "\p{IsCJKRadicalsSupplement}".
        /// </summary>
        public static NegativeUnicodeBlock CJKRadicalsSupplement { get; } = new NegativeUnicodeBlock("IsCJKRadicalsSupplement");

        /// <summary>
        /// 2F00 - 2FDF. Value: "\p{IsKangxiRadicals}".
        /// </summary>
        public static NegativeUnicodeBlock KangxiRadicals { get; } = new NegativeUnicodeBlock("IsKangxiRadicals");

        /// <summary>
        /// 2FF0 - 2FFF. Value: "\p{IsIdeographicDescriptionCharacters}".
        /// </summary>
        public static NegativeUnicodeBlock IdeographicDescriptionCharacters { get; } = new NegativeUnicodeBlock("IsIdeographicDescriptionCharacters");

        /// <summary>
        /// 3000 - 303F. Value: "\p{IsCJKSymbolsandPunctuation}".
        /// </summary>
        public static NegativeUnicodeBlock CJKSymbolsandPunctuation { get; } = new NegativeUnicodeBlock("IsCJKSymbolsandPunctuation");

        /// <summary>
        /// 3040 - 309F. Value: "\p{IsHiragana}".
        /// </summary>
        public static NegativeUnicodeBlock Hiragana { get; } = new NegativeUnicodeBlock("IsHiragana");

        /// <summary>
        /// 30A0 - 30FF. Value: "\p{IsKatakana}".
        /// </summary>
        public static NegativeUnicodeBlock Katakana { get; } = new NegativeUnicodeBlock("IsKatakana");

        /// <summary>
        /// 3100 - 312F. Value: "\p{IsBopomofo}".
        /// </summary>
        public static NegativeUnicodeBlock Bopomofo { get; } = new NegativeUnicodeBlock("IsBopomofo");

        /// <summary>
        /// 3130 - 318F. Value: "\p{IsHangulCompatibilityJamo}".
        /// </summary>
        public static NegativeUnicodeBlock HangulCompatibilityJamo { get; } = new NegativeUnicodeBlock("IsHangulCompatibilityJamo");

        /// <summary>
        /// 3190 - 319F. Value: "\p{IsKanbun}".
        /// </summary>
        public static NegativeUnicodeBlock Kanbun { get; } = new NegativeUnicodeBlock("IsKanbun");

        /// <summary>
        /// 31A0 - 31BF. Value: "\p{IsBopomofoExtended}".
        /// </summary>
        public static NegativeUnicodeBlock BopomofoExtended { get; } = new NegativeUnicodeBlock("IsBopomofoExtended");

#if UNSUPORTED
        /// <summary>
        /// 31C0 - 31EF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CJKStrokes{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// 31F0 - 31FF. Value: "\p{IsKatakanaPhoneticExtensions}".
        /// </summary>
        public static NegativeUnicodeBlock KatakanaPhoneticExtensions { get; } = new NegativeUnicodeBlock("IsKatakanaPhoneticExtensions");

        /// <summary>
        /// 3200 - 32FF. Value: "\p{IsEnclosedCJKLettersandMonths}".
        /// </summary>
        public static NegativeUnicodeBlock EnclosedCJKLettersandMonths { get; } = new NegativeUnicodeBlock("IsEnclosedCJKLettersandMonths");

        /// <summary>
        /// 3300 - 33FF. Value: "\p{IsCJKCompatibility}".
        /// </summary>
        public static NegativeUnicodeBlock CJKCompatibility { get; } = new NegativeUnicodeBlock("IsCJKCompatibility");

        /// <summary>
        /// 3400 - 4DBF. Value: "\p{IsCJKUnifiedIdeographsExtensionA}".
        /// </summary>
        public static NegativeUnicodeBlock CJKUnifiedIdeographsExtensionA { get; } = new NegativeUnicodeBlock("IsCJKUnifiedIdeographsExtensionA");

        /// <summary>
        /// 4DC0 - 4DFF. Value: "\p{IsYijingHexagramSymbols}".
        /// </summary>
        public static NegativeUnicodeBlock YijingHexagramSymbols { get; } = new NegativeUnicodeBlock("IsYijingHexagramSymbols");

        /// <summary>
        /// 4E00 - 9FFF. Value: "\p{IsCJKUnifiedIdeographs}".
        /// </summary>
        public static NegativeUnicodeBlock CJKUnifiedIdeographs { get; } = new NegativeUnicodeBlock("IsCJKUnifiedIdeographs");

        /// <summary>
        /// A000 - A48F. Value: "\p{IsYiSyllables}".
        /// </summary>
        public static NegativeUnicodeBlock YiSyllables { get; } = new NegativeUnicodeBlock("IsYiSyllables");

        /// <summary>
        /// A490 - A4CF. Value: "\p{IsYiRadicals}".
        /// </summary>
        public static NegativeUnicodeBlock YiRadicals { get; } = new NegativeUnicodeBlock("IsYiRadicals");

#if UNSUPORTED
        /// <summary>
        /// A4D0 - A4FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Lisu{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A500 - A63F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Vai{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A640 - A69F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CyrillicExtendedB{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A6A0 - A6FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Bamum{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A700 - A71F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ModifierToneLetters{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A720 - A7FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock LatinExtendedD{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A800 - A82F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SylotiNagri{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A830 - A83F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CommonIndicNumberForms{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A840 - A87F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Phagspa{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A880 - A8DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Saurashtra{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A8E0 - A8FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock DevanagariExtended{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A900 - A92F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock KayahLi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A930 - A95F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Rejang{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A960 - A97F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock HangulJamoExtendedA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A980 - A9DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Javanese{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A9E0 - A9FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MyanmarExtendedB{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AA00 - AA5F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Cham{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AA60 - AA7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MyanmarExtendedA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AA80 - AADF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock TaiViet{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AAE0 - AAFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MeeteiMayekExtensions{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AB00 - AB2F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EthiopicExtendedA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AB30 - AB6F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock LatinExtendedE{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AB70 - ABBF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CherokeeSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// ABC0 - ABFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MeeteiMayek{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// AC00 - D7AF. Value: "\p{IsHangulSyllables}".
        /// </summary>
        public static NegativeUnicodeBlock HangulSyllables { get; } = new NegativeUnicodeBlock("IsHangulSyllables");

#if UNSUPORTED
        /// <summary>
        /// D7B0 - D7FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock HangulJamoExtendedB{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// D800 - DB7F. Value: "\p{IsHighSurrogates}".
        /// </summary>
        public static NegativeUnicodeBlock HighSurrogates { get; } = new NegativeUnicodeBlock("IsHighSurrogates");

        /// <summary>
        /// DB80 - DBFF. Value: "\p{IsHighPrivateUseSurrogates}".
        /// </summary>
        public static NegativeUnicodeBlock HighPrivateUseSurrogates { get; } = new NegativeUnicodeBlock("IsHighPrivateUseSurrogates");

        /// <summary>
        /// DC00 - DFFF. Value: "\p{IsLowSurrogates}".
        /// </summary>
        public static NegativeUnicodeBlock LowSurrogates { get; } = new NegativeUnicodeBlock("IsLowSurrogates");

        /// <summary>
        /// E000 - F8FF. Value: "\p{IsPrivateUse}".
        /// </summary>
        public static NegativeUnicodeBlock PrivateUse { get; } = new NegativeUnicodeBlock("IsPrivateUse");

        /// <summary>
        /// E000 - F8FF. Value: "\p{IsPrivateUseArea}".
        /// </summary>
        public static NegativeUnicodeBlock PrivateUseArea { get; } = new NegativeUnicodeBlock("IsPrivateUseArea");

        /// <summary>
        /// F900 - FAFF. Value: "\p{IsCJKCompatibilityIdeographs}".
        /// </summary>
        public static NegativeUnicodeBlock CJKCompatibilityIdeographs { get; } = new NegativeUnicodeBlock("IsCJKCompatibilityIdeographs");

        /// <summary>
        /// FB00 - FB4F. Value: "\p{IsAlphabeticPresentationForms}".
        /// </summary>
        public static NegativeUnicodeBlock AlphabeticPresentationForms { get; } = new NegativeUnicodeBlock("IsAlphabeticPresentationForms");

        /// <summary>
        /// FB50 - FDFF. Value: "\p{IsArabicPresentationForms-A}".
        /// </summary>
        public static NegativeUnicodeBlock ArabicPresentationFormsA { get; } = new NegativeUnicodeBlock("IsArabicPresentationForms-A");

        /// <summary>
        /// FE00 - FE0F. Value: "\p{IsVariationSelectors}".
        /// </summary>
        public static NegativeUnicodeBlock VariationSelectors { get; } = new NegativeUnicodeBlock("IsVariationSelectors");

#if UNSUPORTED
        /// <summary>
        /// FE10 - FE1F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock VerticalForms{ get; } = new NegativeUnicodeBlock(null);
#endif

        /// <summary>
        /// FE20 - FE2F. Value: "\p{IsCombiningHalfMarks}".
        /// </summary>
        public static NegativeUnicodeBlock CombiningHalfMarks { get; } = new NegativeUnicodeBlock("IsCombiningHalfMarks");

        /// <summary>
        /// FE30 - FE4F. Value: "\p{IsCJKCompatibilityForms}".
        /// </summary>
        public static NegativeUnicodeBlock CJKCompatibilityForms { get; } = new NegativeUnicodeBlock("IsCJKCompatibilityForms");

        /// <summary>
        /// FE50 - FE6F. Value: "\p{IsSmallFormVariants}".
        /// </summary>
        public static NegativeUnicodeBlock SmallFormVariants { get; } = new NegativeUnicodeBlock("IsSmallFormVariants");

        /// <summary>
        /// FE70 - FEFF. Value: "\p{IsArabicPresentationForms-B}".
        /// </summary>
        public static NegativeUnicodeBlock ArabicPresentationFormsB { get; } = new NegativeUnicodeBlock("IsArabicPresentationForms-B");

        /// <summary>
        /// FF00 - FFEF. Value: "\p{IsHalfwidthandFullwidthForms}".
        /// </summary>
        public static NegativeUnicodeBlock HalfwidthandFullwidthForms { get; } = new NegativeUnicodeBlock("IsHalfwidthandFullwidthForms");

        /// <summary>
        /// FFF0 - FFFF. Value: "\p{IsSpecials}".
        /// </summary>
        public static NegativeUnicodeBlock Specials { get; } = new NegativeUnicodeBlock("IsSpecials");

#if UNSUPORTED
        /// <summary>
        /// 10000 - 1007F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock LinearBSyllabary{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10080 - 100FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock LinearBIdeograms{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10100 - 1013F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock AegeanNumbers{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10140 - 1018F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock AncientGreekNumbers{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10190 - 101CF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock AncientSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 101D0 - 101FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock PhaistosDisc{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10280 - 1029F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Lycian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 102A0 - 102DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Carian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 102E0 - 102FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CopticEpactNumbers{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10300 - 1032F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldItalic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10330 - 1034F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Gothic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10350 - 1037F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldPermic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10380 - 1039F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Ugaritic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 103A0 - 103DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldPersian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10400 - 1044F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Deseret{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10450 - 1047F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Shavian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10480 - 104AF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Osmanya{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 104B0 - 104FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Osage{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10500 - 1052F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Elbasan{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10530 - 1056F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CaucasianAlbanian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10600 - 1077F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock LinearA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10800 - 1083F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CypriotSyllabary{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10840 - 1085F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ImperialAramaic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10860 - 1087F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Palmyrene{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10880 - 108AF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Nabataean{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 108E0 - 108FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Hatran{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10900 - 1091F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Phoenician{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10920 - 1093F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Lydian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10980 - 1099F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MeroiticHieroglyphs{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 109A0 - 109FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MeroiticCursive{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A00 - 10A5F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Kharoshthi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A60 - 10A7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldSouthArabian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A80 - 10A9F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldNorthArabian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10AC0 - 10AFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Manichaean{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B00 - 10B3F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Avestan{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B40 - 10B5F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock InscriptionalParthian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B60 - 10B7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock InscriptionalPahlavi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B80 - 10BAF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock PsalterPahlavi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10C00 - 10C4F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldTurkic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10C80 - 10CFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldHungarian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10D00 - 10D3F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock HanifiRohingya{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10E60 - 10E7F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock RumiNumeralSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10F00 - 10F2F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OldSogdian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10F30 - 10F6F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Sogdian{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10FE0 - 10FFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Elymaic{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11000 - 1107F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Brahmi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11080 - 110CF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Kaithi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 110D0 - 110FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SoraSompeng{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11100 - 1114F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Chakma{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11150 - 1117F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Mahajani{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11180 - 111DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Sharada{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 111E0 - 111FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SinhalaArchaicNumbers{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11200 - 1124F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Khojki{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11280 - 112AF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Multani{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 112B0 - 112FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Khudawadi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11300 - 1137F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Grantha{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11400 - 1147F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Newa{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11480 - 114DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Tirhuta{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11580 - 115FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Siddham{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11600 - 1165F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Modi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11660 - 1167F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MongolianSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11680 - 116CF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Takri{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11700 - 1173F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Ahom{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11800 - 1184F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Dogra{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 118A0 - 118FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock WarangCiti{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 119A0 - 119FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Nandinagari{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11A00 - 11A4F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ZanabazarSquare{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11A50 - 11AAF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Soyombo{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11AC0 - 11AFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock PauCinHau{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11C00 - 11C6F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Bhaiksuki{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11C70 - 11CBF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Marchen{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11D00 - 11D5F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MasaramGondi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11D60 - 11DAF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock GunjalaGondi{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11EE0 - 11EFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Makasar{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11FC0 - 11FFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock TamilSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 12000 - 123FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Cuneiform{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 12400 - 1247F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CuneiformNumbersandPunctuation{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 12480 - 1254F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EarlyDynasticCuneiform{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 13000 - 1342F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EgyptianHieroglyphs{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 13430 - 1343F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EgyptianHieroglyphFormatControls{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 14400 - 1467F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock AnatolianHieroglyphs{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16800 - 16A3F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock BamumSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16A40 - 16A6F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Mro{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16AD0 - 16AFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock BassaVah{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16B00 - 16B8F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock PahawhHmong{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16E40 - 16E9F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Medefaidrin{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16F00 - 16F9F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Miao{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16FE0 - 16FFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock IdeographicSymbolsandPunctuation{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 17000 - 187FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Tangut{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 18800 - 18AFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock TangutComponents{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B000 - 1B0FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock KanaSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B100 - 1B12F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock KanaExtendedA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B130 - 1B16F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SmallKanaExtension{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B170 - 1B2FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Nushu{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BC00 - 1BC9F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Duployan{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BCA0 - 1BCAF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ShorthandFormatControls{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D000 - 1D0FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ByzantineMusicalSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D100 - 1D1FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MusicalSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D200 - 1D24F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock AncientGreekMusicalNotation{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D2E0 - 1D2FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MayanNumerals{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D300 - 1D35F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock TaiXuanJingSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D360 - 1D37F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CountingRodNumerals{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D400 - 1D7FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MathematicalAlphanumericSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D800 - 1DAAF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SuttonSignWriting{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E000 - 1E02F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock GlagoliticSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E100 - 1E14F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock NyiakengPuachueHmong{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E2C0 - 1E2FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Wancho{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E800 - 1E8DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MendeKikakui{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E900 - 1E95F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Adlam{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1EC70 - 1ECBF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock IndicSiyaqNumbers{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1ED00 - 1ED4F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OttomanSiyaqNumbers{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1EE00 - 1EEFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ArabicMathematicalAlphabeticSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F000 - 1F02F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MahjongTiles{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F030 - 1F09F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock DominoTiles{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F0A0 - 1F0FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock PlayingCards{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F100 - 1F1FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EnclosedAlphanumericSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F200 - 1F2FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock EnclosedIdeographicSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F300 - 1F5FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock MiscellaneousSymbolsandPictographs{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F600 - 1F64F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Emoticons{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F650 - 1F67F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock OrnamentalDingbats{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F680 - 1F6FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock TransportandMapSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F700 - 1F77F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock AlchemicalSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F780 - 1F7FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock GeometricShapesExtended{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F800 - 1F8FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SupplementalArrowsC{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F900 - 1F9FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SupplementalSymbolsandPictographs{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1FA00 - 1FA6F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock ChessSymbols{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1FA70 - 1FAFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SymbolsandPictographsExtendedA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 20000 - 2A6DF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CJKUnifiedIdeographsExtensionB{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2A700 - 2B73F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CJKUnifiedIdeographsExtensionC{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2B740 - 2B81F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CJKUnifiedIdeographsExtensionD{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2B820 - 2CEAF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CJKUnifiedIdeographsExtensionE{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2CEB0 - 2EBEF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CJKUnifiedIdeographsExtensionF{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2F800 - 2FA1F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock CJKCompatibilityIdeographsSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// E0000 - E007F. Value: 
        /// </summary>
        public static NegativeUnicodeBlock Tags{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// E0100 - E01EF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock VariationSelectorsSupplement{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// F0000 - FFFFF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SupplementaryPrivateUseAreaA{ get; } = new NegativeUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 100000 - 10FF. Value: 
        /// </summary>
        public static NegativeUnicodeBlock SupplementaryPrivateUseAreaB{ get; } = new NegativeUnicodeBlock(null);
#endif

    }
}
