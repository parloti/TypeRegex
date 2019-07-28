// Not supported in .Net 4.8.
#undef UNSUPORTED

using System;

namespace TypeRegex
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
    public class PositiveUnicodeBlock : PositiveUnicodeGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveUnicodeBlock"/> class.
        /// </summary>
        /// <param name="name">The block name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentException"><paramref name="name"/> is <see cref="string.Empty"/> or consists only of white-space characters.</exception>
        private PositiveUnicodeBlock(string name) : base(name)
        {
        }

        /// <summary>
        /// 0000 - 007F. Value: "\p{IsBasicLatin}".
        /// </summary>
        public static PositiveUnicodeBlock BasicLatin { get; } = new PositiveUnicodeBlock("IsBasicLatin");

        /// <summary>
        /// 0080 - 00FF. Value: "\p{IsLatin-1Supplement}".
        /// </summary>
        public static PositiveUnicodeBlock Latin1Supplement { get; } = new PositiveUnicodeBlock("IsLatin-1Supplement");

        /// <summary>
        /// 0100 - 017F. Value: "\p{IsLatinExtended-A}".
        /// </summary>
        public static PositiveUnicodeBlock LatinExtendedA { get; } = new PositiveUnicodeBlock("IsLatinExtended-A");

        /// <summary>
        /// 0180 - 024F. Value: "\p{IsLatinExtended-B}".
        /// </summary>
        public static PositiveUnicodeBlock LatinExtendedB { get; } = new PositiveUnicodeBlock("IsLatinExtended-B");

        /// <summary>
        /// 0250 - 02AF. Value: "\p{IsIPAExtensions}".
        /// </summary>
        public static PositiveUnicodeBlock IPAExtensions { get; } = new PositiveUnicodeBlock("IsIPAExtensions");

        /// <summary>
        /// 02B0 - 02FF. Value: "\p{IsSpacingModifierLetters}".
        /// </summary>
        public static PositiveUnicodeBlock SpacingModifierLetters { get; } = new PositiveUnicodeBlock("IsSpacingModifierLetters");

        /// <summary>
        /// 0300 - 036F. Value: "\p{IsCombiningDiacriticalMarks}".
        /// </summary>
        public static PositiveUnicodeBlock CombiningDiacriticalMarks { get; } = new PositiveUnicodeBlock("IsCombiningDiacriticalMarks");

        /// <summary>
        /// 0370 - 03FF. Value: "\p{IsGreek}".
        /// </summary>
        public static PositiveUnicodeBlock GreekandCoptic { get; } = new PositiveUnicodeBlock("IsGreek");

        /// <summary>
        /// 0370 - 03FF. Value: "\p{IsGreekandCoptic}".
        /// </summary>
        public static PositiveUnicodeBlock IsGreekandCoptic { get; } = new PositiveUnicodeBlock("IsGreekandCoptic");

        /// <summary>
        /// 0400 - 04FF. Value: "\p{IsCyrillic}".
        /// </summary>
        public static PositiveUnicodeBlock Cyrillic { get; } = new PositiveUnicodeBlock("IsCyrillic");

        /// <summary>
        /// 0500 - 052F. Value: "\p{IsCyrillicSupplement}".
        /// </summary>
        public static PositiveUnicodeBlock CyrillicSupplement { get; } = new PositiveUnicodeBlock("IsCyrillicSupplement");

        /// <summary>
        /// 0530 - 058F. Value: "\p{IsArmenian}".
        /// </summary>
        public static PositiveUnicodeBlock Armenian { get; } = new PositiveUnicodeBlock("IsArmenian");

        /// <summary>
        /// 0590 - 05FF. Value: "\p{IsHebrew}".
        /// </summary>
        public static PositiveUnicodeBlock Hebrew { get; } = new PositiveUnicodeBlock("IsHebrew");

        /// <summary>
        /// 0600 - 06FF. Value: "\p{IsArabic}".
        /// </summary>
        public static PositiveUnicodeBlock Arabic { get; } = new PositiveUnicodeBlock("IsArabic");

        /// <summary>
        /// 0700 - 074F. Value: "\p{IsSyriac}".
        /// </summary>
        public static PositiveUnicodeBlock Syriac { get; } = new PositiveUnicodeBlock("IsSyriac");

#if UNSUPORTED
        /// <summary>
        /// 0750 - 077F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ArabicSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 0780 - 07BF. Value: "\p{IsThaana}".
        /// </summary>
        public static PositiveUnicodeBlock Thaana { get; } = new PositiveUnicodeBlock("IsThaana");

#if UNSUPORTED
        /// <summary>
        /// 07C0 - 07FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock NKo{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 0800 - 083F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Samaritan{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 0840 - 085F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Mandaic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 0860 - 086F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SyriacSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 08A0 - 08FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ArabicExtendedA{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 0900 - 097F. Value: "\p{IsDevanagari}".
        /// </summary>
        public static PositiveUnicodeBlock Devanagari { get; } = new PositiveUnicodeBlock("IsDevanagari");

        /// <summary>
        /// 0980 - 09FF. Value: "\p{IsBengali}".
        /// </summary>
        public static PositiveUnicodeBlock Bengali { get; } = new PositiveUnicodeBlock("IsBengali");

        /// <summary>
        /// 0A00 - 0A7F. Value: "\p{IsGurmukhi}".
        /// </summary>
        public static PositiveUnicodeBlock Gurmukhi { get; } = new PositiveUnicodeBlock("IsGurmukhi");

        /// <summary>
        /// 0A80 - 0AFF. Value: "\p{IsGujarati}".
        /// </summary>
        public static PositiveUnicodeBlock Gujarati { get; } = new PositiveUnicodeBlock("IsGujarati");

        /// <summary>
        /// 0B00 - 0B7F. Value: "\p{IsOriya}".
        /// </summary>
        public static PositiveUnicodeBlock Oriya { get; } = new PositiveUnicodeBlock("IsOriya");

        /// <summary>
        /// 0B80 - 0BFF. Value: "\p{IsTamil}".
        /// </summary>
        public static PositiveUnicodeBlock Tamil { get; } = new PositiveUnicodeBlock("IsTamil");

        /// <summary>
        /// 0C00 - 0C7F. Value: "\p{IsTelugu}".
        /// </summary>
        public static PositiveUnicodeBlock Telugu { get; } = new PositiveUnicodeBlock("IsTelugu");

        /// <summary>
        /// 0C80 - 0CFF. Value: "\p{IsKannada}".
        /// </summary>
        public static PositiveUnicodeBlock Kannada { get; } = new PositiveUnicodeBlock("IsKannada");

        /// <summary>
        /// 0D00 - 0D7F. Value: "\p{IsMalayalam}".
        /// </summary>
        public static PositiveUnicodeBlock Malayalam { get; } = new PositiveUnicodeBlock("IsMalayalam");

        /// <summary>
        /// 0D80 - 0DFF. Value: "\p{IsSinhala}".
        /// </summary>
        public static PositiveUnicodeBlock Sinhala { get; } = new PositiveUnicodeBlock("IsSinhala");

        /// <summary>
        /// 0E00 - 0E7F. Value: "\p{IsThai}".
        /// </summary>
        public static PositiveUnicodeBlock Thai { get; } = new PositiveUnicodeBlock("IsThai");

        /// <summary>
        /// 0E80 - 0EFF. Value: "\p{IsLao}".
        /// </summary>
        public static PositiveUnicodeBlock Lao { get; } = new PositiveUnicodeBlock("IsLao");

        /// <summary>
        /// 0F00 - 0FFF. Value: "\p{IsTibetan}".
        /// </summary>
        public static PositiveUnicodeBlock Tibetan { get; } = new PositiveUnicodeBlock("IsTibetan");

        /// <summary>
        /// 1000 - 109F. Value: "\p{IsMyanmar}".
        /// </summary>
        public static PositiveUnicodeBlock Myanmar { get; } = new PositiveUnicodeBlock("IsMyanmar");

        /// <summary>
        /// 10A0 - 10FF. Value: "\p{IsGeorgian}".
        /// </summary>
        public static PositiveUnicodeBlock Georgian { get; } = new PositiveUnicodeBlock("IsGeorgian");

        /// <summary>
        /// 1100 - 11FF. Value: "\p{IsHangulJamo}".
        /// </summary>
        public static PositiveUnicodeBlock HangulJamo { get; } = new PositiveUnicodeBlock("IsHangulJamo");

        /// <summary>
        /// 1200 - 137F. Value: "\p{IsEthiopic}".
        /// </summary>
        public static PositiveUnicodeBlock Ethiopic { get; } = new PositiveUnicodeBlock("IsEthiopic");

#if UNSUPORTED
        /// <summary>
        /// 1380 - 139F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EthiopicSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 13A0 - 13FF. Value: "\p{IsCherokee}".
        /// </summary>
        public static PositiveUnicodeBlock Cherokee { get; } = new PositiveUnicodeBlock("IsCherokee");

        /// <summary>
        /// 1400 - 167F. Value: "\p{IsUnifiedCanadianAboriginalSyllabics}".
        /// </summary>
        public static PositiveUnicodeBlock UnifiedCanadianAboriginalSyllabics { get; } = new PositiveUnicodeBlock("IsUnifiedCanadianAboriginalSyllabics");

        /// <summary>
        /// 1680 - 169F. Value: "\p{IsOgham}".
        /// </summary>
        public static PositiveUnicodeBlock Ogham { get; } = new PositiveUnicodeBlock("IsOgham");

        /// <summary>
        /// 16A0 - 16FF. Value: "\p{IsRunic}".
        /// </summary>
        public static PositiveUnicodeBlock Runic { get; } = new PositiveUnicodeBlock("IsRunic");

        /// <summary>
        /// 1700 - 171F. Value: "\p{IsTagalog}".
        /// </summary>
        public static PositiveUnicodeBlock Tagalog { get; } = new PositiveUnicodeBlock("IsTagalog");

        /// <summary>
        /// 1720 - 173F. Value: "\p{IsHanunoo}".
        /// </summary>
        public static PositiveUnicodeBlock Hanunoo { get; } = new PositiveUnicodeBlock("IsHanunoo");

        /// <summary>
        /// 1740 - 175F. Value: "\p{IsBuhid}".
        /// </summary>
        public static PositiveUnicodeBlock Buhid { get; } = new PositiveUnicodeBlock("IsBuhid");

        /// <summary>
        /// 1760 - 177F. Value: "\p{IsTagbanwa}".
        /// </summary>
        public static PositiveUnicodeBlock Tagbanwa { get; } = new PositiveUnicodeBlock("IsTagbanwa");

        /// <summary>
        /// 1780 - 17FF. Value: "\p{IsKhmer}".
        /// </summary>
        public static PositiveUnicodeBlock Khmer { get; } = new PositiveUnicodeBlock("IsKhmer");

        /// <summary>
        /// 1800 - 18AF. Value: "\p{IsMongolian}".
        /// </summary>
        public static PositiveUnicodeBlock Mongolian { get; } = new PositiveUnicodeBlock("IsMongolian");

#if UNSUPORTED
        /// <summary>
        /// 18B0 - 18FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock UnifiedCanadianAboriginalSyllabicsExtended{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 1900 - 194F. Value: "\p{IsLimbu}".
        /// </summary>
        public static PositiveUnicodeBlock Limbu { get; } = new PositiveUnicodeBlock("IsLimbu");

        /// <summary>
        /// 1950 - 197F. Value: "\p{IsTaiLe}".
        /// </summary>
        public static PositiveUnicodeBlock TaiLe { get; } = new PositiveUnicodeBlock("IsTaiLe");

#if UNSUPORTED
        /// <summary>
        /// 1980 - 19DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock NewTaiLue{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 19E0 - 19FF. Value: "\p{IsKhmerSymbols}".
        /// </summary>
        public static PositiveUnicodeBlock KhmerSymbols { get; } = new PositiveUnicodeBlock("IsKhmerSymbols");

#if UNSUPORTED
        /// <summary>
        /// 1A00 - 1A1F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Buginese{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1A20 - 1AAF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock TaiTham{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1AB0 - 1AFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CombiningDiacriticalMarksExtended{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B00 - 1B7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Balinese{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B80 - 1BBF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Sundanese{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BC0 - 1BFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Batak{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C00 - 1C4F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Lepcha{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C50 - 1C7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OlChiki{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C80 - 1C8F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CyrillicExtendedC{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C90 - 1CBF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock GeorgianExtended{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1CC0 - 1CCF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SundaneseSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1CD0 - 1CFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock VedicExtensions{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 1D00 - 1D7F. Value: "\p{IsPhoneticExtensions}".
        /// </summary>
        public static PositiveUnicodeBlock PhoneticExtensions { get; } = new PositiveUnicodeBlock("IsPhoneticExtensions");

#if UNSUPORTED
        /// <summary>
        /// 1D80 - 1DBF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock PhoneticExtensionsSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1DC0 - 1DFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CombiningDiacriticalMarksSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 1E00 - 1EFF. Value: "\p{IsLatinExtendedAdditional}".
        /// </summary>
        public static PositiveUnicodeBlock LatinExtendedAdditional { get; } = new PositiveUnicodeBlock("IsLatinExtendedAdditional");

        /// <summary>
        /// 1F00 - 1FFF. Value: "\p{IsGreekExtended}".
        /// </summary>
        public static PositiveUnicodeBlock GreekExtended { get; } = new PositiveUnicodeBlock("IsGreekExtended");

        /// <summary>
        /// 2000 - 206F. Value: "\p{IsGeneralPunctuation}".
        /// </summary>
        public static PositiveUnicodeBlock GeneralPunctuation { get; } = new PositiveUnicodeBlock("IsGeneralPunctuation");

        /// <summary>
        /// 2070 - 209F. Value: "\p{IsSuperscriptsandSubscripts}".
        /// </summary>
        public static PositiveUnicodeBlock SuperscriptsandSubscripts { get; } = new PositiveUnicodeBlock("IsSuperscriptsandSubscripts");

        /// <summary>
        /// 20A0 - 20CF. Value: "\p{IsCurrencySymbols}".
        /// </summary>
        public static PositiveUnicodeBlock CurrencySymbols { get; } = new PositiveUnicodeBlock("IsCurrencySymbols");

        /// <summary>
        /// 20D0 - 20FF. Value: "\p{IsCombiningDiacriticalMarksforSymbols}".
        /// </summary>
        public static PositiveUnicodeBlock CombiningDiacriticalMarksforSymbols { get; } = new PositiveUnicodeBlock("IsCombiningDiacriticalMarksforSymbols");

        /// <summary>
        /// 20D0 - 20FF. Value: "\p{"IsCombiningMarksforSymbols"}".
        /// </summary>
        public static PositiveUnicodeBlock IsCombiningMarksforSymbols { get; } = new PositiveUnicodeBlock("IsCombiningMarksforSymbols");

        /// <summary>
        /// 2100 - 214F. Value: "\p{IsLetterlikeSymbols}".
        /// </summary>
        public static PositiveUnicodeBlock LetterlikeSymbols { get; } = new PositiveUnicodeBlock("IsLetterlikeSymbols");

        /// <summary>
        /// 2150 - 218F. Value: "\p{IsNumberForms}".
        /// </summary>
        public static PositiveUnicodeBlock NumberForms { get; } = new PositiveUnicodeBlock("IsNumberForms");

        /// <summary>
        /// 2190 - 21FF. Value: "\p{IsArrows}".
        /// </summary>
        public static PositiveUnicodeBlock Arrows { get; } = new PositiveUnicodeBlock("IsArrows");

        /// <summary>
        /// 2200 - 22FF. Value: "\p{IsMathematicalOperators}".
        /// </summary>
        public static PositiveUnicodeBlock MathematicalOperators { get; } = new PositiveUnicodeBlock("IsMathematicalOperators");

        /// <summary>
        /// 2300 - 23FF. Value: "\p{IsMiscellaneousTechnical}".
        /// </summary>
        public static PositiveUnicodeBlock MiscellaneousTechnical { get; } = new PositiveUnicodeBlock("IsMiscellaneousTechnical");

        /// <summary>
        /// 2400 - 243F. Value: "\p{IsControlPictures}".
        /// </summary>
        public static PositiveUnicodeBlock ControlPictures { get; } = new PositiveUnicodeBlock("IsControlPictures");

        /// <summary>
        /// 2440 - 245F. Value: "\p{IsOpticalCharacterRecognition}".
        /// </summary>
        public static PositiveUnicodeBlock OpticalCharacterRecognition { get; } = new PositiveUnicodeBlock("IsOpticalCharacterRecognition");

        /// <summary>
        /// 2460 - 24FF. Value: "\p{IsEnclosedAlphanumerics}".
        /// </summary>
        public static PositiveUnicodeBlock EnclosedAlphanumerics { get; } = new PositiveUnicodeBlock("IsEnclosedAlphanumerics");

        /// <summary>
        /// 2500 - 257F. Value: "\p{IsBoxDrawing}".
        /// </summary>
        public static PositiveUnicodeBlock BoxDrawing { get; } = new PositiveUnicodeBlock("IsBoxDrawing");

        /// <summary>
        /// 2580 - 259F. Value: "\p{IsBlockElements}".
        /// </summary>
        public static PositiveUnicodeBlock BlockElements { get; } = new PositiveUnicodeBlock("IsBlockElements");

        /// <summary>
        /// 25A0 - 25FF. Value: "\p{IsGeometricShapes}".
        /// </summary>
        public static PositiveUnicodeBlock GeometricShapes { get; } = new PositiveUnicodeBlock("IsGeometricShapes");

        /// <summary>
        /// 2600 - 26FF. Value: "\p{IsMiscellaneousSymbols}".
        /// </summary>
        public static PositiveUnicodeBlock MiscellaneousSymbols { get; } = new PositiveUnicodeBlock("IsMiscellaneousSymbols");

        /// <summary>
        /// 2700 - 27BF. Value: "\p{IsDingbats}".
        /// </summary>
        public static PositiveUnicodeBlock Dingbats { get; } = new PositiveUnicodeBlock("IsDingbats");

        /// <summary>
        /// 27C0 - 27EF. Value: "\p{IsMiscellaneousMathematicalSymbols-A}".
        /// </summary>
        public static PositiveUnicodeBlock MiscellaneousMathematicalSymbolsA { get; } = new PositiveUnicodeBlock("IsMiscellaneousMathematicalSymbols-A");

        /// <summary>
        /// 27F0 - 27FF. Value: "\p{IsSupplementalArrows-A}".
        /// </summary>
        public static PositiveUnicodeBlock SupplementalArrowsA { get; } = new PositiveUnicodeBlock("IsSupplementalArrows-A");

        /// <summary>
        /// 2800 - 28FF. Value: "\p{IsBraillePatterns}".
        /// </summary>
        public static PositiveUnicodeBlock BraillePatterns { get; } = new PositiveUnicodeBlock("IsBraillePatterns");

        /// <summary>
        /// 2900 - 297F. Value: "\p{IsSupplementalArrows-B}".
        /// </summary>
        public static PositiveUnicodeBlock SupplementalArrowsB { get; } = new PositiveUnicodeBlock("IsSupplementalArrows-B");

        /// <summary>
        /// 2980 - 29FF. Value: "\p{IsMiscellaneousMathematicalSymbols-B}".
        /// </summary>
        public static PositiveUnicodeBlock MiscellaneousMathematicalSymbolsB { get; } = new PositiveUnicodeBlock("IsMiscellaneousMathematicalSymbols-B");

        /// <summary>
        /// 2A00 - 2AFF. Value: "\p{IsSupplementalMathematicalOperators}".
        /// </summary>
        public static PositiveUnicodeBlock SupplementalMathematicalOperators { get; } = new PositiveUnicodeBlock("IsSupplementalMathematicalOperators");

        /// <summary>
        /// 2B00 - 2BFF. Value: "\p{IsMiscellaneousSymbolsandArrows}".
        /// </summary>
        public static PositiveUnicodeBlock MiscellaneousSymbolsandArrows { get; } = new PositiveUnicodeBlock("IsMiscellaneousSymbolsandArrows");

#if UNSUPORTED
        /// <summary>
        /// 2C00 - 2C5F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Glagolitic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2C60 - 2C7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock LatinExtendedC{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2C80 - 2CFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Coptic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D00 - 2D2F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock GeorgianSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D30 - 2D7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Tifinagh{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D80 - 2DDF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EthiopicExtended{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2DE0 - 2DFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CyrillicExtendedA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2E00 - 2E7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SupplementalPunctuation{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 2E80 - 2EFF. Value: "\p{IsCJKRadicalsSupplement}".
        /// </summary>
        public static PositiveUnicodeBlock CJKRadicalsSupplement { get; } = new PositiveUnicodeBlock("IsCJKRadicalsSupplement");

        /// <summary>
        /// 2F00 - 2FDF. Value: "\p{IsKangxiRadicals}".
        /// </summary>
        public static PositiveUnicodeBlock KangxiRadicals { get; } = new PositiveUnicodeBlock("IsKangxiRadicals");

        /// <summary>
        /// 2FF0 - 2FFF. Value: "\p{IsIdeographicDescriptionCharacters}".
        /// </summary>
        public static PositiveUnicodeBlock IdeographicDescriptionCharacters { get; } = new PositiveUnicodeBlock("IsIdeographicDescriptionCharacters");

        /// <summary>
        /// 3000 - 303F. Value: "\p{IsCJKSymbolsandPunctuation}".
        /// </summary>
        public static PositiveUnicodeBlock CJKSymbolsandPunctuation { get; } = new PositiveUnicodeBlock("IsCJKSymbolsandPunctuation");

        /// <summary>
        /// 3040 - 309F. Value: "\p{IsHiragana}".
        /// </summary>
        public static PositiveUnicodeBlock Hiragana { get; } = new PositiveUnicodeBlock("IsHiragana");

        /// <summary>
        /// 30A0 - 30FF. Value: "\p{IsKatakana}".
        /// </summary>
        public static PositiveUnicodeBlock Katakana { get; } = new PositiveUnicodeBlock("IsKatakana");

        /// <summary>
        /// 3100 - 312F. Value: "\p{IsBopomofo}".
        /// </summary>
        public static PositiveUnicodeBlock Bopomofo { get; } = new PositiveUnicodeBlock("IsBopomofo");

        /// <summary>
        /// 3130 - 318F. Value: "\p{IsHangulCompatibilityJamo}".
        /// </summary>
        public static PositiveUnicodeBlock HangulCompatibilityJamo { get; } = new PositiveUnicodeBlock("IsHangulCompatibilityJamo");

        /// <summary>
        /// 3190 - 319F. Value: "\p{IsKanbun}".
        /// </summary>
        public static PositiveUnicodeBlock Kanbun { get; } = new PositiveUnicodeBlock("IsKanbun");

        /// <summary>
        /// 31A0 - 31BF. Value: "\p{IsBopomofoExtended}".
        /// </summary>
        public static PositiveUnicodeBlock BopomofoExtended { get; } = new PositiveUnicodeBlock("IsBopomofoExtended");

#if UNSUPORTED
        /// <summary>
        /// 31C0 - 31EF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CJKStrokes{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// 31F0 - 31FF. Value: "\p{IsKatakanaPhoneticExtensions}".
        /// </summary>
        public static PositiveUnicodeBlock KatakanaPhoneticExtensions { get; } = new PositiveUnicodeBlock("IsKatakanaPhoneticExtensions");

        /// <summary>
        /// 3200 - 32FF. Value: "\p{IsEnclosedCJKLettersandMonths}".
        /// </summary>
        public static PositiveUnicodeBlock EnclosedCJKLettersandMonths { get; } = new PositiveUnicodeBlock("IsEnclosedCJKLettersandMonths");

        /// <summary>
        /// 3300 - 33FF. Value: "\p{IsCJKCompatibility}".
        /// </summary>
        public static PositiveUnicodeBlock CJKCompatibility { get; } = new PositiveUnicodeBlock("IsCJKCompatibility");

        /// <summary>
        /// 3400 - 4DBF. Value: "\p{IsCJKUnifiedIdeographsExtensionA}".
        /// </summary>
        public static PositiveUnicodeBlock CJKUnifiedIdeographsExtensionA { get; } = new PositiveUnicodeBlock("IsCJKUnifiedIdeographsExtensionA");

        /// <summary>
        /// 4DC0 - 4DFF. Value: "\p{IsYijingHexagramSymbols}".
        /// </summary>
        public static PositiveUnicodeBlock YijingHexagramSymbols { get; } = new PositiveUnicodeBlock("IsYijingHexagramSymbols");

        /// <summary>
        /// 4E00 - 9FFF. Value: "\p{IsCJKUnifiedIdeographs}".
        /// </summary>
        public static PositiveUnicodeBlock CJKUnifiedIdeographs { get; } = new PositiveUnicodeBlock("IsCJKUnifiedIdeographs");

        /// <summary>
        /// A000 - A48F. Value: "\p{IsYiSyllables}".
        /// </summary>
        public static PositiveUnicodeBlock YiSyllables { get; } = new PositiveUnicodeBlock("IsYiSyllables");

        /// <summary>
        /// A490 - A4CF. Value: "\p{IsYiRadicals}".
        /// </summary>
        public static PositiveUnicodeBlock YiRadicals { get; } = new PositiveUnicodeBlock("IsYiRadicals");

#if UNSUPORTED
        /// <summary>
        /// A4D0 - A4FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Lisu{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A500 - A63F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Vai{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A640 - A69F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CyrillicExtendedB{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A6A0 - A6FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Bamum{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A700 - A71F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ModifierToneLetters{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A720 - A7FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock LatinExtendedD{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A800 - A82F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SylotiNagri{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A830 - A83F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CommonIndicNumberForms{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A840 - A87F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Phagspa{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A880 - A8DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Saurashtra{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A8E0 - A8FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock DevanagariExtended{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A900 - A92F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock KayahLi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A930 - A95F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Rejang{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A960 - A97F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock HangulJamoExtendedA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A980 - A9DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Javanese{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// A9E0 - A9FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MyanmarExtendedB{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AA00 - AA5F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Cham{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AA60 - AA7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MyanmarExtendedA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AA80 - AADF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock TaiViet{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AAE0 - AAFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MeeteiMayekExtensions{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AB00 - AB2F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EthiopicExtendedA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AB30 - AB6F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock LatinExtendedE{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// AB70 - ABBF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CherokeeSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// ABC0 - ABFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MeeteiMayek{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// AC00 - D7AF. Value: "\p{IsHangulSyllables}".
        /// </summary>
        public static PositiveUnicodeBlock HangulSyllables { get; } = new PositiveUnicodeBlock("IsHangulSyllables");

#if UNSUPORTED
        /// <summary>
        /// D7B0 - D7FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock HangulJamoExtendedB{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// D800 - DB7F. Value: "\p{IsHighSurrogates}".
        /// </summary>
        public static PositiveUnicodeBlock HighSurrogates { get; } = new PositiveUnicodeBlock("IsHighSurrogates");

        /// <summary>
        /// DB80 - DBFF. Value: "\p{IsHighPrivateUseSurrogates}".
        /// </summary>
        public static PositiveUnicodeBlock HighPrivateUseSurrogates { get; } = new PositiveUnicodeBlock("IsHighPrivateUseSurrogates");

        /// <summary>
        /// DC00 - DFFF. Value: "\p{IsLowSurrogates}".
        /// </summary>
        public static PositiveUnicodeBlock LowSurrogates { get; } = new PositiveUnicodeBlock("IsLowSurrogates");

        /// <summary>
        /// E000 - F8FF. Value: "\p{IsPrivateUse}".
        /// </summary>
        public static PositiveUnicodeBlock PrivateUse { get; } = new PositiveUnicodeBlock("IsPrivateUse");

        /// <summary>
        /// E000 - F8FF. Value: "\p{IsPrivateUseArea}".
        /// </summary>
        public static PositiveUnicodeBlock PrivateUseArea { get; } = new PositiveUnicodeBlock("IsPrivateUseArea");

        /// <summary>
        /// F900 - FAFF. Value: "\p{IsCJKCompatibilityIdeographs}".
        /// </summary>
        public static PositiveUnicodeBlock CJKCompatibilityIdeographs { get; } = new PositiveUnicodeBlock("IsCJKCompatibilityIdeographs");

        /// <summary>
        /// FB00 - FB4F. Value: "\p{IsAlphabeticPresentationForms}".
        /// </summary>
        public static PositiveUnicodeBlock AlphabeticPresentationForms { get; } = new PositiveUnicodeBlock("IsAlphabeticPresentationForms");

        /// <summary>
        /// FB50 - FDFF. Value: "\p{IsArabicPresentationForms-A}".
        /// </summary>
        public static PositiveUnicodeBlock ArabicPresentationFormsA { get; } = new PositiveUnicodeBlock("IsArabicPresentationForms-A");

        /// <summary>
        /// FE00 - FE0F. Value: "\p{IsVariationSelectors}".
        /// </summary>
        public static PositiveUnicodeBlock VariationSelectors { get; } = new PositiveUnicodeBlock("IsVariationSelectors");

#if UNSUPORTED
        /// <summary>
        /// FE10 - FE1F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock VerticalForms{ get; } = new PositiveUnicodeBlock(null);
#endif

        /// <summary>
        /// FE20 - FE2F. Value: "\p{IsCombiningHalfMarks}".
        /// </summary>
        public static PositiveUnicodeBlock CombiningHalfMarks { get; } = new PositiveUnicodeBlock("IsCombiningHalfMarks");

        /// <summary>
        /// FE30 - FE4F. Value: "\p{IsCJKCompatibilityForms}".
        /// </summary>
        public static PositiveUnicodeBlock CJKCompatibilityForms { get; } = new PositiveUnicodeBlock("IsCJKCompatibilityForms");

        /// <summary>
        /// FE50 - FE6F. Value: "\p{IsSmallFormVariants}".
        /// </summary>
        public static PositiveUnicodeBlock SmallFormVariants { get; } = new PositiveUnicodeBlock("IsSmallFormVariants");

        /// <summary>
        /// FE70 - FEFF. Value: "\p{IsArabicPresentationForms-B}".
        /// </summary>
        public static PositiveUnicodeBlock ArabicPresentationFormsB { get; } = new PositiveUnicodeBlock("IsArabicPresentationForms-B");

        /// <summary>
        /// FF00 - FFEF. Value: "\p{IsHalfwidthandFullwidthForms}".
        /// </summary>
        public static PositiveUnicodeBlock HalfwidthandFullwidthForms { get; } = new PositiveUnicodeBlock("IsHalfwidthandFullwidthForms");

        /// <summary>
        /// FFF0 - FFFF. Value: "\p{IsSpecials}".
        /// </summary>
        public static PositiveUnicodeBlock Specials { get; } = new PositiveUnicodeBlock("IsSpecials");

#if UNSUPORTED
        /// <summary>
        /// 10000 - 1007F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock LinearBSyllabary{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10080 - 100FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock LinearBIdeograms{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10100 - 1013F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock AegeanNumbers{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10140 - 1018F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock AncientGreekNumbers{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10190 - 101CF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock AncientSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 101D0 - 101FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock PhaistosDisc{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10280 - 1029F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Lycian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 102A0 - 102DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Carian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 102E0 - 102FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CopticEpactNumbers{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10300 - 1032F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldItalic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10330 - 1034F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Gothic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10350 - 1037F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldPermic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10380 - 1039F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Ugaritic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 103A0 - 103DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldPersian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10400 - 1044F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Deseret{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10450 - 1047F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Shavian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10480 - 104AF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Osmanya{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 104B0 - 104FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Osage{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10500 - 1052F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Elbasan{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10530 - 1056F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CaucasianAlbanian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10600 - 1077F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock LinearA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10800 - 1083F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CypriotSyllabary{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10840 - 1085F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ImperialAramaic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10860 - 1087F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Palmyrene{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10880 - 108AF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Nabataean{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 108E0 - 108FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Hatran{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10900 - 1091F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Phoenician{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10920 - 1093F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Lydian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10980 - 1099F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MeroiticHieroglyphs{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 109A0 - 109FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MeroiticCursive{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A00 - 10A5F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Kharoshthi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A60 - 10A7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldSouthArabian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A80 - 10A9F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldNorthArabian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10AC0 - 10AFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Manichaean{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B00 - 10B3F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Avestan{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B40 - 10B5F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock InscriptionalParthian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B60 - 10B7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock InscriptionalPahlavi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B80 - 10BAF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock PsalterPahlavi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10C00 - 10C4F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldTurkic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10C80 - 10CFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldHungarian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10D00 - 10D3F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock HanifiRohingya{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10E60 - 10E7F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock RumiNumeralSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10F00 - 10F2F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OldSogdian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10F30 - 10F6F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Sogdian{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 10FE0 - 10FFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Elymaic{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11000 - 1107F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Brahmi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11080 - 110CF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Kaithi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 110D0 - 110FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SoraSompeng{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11100 - 1114F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Chakma{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11150 - 1117F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Mahajani{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11180 - 111DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Sharada{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 111E0 - 111FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SinhalaArchaicNumbers{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11200 - 1124F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Khojki{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11280 - 112AF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Multani{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 112B0 - 112FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Khudawadi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11300 - 1137F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Grantha{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11400 - 1147F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Newa{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11480 - 114DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Tirhuta{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11580 - 115FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Siddham{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11600 - 1165F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Modi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11660 - 1167F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MongolianSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11680 - 116CF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Takri{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11700 - 1173F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Ahom{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11800 - 1184F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Dogra{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 118A0 - 118FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock WarangCiti{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 119A0 - 119FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Nandinagari{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11A00 - 11A4F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ZanabazarSquare{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11A50 - 11AAF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Soyombo{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11AC0 - 11AFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock PauCinHau{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11C00 - 11C6F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Bhaiksuki{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11C70 - 11CBF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Marchen{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11D00 - 11D5F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MasaramGondi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11D60 - 11DAF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock GunjalaGondi{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11EE0 - 11EFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Makasar{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 11FC0 - 11FFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock TamilSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 12000 - 123FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Cuneiform{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 12400 - 1247F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CuneiformNumbersandPunctuation{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 12480 - 1254F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EarlyDynasticCuneiform{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 13000 - 1342F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EgyptianHieroglyphs{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 13430 - 1343F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EgyptianHieroglyphFormatControls{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 14400 - 1467F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock AnatolianHieroglyphs{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16800 - 16A3F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock BamumSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16A40 - 16A6F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Mro{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16AD0 - 16AFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock BassaVah{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16B00 - 16B8F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock PahawhHmong{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16E40 - 16E9F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Medefaidrin{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16F00 - 16F9F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Miao{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 16FE0 - 16FFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock IdeographicSymbolsandPunctuation{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 17000 - 187FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Tangut{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 18800 - 18AFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock TangutComponents{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B000 - 1B0FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock KanaSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B100 - 1B12F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock KanaExtendedA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B130 - 1B16F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SmallKanaExtension{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B170 - 1B2FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Nushu{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BC00 - 1BC9F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Duployan{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BCA0 - 1BCAF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ShorthandFormatControls{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D000 - 1D0FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ByzantineMusicalSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D100 - 1D1FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MusicalSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D200 - 1D24F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock AncientGreekMusicalNotation{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D2E0 - 1D2FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MayanNumerals{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D300 - 1D35F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock TaiXuanJingSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D360 - 1D37F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CountingRodNumerals{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D400 - 1D7FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MathematicalAlphanumericSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D800 - 1DAAF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SuttonSignWriting{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E000 - 1E02F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock GlagoliticSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E100 - 1E14F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock NyiakengPuachueHmong{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E2C0 - 1E2FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Wancho{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E800 - 1E8DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MendeKikakui{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E900 - 1E95F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Adlam{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1EC70 - 1ECBF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock IndicSiyaqNumbers{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1ED00 - 1ED4F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OttomanSiyaqNumbers{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1EE00 - 1EEFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ArabicMathematicalAlphabeticSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F000 - 1F02F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MahjongTiles{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F030 - 1F09F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock DominoTiles{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F0A0 - 1F0FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock PlayingCards{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F100 - 1F1FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EnclosedAlphanumericSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F200 - 1F2FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock EnclosedIdeographicSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F300 - 1F5FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock MiscellaneousSymbolsandPictographs{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F600 - 1F64F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Emoticons{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F650 - 1F67F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock OrnamentalDingbats{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F680 - 1F6FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock TransportandMapSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F700 - 1F77F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock AlchemicalSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F780 - 1F7FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock GeometricShapesExtended{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F800 - 1F8FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SupplementalArrowsC{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F900 - 1F9FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SupplementalSymbolsandPictographs{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1FA00 - 1FA6F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock ChessSymbols{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 1FA70 - 1FAFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SymbolsandPictographsExtendedA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 20000 - 2A6DF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CJKUnifiedIdeographsExtensionB{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2A700 - 2B73F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CJKUnifiedIdeographsExtensionC{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2B740 - 2B81F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CJKUnifiedIdeographsExtensionD{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2B820 - 2CEAF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CJKUnifiedIdeographsExtensionE{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2CEB0 - 2EBEF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CJKUnifiedIdeographsExtensionF{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 2F800 - 2FA1F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock CJKCompatibilityIdeographsSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// E0000 - E007F. Value: 
        /// </summary>
        public static PositiveUnicodeBlock Tags{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// E0100 - E01EF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock VariationSelectorsSupplement{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// F0000 - FFFFF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SupplementaryPrivateUseAreaA{ get; } = new PositiveUnicodeBlock(null);
#endif

#if UNSUPORTED
        /// <summary>
        /// 100000 - 10FF. Value: 
        /// </summary>
        public static PositiveUnicodeBlock SupplementaryPrivateUseAreaB{ get; } = new PositiveUnicodeBlock(null);
#endif

    }
}
