#undef UNSUPORTED
/// <summary>
/// Not supported in .Net 4.8.
/// </summary>

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
    internal interface IUnicodeBlock
    {
        /// <summary>
        /// 0000 - 007F. Value: "\p{IsBasicLatin}".
        /// </summary>
        PositiveUnicodeBlock BasicLatin { get; }

        /// <summary>
        /// 0080 - 00FF. Value: "\p{IsLatin-1Supplement}".
        /// </summary>
        PositiveUnicodeBlock Latin1Supplement { get; }

        /// <summary>
        /// 0100 - 017F. Value: "\p{IsLatinExtended-A}".
        /// </summary>
        PositiveUnicodeBlock LatinExtendedA { get; }

        /// <summary>
        /// 0180 - 024F. Value: "\p{IsLatinExtended-B}".
        /// </summary>
        PositiveUnicodeBlock LatinExtendedB { get; }
        /// <summary>
        /// 0250 - 02AF. Value: "\p{IsIPAExtensions}".
        /// </summary>
        PositiveUnicodeBlock IPAExtensions { get; }

        /// <summary>
        /// 02B0 - 02FF. Value: "\p{IsSpacingModifierLetters}".
        /// </summary>
        PositiveUnicodeBlock SpacingModifierLetters { get; }

        /// <summary>
        /// 0300 - 036F. Value: "\p{IsCombiningDiacriticalMarks}".
        /// </summary>
        PositiveUnicodeBlock CombiningDiacriticalMarks { get; }

        /// <summary>
        /// 0370 - 03FF. Value: "\p{IsGreek}".
        /// </summary>
        PositiveUnicodeBlock GreekandCoptic { get; }

        /// <summary>
        /// 0370 - 03FF. Value: "\p{IsGreekandCoptic}".
        /// </summary>
        PositiveUnicodeBlock IsGreekandCoptic { get; }

        /// <summary>
        /// 0400 - 04FF. Value: "\p{IsCyrillic}".
        /// </summary>
        PositiveUnicodeBlock Cyrillic { get; }

        /// <summary>
        /// 0500 - 052F. Value: "\p{IsCyrillicSupplement}".
        /// </summary>
        PositiveUnicodeBlock CyrillicSupplement { get; }

        /// <summary>
        /// 0530 - 058F. Value: "\p{IsArmenian}".
        /// </summary>
        PositiveUnicodeBlock Armenian { get; }

        /// <summary>
        /// 0590 - 05FF. Value: "\p{IsHebrew}".
        /// </summary>
        PositiveUnicodeBlock Hebrew { get; }

        /// <summary>
        /// 0600 - 06FF. Value: "\p{IsArabic}".
        /// </summary>
        PositiveUnicodeBlock Arabic { get; }

        /// <summary>
        /// 0700 - 074F. Value: "\p{IsSyriac}".
        /// </summary>
        PositiveUnicodeBlock Syriac { get; }

#if UNSUPORTED
        /// <summary>
        /// 0750 - 077F. Value: 
        /// </summary>
        PositiveUnicodeBlock ArabicSupplement{ get; }
#endif

        /// <summary>
        /// 0780 - 07BF. Value: "\p{IsThaana}".
        /// </summary>
        PositiveUnicodeBlock Thaana { get; }

#if UNSUPORTED
        /// <summary>
        /// 07C0 - 07FF. Value: 
        /// </summary>
        PositiveUnicodeBlock NKo{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 0800 - 083F. Value: 
        /// </summary>
        PositiveUnicodeBlock Samaritan{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 0840 - 085F. Value: 
        /// </summary>
        PositiveUnicodeBlock Mandaic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 0860 - 086F. Value: 
        /// </summary>
        PositiveUnicodeBlock SyriacSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 08A0 - 08FF. Value: 
        /// </summary>
        PositiveUnicodeBlock ArabicExtendedA{ get; }
#endif

        /// <summary>
        /// 0900 - 097F. Value: "\p{IsDevanagari}".
        /// </summary>
        PositiveUnicodeBlock Devanagari { get; }

        /// <summary>
        /// 0980 - 09FF. Value: "\p{IsBengali}".
        /// </summary>
        PositiveUnicodeBlock Bengali { get; }

        /// <summary>
        /// 0A00 - 0A7F. Value: "\p{IsGurmukhi}".
        /// </summary>
        PositiveUnicodeBlock Gurmukhi { get; }

        /// <summary>
        /// 0A80 - 0AFF. Value: "\p{IsGujarati}".
        /// </summary>
        PositiveUnicodeBlock Gujarati { get; }

        /// <summary>
        /// 0B00 - 0B7F. Value: "\p{IsOriya}".
        /// </summary>
        PositiveUnicodeBlock Oriya { get; }

        /// <summary>
        /// 0B80 - 0BFF. Value: "\p{IsTamil}".
        /// </summary>
        PositiveUnicodeBlock Tamil { get; }

        /// <summary>
        /// 0C00 - 0C7F. Value: "\p{IsTelugu}".
        /// </summary>
        PositiveUnicodeBlock Telugu { get; }

        /// <summary>
        /// 0C80 - 0CFF. Value: "\p{IsKannada}".
        /// </summary>
        PositiveUnicodeBlock Kannada { get; }

        /// <summary>
        /// 0D00 - 0D7F. Value: "\p{IsMalayalam}".
        /// </summary>
        PositiveUnicodeBlock Malayalam { get; }

        /// <summary>
        /// 0D80 - 0DFF. Value: "\p{IsSinhala}".
        /// </summary>
        PositiveUnicodeBlock Sinhala { get; }

        /// <summary>
        /// 0E00 - 0E7F. Value: "\p{IsThai}".
        /// </summary>
        PositiveUnicodeBlock Thai { get; }

        /// <summary>
        /// 0E80 - 0EFF. Value: "\p{IsLao}".
        /// </summary>
        PositiveUnicodeBlock Lao { get; }

        /// <summary>
        /// 0F00 - 0FFF. Value: "\p{IsTibetan}".
        /// </summary>
        PositiveUnicodeBlock Tibetan { get; }

        /// <summary>
        /// 1000 - 109F. Value: "\p{IsMyanmar}".
        /// </summary>
        PositiveUnicodeBlock Myanmar { get; }

        /// <summary>
        /// 10A0 - 10FF. Value: "\p{IsGeorgian}".
        /// </summary>
        PositiveUnicodeBlock Georgian { get; }

        /// <summary>
        /// 1100 - 11FF. Value: "\p{IsHangulJamo}".
        /// </summary>
        PositiveUnicodeBlock HangulJamo { get; }

        /// <summary>
        /// 1200 - 137F. Value: "\p{IsEthiopic}".
        /// </summary>
        PositiveUnicodeBlock Ethiopic { get; }

#if UNSUPORTED
        /// <summary>
        /// 1380 - 139F. Value: 
        /// </summary>
        PositiveUnicodeBlock EthiopicSupplement{ get; }
#endif

        /// <summary>
        /// 13A0 - 13FF. Value: "\p{IsCherokee}".
        /// </summary>
        PositiveUnicodeBlock Cherokee { get; }

        /// <summary>
        /// 1400 - 167F. Value: "\p{IsUnifiedCanadianAboriginalSyllabics}".
        /// </summary>
        PositiveUnicodeBlock UnifiedCanadianAboriginalSyllabics { get; }

        /// <summary>
        /// 1680 - 169F. Value: "\p{IsOgham}".
        /// </summary>
        PositiveUnicodeBlock Ogham { get; }

        /// <summary>
        /// 16A0 - 16FF. Value: "\p{IsRunic}".
        /// </summary>
        PositiveUnicodeBlock Runic { get; }

        /// <summary>
        /// 1700 - 171F. Value: "\p{IsTagalog}".
        /// </summary>
        PositiveUnicodeBlock Tagalog { get; }

        /// <summary>
        /// 1720 - 173F. Value: "\p{IsHanunoo}".
        /// </summary>
        PositiveUnicodeBlock Hanunoo { get; }

        /// <summary>
        /// 1740 - 175F. Value: "\p{IsBuhid}".
        /// </summary>
        PositiveUnicodeBlock Buhid { get; }

        /// <summary>
        /// 1760 - 177F. Value: "\p{IsTagbanwa}".
        /// </summary>
        PositiveUnicodeBlock Tagbanwa { get; }

        /// <summary>
        /// 1780 - 17FF. Value: "\p{IsKhmer}".
        /// </summary>
        PositiveUnicodeBlock Khmer { get; }

        /// <summary>
        /// 1800 - 18AF. Value: "\p{IsMongolian}".
        /// </summary>
        PositiveUnicodeBlock Mongolian { get; }

#if UNSUPORTED
        /// <summary>
        /// 18B0 - 18FF. Value: 
        /// </summary>
        PositiveUnicodeBlock UnifiedCanadianAboriginalSyllabicsExtended{ get; }
#endif

        /// <summary>
        /// 1900 - 194F. Value: "\p{IsLimbu}".
        /// </summary>
        PositiveUnicodeBlock Limbu { get; }

        /// <summary>
        /// 1950 - 197F. Value: "\p{IsTaiLe}".
        /// </summary>
        PositiveUnicodeBlock TaiLe { get; }

#if UNSUPORTED
        /// <summary>
        /// 1980 - 19DF. Value: 
        /// </summary>
        PositiveUnicodeBlock NewTaiLue{ get; }
#endif

        /// <summary>
        /// 19E0 - 19FF. Value: "\p{IsKhmerSymbols}".
        /// </summary>
        PositiveUnicodeBlock KhmerSymbols { get; }

#if UNSUPORTED
        /// <summary>
        /// 1A00 - 1A1F. Value: 
        /// </summary>
        PositiveUnicodeBlock Buginese{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1A20 - 1AAF. Value: 
        /// </summary>
        PositiveUnicodeBlock TaiTham{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1AB0 - 1AFF. Value: 
        /// </summary>
        PositiveUnicodeBlock CombiningDiacriticalMarksExtended{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B00 - 1B7F. Value: 
        /// </summary>
        PositiveUnicodeBlock Balinese{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B80 - 1BBF. Value: 
        /// </summary>
        PositiveUnicodeBlock Sundanese{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BC0 - 1BFF. Value: 
        /// </summary>
        PositiveUnicodeBlock Batak{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C00 - 1C4F. Value: 
        /// </summary>
        PositiveUnicodeBlock Lepcha{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C50 - 1C7F. Value: 
        /// </summary>
        PositiveUnicodeBlock OlChiki{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C80 - 1C8F. Value: 
        /// </summary>
        PositiveUnicodeBlock CyrillicExtendedC{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1C90 - 1CBF. Value: 
        /// </summary>
        PositiveUnicodeBlock GeorgianExtended{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1CC0 - 1CCF. Value: 
        /// </summary>
        PositiveUnicodeBlock SundaneseSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1CD0 - 1CFF. Value: 
        /// </summary>
        PositiveUnicodeBlock VedicExtensions{ get; }
#endif

        /// <summary>
        /// 1D00 - 1D7F. Value: "\p{IsPhoneticExtensions}".
        /// </summary>
        PositiveUnicodeBlock PhoneticExtensions { get; }

#if UNSUPORTED
        /// <summary>
        /// 1D80 - 1DBF. Value: 
        /// </summary>
        PositiveUnicodeBlock PhoneticExtensionsSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1DC0 - 1DFF. Value: 
        /// </summary>
        PositiveUnicodeBlock CombiningDiacriticalMarksSupplement{ get; }
#endif

        /// <summary>
        /// 1E00 - 1EFF. Value: "\p{IsLatinExtendedAdditional}".
        /// </summary>
        PositiveUnicodeBlock LatinExtendedAdditional { get; }

        /// <summary>
        /// 1F00 - 1FFF. Value: "\p{IsGreekExtended}".
        /// </summary>
        PositiveUnicodeBlock GreekExtended { get; }

        /// <summary>
        /// 2000 - 206F. Value: "\p{IsGeneralPunctuation}".
        /// </summary>
        PositiveUnicodeBlock GeneralPunctuation { get; }

        /// <summary>
        /// 2070 - 209F. Value: "\p{IsSuperscriptsandSubscripts}".
        /// </summary>
        PositiveUnicodeBlock SuperscriptsandSubscripts { get; }

        /// <summary>
        /// 20A0 - 20CF. Value: "\p{IsCurrencySymbols}".
        /// </summary>
        PositiveUnicodeBlock CurrencySymbols { get; }

        /// <summary>
        /// 20D0 - 20FF. Value: "\p{IsCombiningDiacriticalMarksforSymbols}".
        /// </summary>
        PositiveUnicodeBlock CombiningDiacriticalMarksforSymbols { get; }

        /// <summary>
        /// 20D0 - 20FF. Value: "\p{"IsCombiningMarksforSymbols"}".
        /// </summary>
        PositiveUnicodeBlock IsCombiningMarksforSymbols { get; }

        /// <summary>
        /// 2100 - 214F. Value: "\p{IsLetterlikeSymbols}".
        /// </summary>
        PositiveUnicodeBlock LetterlikeSymbols { get; }

        /// <summary>
        /// 2150 - 218F. Value: "\p{IsNumberForms}".
        /// </summary>
        PositiveUnicodeBlock NumberForms { get; }

        /// <summary>
        /// 2190 - 21FF. Value: "\p{IsArrows}".
        /// </summary>
        PositiveUnicodeBlock Arrows { get; }

        /// <summary>
        /// 2200 - 22FF. Value: "\p{IsMathematicalOperators}".
        /// </summary>
        PositiveUnicodeBlock MathematicalOperators { get; }

        /// <summary>
        /// 2300 - 23FF. Value: "\p{IsMiscellaneousTechnical}".
        /// </summary>
        PositiveUnicodeBlock MiscellaneousTechnical { get; }

        /// <summary>
        /// 2400 - 243F. Value: "\p{IsControlPictures}".
        /// </summary>
        PositiveUnicodeBlock ControlPictures { get; }

        /// <summary>
        /// 2440 - 245F. Value: "\p{IsOpticalCharacterRecognition}".
        /// </summary>
        PositiveUnicodeBlock OpticalCharacterRecognition { get; }

        /// <summary>
        /// 2460 - 24FF. Value: "\p{IsEnclosedAlphanumerics}".
        /// </summary>
        PositiveUnicodeBlock EnclosedAlphanumerics { get; }

        /// <summary>
        /// 2500 - 257F. Value: "\p{IsBoxDrawing}".
        /// </summary>
        PositiveUnicodeBlock BoxDrawing { get; }

        /// <summary>
        /// 2580 - 259F. Value: "\p{IsBlockElements}".
        /// </summary>
        PositiveUnicodeBlock BlockElements { get; }

        /// <summary>
        /// 25A0 - 25FF. Value: "\p{IsGeometricShapes}".
        /// </summary>
        PositiveUnicodeBlock GeometricShapes { get; }

        /// <summary>
        /// 2600 - 26FF. Value: "\p{IsMiscellaneousSymbols}".
        /// </summary>
        PositiveUnicodeBlock MiscellaneousSymbols { get; }

        /// <summary>
        /// 2700 - 27BF. Value: "\p{IsDingbats}".
        /// </summary>
        PositiveUnicodeBlock Dingbats { get; }

        /// <summary>
        /// 27C0 - 27EF. Value: "\p{IsMiscellaneousMathematicalSymbols-A}".
        /// </summary>
        PositiveUnicodeBlock MiscellaneousMathematicalSymbolsA { get; }

        /// <summary>
        /// 27F0 - 27FF. Value: "\p{IsSupplementalArrows-A}".
        /// </summary>
        PositiveUnicodeBlock SupplementalArrowsA { get; }

        /// <summary>
        /// 2800 - 28FF. Value: "\p{IsBraillePatterns}".
        /// </summary>
        PositiveUnicodeBlock BraillePatterns { get; }

        /// <summary>
        /// 2900 - 297F. Value: "\p{IsSupplementalArrows-B}".
        /// </summary>
        PositiveUnicodeBlock SupplementalArrowsB { get; }

        /// <summary>
        /// 2980 - 29FF. Value: "\p{IsMiscellaneousMathematicalSymbols-B}".
        /// </summary>
        PositiveUnicodeBlock MiscellaneousMathematicalSymbolsB { get; }

        /// <summary>
        /// 2A00 - 2AFF. Value: "\p{IsSupplementalMathematicalOperators}".
        /// </summary>
        PositiveUnicodeBlock SupplementalMathematicalOperators { get; }

        /// <summary>
        /// 2B00 - 2BFF. Value: "\p{IsMiscellaneousSymbolsandArrows}".
        /// </summary>
        PositiveUnicodeBlock MiscellaneousSymbolsandArrows { get; }

#if UNSUPORTED
        /// <summary>
        /// 2C00 - 2C5F. Value: 
        /// </summary>
        PositiveUnicodeBlock Glagolitic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2C60 - 2C7F. Value: 
        /// </summary>
        PositiveUnicodeBlock LatinExtendedC{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2C80 - 2CFF. Value: 
        /// </summary>
        PositiveUnicodeBlock Coptic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D00 - 2D2F. Value: 
        /// </summary>
        PositiveUnicodeBlock GeorgianSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D30 - 2D7F. Value: 
        /// </summary>
        PositiveUnicodeBlock Tifinagh{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2D80 - 2DDF. Value: 
        /// </summary>
        PositiveUnicodeBlock EthiopicExtended{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2DE0 - 2DFF. Value: 
        /// </summary>
        PositiveUnicodeBlock CyrillicExtendedA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2E00 - 2E7F. Value: 
        /// </summary>
        PositiveUnicodeBlock SupplementalPunctuation{ get; }
#endif

        /// <summary>
        /// 2E80 - 2EFF. Value: "\p{IsCJKRadicalsSupplement}".
        /// </summary>
        PositiveUnicodeBlock CJKRadicalsSupplement { get; }

        /// <summary>
        /// 2F00 - 2FDF. Value: "\p{IsKangxiRadicals}".
        /// </summary>
        PositiveUnicodeBlock KangxiRadicals { get; }

        /// <summary>
        /// 2FF0 - 2FFF. Value: "\p{IsIdeographicDescriptionCharacters}".
        /// </summary>
        PositiveUnicodeBlock IdeographicDescriptionCharacters { get; }

        /// <summary>
        /// 3000 - 303F. Value: "\p{IsCJKSymbolsandPunctuation}".
        /// </summary>
        PositiveUnicodeBlock CJKSymbolsandPunctuation { get; }

        /// <summary>
        /// 3040 - 309F. Value: "\p{IsHiragana}".
        /// </summary>
        PositiveUnicodeBlock Hiragana { get; }

        /// <summary>
        /// 30A0 - 30FF. Value: "\p{IsKatakana}".
        /// </summary>
        PositiveUnicodeBlock Katakana { get; }

        /// <summary>
        /// 3100 - 312F. Value: "\p{IsBopomofo}".
        /// </summary>
        PositiveUnicodeBlock Bopomofo { get; }

        /// <summary>
        /// 3130 - 318F. Value: "\p{IsHangulCompatibilityJamo}".
        /// </summary>
        PositiveUnicodeBlock HangulCompatibilityJamo { get; }

        /// <summary>
        /// 3190 - 319F. Value: "\p{IsKanbun}".
        /// </summary>
        PositiveUnicodeBlock Kanbun { get; }

        /// <summary>
        /// 31A0 - 31BF. Value: "\p{IsBopomofoExtended}".
        /// </summary>
        PositiveUnicodeBlock BopomofoExtended { get; }

#if UNSUPORTED
        /// <summary>
        /// 31C0 - 31EF. Value: 
        /// </summary>
        PositiveUnicodeBlock CJKStrokes{ get; }
#endif

        /// <summary>
        /// 31F0 - 31FF. Value: "\p{IsKatakanaPhoneticExtensions}".
        /// </summary>
        PositiveUnicodeBlock KatakanaPhoneticExtensions { get; }

        /// <summary>
        /// 3200 - 32FF. Value: "\p{IsEnclosedCJKLettersandMonths}".
        /// </summary>
        PositiveUnicodeBlock EnclosedCJKLettersandMonths { get; }

        /// <summary>
        /// 3300 - 33FF. Value: "\p{IsCJKCompatibility}".
        /// </summary>
        PositiveUnicodeBlock CJKCompatibility { get; }

        /// <summary>
        /// 3400 - 4DBF. Value: "\p{IsCJKUnifiedIdeographsExtensionA}".
        /// </summary>
        PositiveUnicodeBlock CJKUnifiedIdeographsExtensionA { get; }

        /// <summary>
        /// 4DC0 - 4DFF. Value: "\p{IsYijingHexagramSymbols}".
        /// </summary>
        PositiveUnicodeBlock YijingHexagramSymbols { get; }

        /// <summary>
        /// 4E00 - 9FFF. Value: "\p{IsCJKUnifiedIdeographs}".
        /// </summary>
        PositiveUnicodeBlock CJKUnifiedIdeographs { get; }

        /// <summary>
        /// A000 - A48F. Value: "\p{IsYiSyllables}".
        /// </summary>
        PositiveUnicodeBlock YiSyllables { get; }

        /// <summary>
        /// A490 - A4CF. Value: "\p{IsYiRadicals}".
        /// </summary>
        PositiveUnicodeBlock YiRadicals { get; }

#if UNSUPORTED
        /// <summary>
        /// A4D0 - A4FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Lisu{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A500 - A63F. Value: 
        /// </summary>
        PositiveUnicodeBlock Vai{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A640 - A69F. Value: 
        /// </summary>
        PositiveUnicodeBlock CyrillicExtendedB{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A6A0 - A6FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Bamum{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A700 - A71F. Value: 
        /// </summary>
        PositiveUnicodeBlock ModifierToneLetters{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A720 - A7FF. Value: 
        /// </summary>
        PositiveUnicodeBlock LatinExtendedD{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A800 - A82F. Value: 
        /// </summary>
        PositiveUnicodeBlock SylotiNagri{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A830 - A83F. Value: 
        /// </summary>
        PositiveUnicodeBlock CommonIndicNumberForms{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A840 - A87F. Value: 
        /// </summary>
        PositiveUnicodeBlock Phagspa{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A880 - A8DF. Value: 
        /// </summary>
        PositiveUnicodeBlock Saurashtra{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A8E0 - A8FF. Value: 
        /// </summary>
        PositiveUnicodeBlock DevanagariExtended{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A900 - A92F. Value: 
        /// </summary>
        PositiveUnicodeBlock KayahLi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A930 - A95F. Value: 
        /// </summary>
        PositiveUnicodeBlock Rejang{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A960 - A97F. Value: 
        /// </summary>
        PositiveUnicodeBlock HangulJamoExtendedA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A980 - A9DF. Value: 
        /// </summary>
        PositiveUnicodeBlock Javanese{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// A9E0 - A9FF. Value: 
        /// </summary>
        PositiveUnicodeBlock MyanmarExtendedB{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// AA00 - AA5F. Value: 
        /// </summary>
        PositiveUnicodeBlock Cham{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// AA60 - AA7F. Value: 
        /// </summary>
        PositiveUnicodeBlock MyanmarExtendedA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// AA80 - AADF. Value: 
        /// </summary>
        PositiveUnicodeBlock TaiViet{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// AAE0 - AAFF. Value: 
        /// </summary>
        PositiveUnicodeBlock MeeteiMayekExtensions{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// AB00 - AB2F. Value: 
        /// </summary>
        PositiveUnicodeBlock EthiopicExtendedA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// AB30 - AB6F. Value: 
        /// </summary>
        PositiveUnicodeBlock LatinExtendedE{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// AB70 - ABBF. Value: 
        /// </summary>
        PositiveUnicodeBlock CherokeeSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// ABC0 - ABFF. Value: 
        /// </summary>
        PositiveUnicodeBlock MeeteiMayek{ get; }
#endif

        /// <summary>
        /// AC00 - D7AF. Value: "\p{IsHangulSyllables}".
        /// </summary>
        PositiveUnicodeBlock HangulSyllables { get; }

#if UNSUPORTED
        /// <summary>
        /// D7B0 - D7FF. Value: 
        /// </summary>
        PositiveUnicodeBlock HangulJamoExtendedB{ get; }
#endif

        /// <summary>
        /// D800 - DB7F. Value: "\p{IsHighSurrogates}".
        /// </summary>
        PositiveUnicodeBlock HighSurrogates { get; }

        /// <summary>
        /// DB80 - DBFF. Value: "\p{IsHighPrivateUseSurrogates}".
        /// </summary>
        PositiveUnicodeBlock HighPrivateUseSurrogates { get; }

        /// <summary>
        /// DC00 - DFFF. Value: "\p{IsLowSurrogates}".
        /// </summary>
        PositiveUnicodeBlock LowSurrogates { get; }

        /// <summary>
        /// E000 - F8FF. Value: "\p{IsPrivateUse}".
        /// </summary>
        PositiveUnicodeBlock PrivateUse { get; }

        /// <summary>
        /// E000 - F8FF. Value: "\p{IsPrivateUseArea}".
        /// </summary>
        PositiveUnicodeBlock PrivateUseArea { get; }

        /// <summary>
        /// F900 - FAFF. Value: "\p{IsCJKCompatibilityIdeographs}".
        /// </summary>
        PositiveUnicodeBlock CJKCompatibilityIdeographs { get; }

        /// <summary>
        /// FB00 - FB4F. Value: "\p{IsAlphabeticPresentationForms}".
        /// </summary>
        PositiveUnicodeBlock AlphabeticPresentationForms { get; }

        /// <summary>
        /// FB50 - FDFF. Value: "\p{IsArabicPresentationForms-A}".
        /// </summary>
        PositiveUnicodeBlock ArabicPresentationFormsA { get; }

        /// <summary>
        /// FE00 - FE0F. Value: "\p{IsVariationSelectors}".
        /// </summary>
        PositiveUnicodeBlock VariationSelectors { get; }

#if UNSUPORTED
        /// <summary>
        /// FE10 - FE1F. Value: 
        /// </summary>
        PositiveUnicodeBlock VerticalForms{ get; }
#endif

        /// <summary>
        /// FE20 - FE2F. Value: "\p{IsCombiningHalfMarks}".
        /// </summary>
        PositiveUnicodeBlock CombiningHalfMarks { get; }

        /// <summary>
        /// FE30 - FE4F. Value: "\p{IsCJKCompatibilityForms}".
        /// </summary>
        PositiveUnicodeBlock CJKCompatibilityForms { get; }

        /// <summary>
        /// FE50 - FE6F. Value: "\p{IsSmallFormVariants}".
        /// </summary>
        PositiveUnicodeBlock SmallFormVariants { get; }

        /// <summary>
        /// FE70 - FEFF. Value: "\p{IsArabicPresentationForms-B}".
        /// </summary>
        PositiveUnicodeBlock ArabicPresentationFormsB { get; }

        /// <summary>
        /// FF00 - FFEF. Value: "\p{IsHalfwidthandFullwidthForms}".
        /// </summary>
        PositiveUnicodeBlock HalfwidthandFullwidthForms { get; }

        /// <summary>
        /// FFF0 - FFFF. Value: "\p{IsSpecials}".
        /// </summary>
        PositiveUnicodeBlock Specials { get; }

#if UNSUPORTED
        /// <summary>
        /// 10000 - 1007F. Value: 
        /// </summary>
        PositiveUnicodeBlock LinearBSyllabary{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10080 - 100FF. Value: 
        /// </summary>
        PositiveUnicodeBlock LinearBIdeograms{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10100 - 1013F. Value: 
        /// </summary>
        PositiveUnicodeBlock AegeanNumbers{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10140 - 1018F. Value: 
        /// </summary>
        PositiveUnicodeBlock AncientGreekNumbers{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10190 - 101CF. Value: 
        /// </summary>
        PositiveUnicodeBlock AncientSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 101D0 - 101FF. Value: 
        /// </summary>
        PositiveUnicodeBlock PhaistosDisc{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10280 - 1029F. Value: 
        /// </summary>
        PositiveUnicodeBlock Lycian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 102A0 - 102DF. Value: 
        /// </summary>
        PositiveUnicodeBlock Carian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 102E0 - 102FF. Value: 
        /// </summary>
        PositiveUnicodeBlock CopticEpactNumbers{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10300 - 1032F. Value: 
        /// </summary>
        PositiveUnicodeBlock OldItalic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10330 - 1034F. Value: 
        /// </summary>
        PositiveUnicodeBlock Gothic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10350 - 1037F. Value: 
        /// </summary>
        PositiveUnicodeBlock OldPermic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10380 - 1039F. Value: 
        /// </summary>
        PositiveUnicodeBlock Ugaritic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 103A0 - 103DF. Value: 
        /// </summary>
        PositiveUnicodeBlock OldPersian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10400 - 1044F. Value: 
        /// </summary>
        PositiveUnicodeBlock Deseret{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10450 - 1047F. Value: 
        /// </summary>
        PositiveUnicodeBlock Shavian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10480 - 104AF. Value: 
        /// </summary>
        PositiveUnicodeBlock Osmanya{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 104B0 - 104FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Osage{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10500 - 1052F. Value: 
        /// </summary>
        PositiveUnicodeBlock Elbasan{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10530 - 1056F. Value: 
        /// </summary>
        PositiveUnicodeBlock CaucasianAlbanian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10600 - 1077F. Value: 
        /// </summary>
        PositiveUnicodeBlock LinearA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10800 - 1083F. Value: 
        /// </summary>
        PositiveUnicodeBlock CypriotSyllabary{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10840 - 1085F. Value: 
        /// </summary>
        PositiveUnicodeBlock ImperialAramaic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10860 - 1087F. Value: 
        /// </summary>
        PositiveUnicodeBlock Palmyrene{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10880 - 108AF. Value: 
        /// </summary>
        PositiveUnicodeBlock Nabataean{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 108E0 - 108FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Hatran{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10900 - 1091F. Value: 
        /// </summary>
        PositiveUnicodeBlock Phoenician{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10920 - 1093F. Value: 
        /// </summary>
        PositiveUnicodeBlock Lydian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10980 - 1099F. Value: 
        /// </summary>
        PositiveUnicodeBlock MeroiticHieroglyphs{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 109A0 - 109FF. Value: 
        /// </summary>
        PositiveUnicodeBlock MeroiticCursive{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A00 - 10A5F. Value: 
        /// </summary>
        PositiveUnicodeBlock Kharoshthi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A60 - 10A7F. Value: 
        /// </summary>
        PositiveUnicodeBlock OldSouthArabian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10A80 - 10A9F. Value: 
        /// </summary>
        PositiveUnicodeBlock OldNorthArabian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10AC0 - 10AFF. Value: 
        /// </summary>
        PositiveUnicodeBlock Manichaean{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B00 - 10B3F. Value: 
        /// </summary>
        PositiveUnicodeBlock Avestan{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B40 - 10B5F. Value: 
        /// </summary>
        PositiveUnicodeBlock InscriptionalParthian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B60 - 10B7F. Value: 
        /// </summary>
        PositiveUnicodeBlock InscriptionalPahlavi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10B80 - 10BAF. Value: 
        /// </summary>
        PositiveUnicodeBlock PsalterPahlavi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10C00 - 10C4F. Value: 
        /// </summary>
        PositiveUnicodeBlock OldTurkic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10C80 - 10CFF. Value: 
        /// </summary>
        PositiveUnicodeBlock OldHungarian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10D00 - 10D3F. Value: 
        /// </summary>
        PositiveUnicodeBlock HanifiRohingya{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10E60 - 10E7F. Value: 
        /// </summary>
        PositiveUnicodeBlock RumiNumeralSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10F00 - 10F2F. Value: 
        /// </summary>
        PositiveUnicodeBlock OldSogdian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10F30 - 10F6F. Value: 
        /// </summary>
        PositiveUnicodeBlock Sogdian{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 10FE0 - 10FFF. Value: 
        /// </summary>
        PositiveUnicodeBlock Elymaic{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11000 - 1107F. Value: 
        /// </summary>
        PositiveUnicodeBlock Brahmi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11080 - 110CF. Value: 
        /// </summary>
        PositiveUnicodeBlock Kaithi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 110D0 - 110FF. Value: 
        /// </summary>
        PositiveUnicodeBlock SoraSompeng{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11100 - 1114F. Value: 
        /// </summary>
        PositiveUnicodeBlock Chakma{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11150 - 1117F. Value: 
        /// </summary>
        PositiveUnicodeBlock Mahajani{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11180 - 111DF. Value: 
        /// </summary>
        PositiveUnicodeBlock Sharada{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 111E0 - 111FF. Value: 
        /// </summary>
        PositiveUnicodeBlock SinhalaArchaicNumbers{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11200 - 1124F. Value: 
        /// </summary>
        PositiveUnicodeBlock Khojki{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11280 - 112AF. Value: 
        /// </summary>
        PositiveUnicodeBlock Multani{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 112B0 - 112FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Khudawadi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11300 - 1137F. Value: 
        /// </summary>
        PositiveUnicodeBlock Grantha{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11400 - 1147F. Value: 
        /// </summary>
        PositiveUnicodeBlock Newa{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11480 - 114DF. Value: 
        /// </summary>
        PositiveUnicodeBlock Tirhuta{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11580 - 115FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Siddham{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11600 - 1165F. Value: 
        /// </summary>
        PositiveUnicodeBlock Modi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11660 - 1167F. Value: 
        /// </summary>
        PositiveUnicodeBlock MongolianSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11680 - 116CF. Value: 
        /// </summary>
        PositiveUnicodeBlock Takri{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11700 - 1173F. Value: 
        /// </summary>
        PositiveUnicodeBlock Ahom{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11800 - 1184F. Value: 
        /// </summary>
        PositiveUnicodeBlock Dogra{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 118A0 - 118FF. Value: 
        /// </summary>
        PositiveUnicodeBlock WarangCiti{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 119A0 - 119FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Nandinagari{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11A00 - 11A4F. Value: 
        /// </summary>
        PositiveUnicodeBlock ZanabazarSquare{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11A50 - 11AAF. Value: 
        /// </summary>
        PositiveUnicodeBlock Soyombo{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11AC0 - 11AFF. Value: 
        /// </summary>
        PositiveUnicodeBlock PauCinHau{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11C00 - 11C6F. Value: 
        /// </summary>
        PositiveUnicodeBlock Bhaiksuki{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11C70 - 11CBF. Value: 
        /// </summary>
        PositiveUnicodeBlock Marchen{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11D00 - 11D5F. Value: 
        /// </summary>
        PositiveUnicodeBlock MasaramGondi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11D60 - 11DAF. Value: 
        /// </summary>
        PositiveUnicodeBlock GunjalaGondi{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11EE0 - 11EFF. Value: 
        /// </summary>
        PositiveUnicodeBlock Makasar{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 11FC0 - 11FFF. Value: 
        /// </summary>
        PositiveUnicodeBlock TamilSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 12000 - 123FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Cuneiform{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 12400 - 1247F. Value: 
        /// </summary>
        PositiveUnicodeBlock CuneiformNumbersandPunctuation{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 12480 - 1254F. Value: 
        /// </summary>
        PositiveUnicodeBlock EarlyDynasticCuneiform{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 13000 - 1342F. Value: 
        /// </summary>
        PositiveUnicodeBlock EgyptianHieroglyphs{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 13430 - 1343F. Value: 
        /// </summary>
        PositiveUnicodeBlock EgyptianHieroglyphFormatControls{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 14400 - 1467F. Value: 
        /// </summary>
        PositiveUnicodeBlock AnatolianHieroglyphs{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 16800 - 16A3F. Value: 
        /// </summary>
        PositiveUnicodeBlock BamumSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 16A40 - 16A6F. Value: 
        /// </summary>
        PositiveUnicodeBlock Mro{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 16AD0 - 16AFF. Value: 
        /// </summary>
        PositiveUnicodeBlock BassaVah{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 16B00 - 16B8F. Value: 
        /// </summary>
        PositiveUnicodeBlock PahawhHmong{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 16E40 - 16E9F. Value: 
        /// </summary>
        PositiveUnicodeBlock Medefaidrin{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 16F00 - 16F9F. Value: 
        /// </summary>
        PositiveUnicodeBlock Miao{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 16FE0 - 16FFF. Value: 
        /// </summary>
        PositiveUnicodeBlock IdeographicSymbolsandPunctuation{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 17000 - 187FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Tangut{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 18800 - 18AFF. Value: 
        /// </summary>
        PositiveUnicodeBlock TangutComponents{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B000 - 1B0FF. Value: 
        /// </summary>
        PositiveUnicodeBlock KanaSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B100 - 1B12F. Value: 
        /// </summary>
        PositiveUnicodeBlock KanaExtendedA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B130 - 1B16F. Value: 
        /// </summary>
        PositiveUnicodeBlock SmallKanaExtension{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1B170 - 1B2FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Nushu{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BC00 - 1BC9F. Value: 
        /// </summary>
        PositiveUnicodeBlock Duployan{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1BCA0 - 1BCAF. Value: 
        /// </summary>
        PositiveUnicodeBlock ShorthandFormatControls{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D000 - 1D0FF. Value: 
        /// </summary>
        PositiveUnicodeBlock ByzantineMusicalSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D100 - 1D1FF. Value: 
        /// </summary>
        PositiveUnicodeBlock MusicalSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D200 - 1D24F. Value: 
        /// </summary>
        PositiveUnicodeBlock AncientGreekMusicalNotation{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D2E0 - 1D2FF. Value: 
        /// </summary>
        PositiveUnicodeBlock MayanNumerals{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D300 - 1D35F. Value: 
        /// </summary>
        PositiveUnicodeBlock TaiXuanJingSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D360 - 1D37F. Value: 
        /// </summary>
        PositiveUnicodeBlock CountingRodNumerals{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D400 - 1D7FF. Value: 
        /// </summary>
        PositiveUnicodeBlock MathematicalAlphanumericSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1D800 - 1DAAF. Value: 
        /// </summary>
        PositiveUnicodeBlock SuttonSignWriting{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E000 - 1E02F. Value: 
        /// </summary>
        PositiveUnicodeBlock GlagoliticSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E100 - 1E14F. Value: 
        /// </summary>
        PositiveUnicodeBlock NyiakengPuachueHmong{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E2C0 - 1E2FF. Value: 
        /// </summary>
        PositiveUnicodeBlock Wancho{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E800 - 1E8DF. Value: 
        /// </summary>
        PositiveUnicodeBlock MendeKikakui{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1E900 - 1E95F. Value: 
        /// </summary>
        PositiveUnicodeBlock Adlam{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1EC70 - 1ECBF. Value: 
        /// </summary>
        PositiveUnicodeBlock IndicSiyaqNumbers{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1ED00 - 1ED4F. Value: 
        /// </summary>
        PositiveUnicodeBlock OttomanSiyaqNumbers{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1EE00 - 1EEFF. Value: 
        /// </summary>
        PositiveUnicodeBlock ArabicMathematicalAlphabeticSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F000 - 1F02F. Value: 
        /// </summary>
        PositiveUnicodeBlock MahjongTiles{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F030 - 1F09F. Value: 
        /// </summary>
        PositiveUnicodeBlock DominoTiles{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F0A0 - 1F0FF. Value: 
        /// </summary>
        PositiveUnicodeBlock PlayingCards{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F100 - 1F1FF. Value: 
        /// </summary>
        PositiveUnicodeBlock EnclosedAlphanumericSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F200 - 1F2FF. Value: 
        /// </summary>
        PositiveUnicodeBlock EnclosedIdeographicSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F300 - 1F5FF. Value: 
        /// </summary>
        PositiveUnicodeBlock MiscellaneousSymbolsandPictographs{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F600 - 1F64F. Value: 
        /// </summary>
        PositiveUnicodeBlock Emoticons{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F650 - 1F67F. Value: 
        /// </summary>
        PositiveUnicodeBlock OrnamentalDingbats{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F680 - 1F6FF. Value: 
        /// </summary>
        PositiveUnicodeBlock TransportandMapSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F700 - 1F77F. Value: 
        /// </summary>
        PositiveUnicodeBlock AlchemicalSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F780 - 1F7FF. Value: 
        /// </summary>
        PositiveUnicodeBlock GeometricShapesExtended{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F800 - 1F8FF. Value: 
        /// </summary>
        PositiveUnicodeBlock SupplementalArrowsC{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1F900 - 1F9FF. Value: 
        /// </summary>
        PositiveUnicodeBlock SupplementalSymbolsandPictographs{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1FA00 - 1FA6F. Value: 
        /// </summary>
        PositiveUnicodeBlock ChessSymbols{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 1FA70 - 1FAFF. Value: 
        /// </summary>
        PositiveUnicodeBlock SymbolsandPictographsExtendedA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 20000 - 2A6DF. Value: 
        /// </summary>
        PositiveUnicodeBlock CJKUnifiedIdeographsExtensionB{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2A700 - 2B73F. Value: 
        /// </summary>
        PositiveUnicodeBlock CJKUnifiedIdeographsExtensionC{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2B740 - 2B81F. Value: 
        /// </summary>
        PositiveUnicodeBlock CJKUnifiedIdeographsExtensionD{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2B820 - 2CEAF. Value: 
        /// </summary>
        PositiveUnicodeBlock CJKUnifiedIdeographsExtensionE{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2CEB0 - 2EBEF. Value: 
        /// </summary>
        PositiveUnicodeBlock CJKUnifiedIdeographsExtensionF{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 2F800 - 2FA1F. Value: 
        /// </summary>
        PositiveUnicodeBlock CJKCompatibilityIdeographsSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// E0000 - E007F. Value: 
        /// </summary>
        PositiveUnicodeBlock Tags{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// E0100 - E01EF. Value: 
        /// </summary>
        PositiveUnicodeBlock VariationSelectorsSupplement{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// F0000 - FFFFF. Value: 
        /// </summary>
        PositiveUnicodeBlock SupplementaryPrivateUseAreaA{ get; }
#endif

#if UNSUPORTED
        /// <summary>
        /// 100000 - 10FF. Value: 
        /// </summary>
        PositiveUnicodeBlock SupplementaryPrivateUseAreaB{ get; }
#endif

    }
}
