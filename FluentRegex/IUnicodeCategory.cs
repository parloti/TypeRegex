#undef UNSUPORTED
/// <summary>
/// Not supported in .Net 4.8.
/// </summary>

using System;

namespace FluentRegex
{
    /// <summary>
    /// Unicode general categories values list.
    /// </summary>
    /// <remarks>
    /// Based on: 
    /// https://www.unicode.org/reports/tr44/#General_Category_Values, 
    /// https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions?view=netframework-4.3#SupportedUnicodeGeneralCategories and 
    /// https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-classes-in-regular-expressions?view=netframework-4.8#SupportedUnicodeGeneralCategories.
    /// Accessed in: 26/05/2019.
    /// </remarks>
    internal interface IUnicodeCategory
    {
        #region Letter

        #region Cased letter

        /// <summary>
        /// An uppercase letter. Value: "Lu".
        /// </summary>
        PositiveUnicodeCategory UppercaseLetter { get; }

        /// <summary>
        /// A lowercase letter. Value : "Ll".
        /// </summary>
        PositiveUnicodeCategory LowercaseLetter { get; }

        /// <summary>
        /// A digraphic character, with first part uppercase. Value: "Lt"
        /// </summary>
        PositiveUnicodeCategory TitlecaseLetter { get; }

#if UNSUPORTED
        /// <summary>
        /// Cased letter. Value: "LC" ("LU | Ll | Lt").
        /// <para><see cref="UppercaseLetter"/> | <see cref="LowercaseLetter"/> | <see cref="TitlecaseLetter"/>.</para>
        /// </summary>
        PositiveUnicodeCategory CasedLetter { get; }
#endif

        #endregion

        /// <summary>
        /// A modifier letter. Value: "Lm".
        /// </summary>
        PositiveUnicodeCategory ModifierLetter { get; }

        /// <summary>
        /// Other letters, including syllables and ideographs. Value: "Lo".
        /// </summary>
        PositiveUnicodeCategory OtherLetter { get; }

        /// <summary>
        /// All letter characters. Value: "L" ("Lu | Ll | Lt | Lm | Lo").
        /// <para><see cref="UppercaseLetter"/> | <see cref="LowercaseLetter"/> | <see cref="TitlecaseLetter"/> | <see cref="ModifierLetter"/> | <see cref="OtherLetter"/>.</para>
        /// </summary>
        PositiveUnicodeCategory Letter { get; }

        #endregion

        #region Mark

        /// <summary>
        ///  A nonspacing combining mark (zero advance width). Value: "Mn".
        /// </summary>
        PositiveUnicodeCategory NonspacingMark { get; }

        /// <summary>
        /// A spacing combining mark (positive advance width). Value: "Mc".
        /// </summary>
        PositiveUnicodeCategory SpacingMark { get; }

        /// <summary>
        /// An enclosing combining mark. Value: "Me".
        /// </summary>
        PositiveUnicodeCategory EnclosingMark { get; }

        /// <summary>
        /// All diacritic marks. Value: "M" ("Mn | Mc | Me").
        /// <para><see cref="NonspacingMark"/> | <see cref="SpacingMark"/> | <see cref="EnclosingMark"/>.</para>
        /// </summary>
        PositiveUnicodeCategory Mark { get; }

        #endregion

        #region Number

        /// <summary>
        /// A decimal digit. Value: "Nd".
        /// </summary>
        PositiveUnicodeCategory DecimalNumber { get; }

        /// <summary>
        /// A letterlike numeric character. Value: "Nl".
        /// </summary>
        PositiveUnicodeCategory LetterNumber { get; }

        /// <summary>
        /// A numeric character of other type. Value: "No".
        /// </summary>
        PositiveUnicodeCategory OtherNumber { get; }

        /// <summary>
        /// All numbers. Value: "N" ("Nd | Nl | No").
        /// <para><see cref="DecimalNumber"/> | <see cref="LetterNumber"/> | <see cref="OtherNumber"/>.</para>
        /// </summary>
        PositiveUnicodeCategory Number { get; }

        #endregion

        #region Punctuation

        /// <summary>
        /// A connecting punctuation mark, like a tie. Value: "Pc".
        /// </summary>
        PositiveUnicodeCategory ConnectorPunctuation { get; }

        /// <summary>
        /// A dash or hyphen punctuation mark. Value: "Pd".
        /// </summary>
        PositiveUnicodeCategory DashPunctuation { get; }

        /// <summary>
        /// An opening punctuation mark(of a pair). Value: "Ps".
        /// </summary>
        PositiveUnicodeCategory OpenPunctuation { get; }

        /// <summary>
        /// A closing punctuation mark(of a pair). Value: "Pe".
        /// </summary>
        PositiveUnicodeCategory ClosePunctuation { get; }

        /// <summary>
        /// An initial quotation mark. Value: "Pi".
        /// </summary>
        PositiveUnicodeCategory InitialPunctuation { get; }

        /// <summary>
        /// A final quotation mark. Value: "Pf"
        /// </summary>
        PositiveUnicodeCategory FinalPunctuation { get; }

        /// <summary>
        /// A punctuation mark of other type. Value: "Po"
        /// </summary>
        PositiveUnicodeCategory OtherPunctuation { get; }

        /// <summary>
        /// All punctuation characters. Value : "P" ("Pc | Pd | Ps | Pe | Pi | Pf | Po").
        /// <para><see cref="ConnectorPunctuation"/> | <see cref="DashPunctuation"/> | <see cref="OpenPunctuation"/> | <see cref="ClosePunctuation"/> | <see cref="InitialPunctuation"/> | <see cref="FinalPunctuation"/> | <see cref="OtherPunctuation"/>.</para>
        /// </summary>
        PositiveUnicodeCategory Punctuation { get; }

        #endregion

        #region Symbol

        /// <summary>
        /// A symbol of mathematical use. Value: "Sm".
        /// </summary>
        PositiveUnicodeCategory MathSymbol { get; }

        /// <summary>
        /// A currency sign. Value: "Sc".
        /// </summary>
        PositiveUnicodeCategory CurrencySymbol { get; }

        /// <summary>
        /// A non-letterlike modifier symbol. Value: "Sk".
        /// </summary>
        PositiveUnicodeCategory ModifierSymbol { get; }

        /// <summary>
        /// A symbol of other type. Value: "So".
        /// </summary>
        PositiveUnicodeCategory OtherSymbol { get; }

        /// <summary>
        /// All symbols. Value: "S" ("Sm | Sc | Sk | So").
        /// <para><see cref="MathSymbol"/> | <see cref="CurrencySymbol"/> | <see cref="ModifierSymbol"/> | <see cref="OtherSymbol"/>.</para>
        /// </summary>
        PositiveUnicodeCategory Symbol { get; }

        #endregion

        #region Separator

        /// <summary>
        /// A space character(of various non-zero widths). Value: "Zs".
        /// </summary>
        PositiveUnicodeCategory SpaceSeparator { get; }

        /// <summary>
        /// U+2028 LINE SEPARATOR only. Value: "Zl".
        /// </summary>
        PositiveUnicodeCategory LineSeparator { get; }

        /// <summary>
        /// U+2029 PARAGRAPH SEPARATOR only. Value: "Zp".
        /// </summary>
        PositiveUnicodeCategory ParagraphSeparator { get; }

        /// <summary>
        /// All separator characters. Value: "Z" ("Zs | Zl | Zp").
        /// <para><see cref="SpaceSeparator"/> | <see cref="LineSeparator"/> | <see cref="ParagraphSeparator"/>.</para>
        /// </summary>
        PositiveUnicodeCategory Separator { get; }

        #endregion

        #region Other

        /// <summary>
        /// A C0 or C1 control code. Value: "Cc".
        /// </summary>
        PositiveUnicodeCategory Control { get; }

        /// <summary>
        /// A format control character. Value: "Cf".
        /// </summary>
        PositiveUnicodeCategory Format { get; }

        /// <summary>
        /// A surrogate code point. Value: "Cs".
        /// </summary>
        PositiveUnicodeCategory Surrogate { get; }

        /// <summary>
        /// A private-use character. Value: "Co".
        /// </summary>
        PositiveUnicodeCategory PrivateUse { get; }

        /// <summary>
        /// A reserved unassigned code point or a noncharacter. Value: "Cn".
        /// </summary>
        PositiveUnicodeCategory Unassigned { get; }

        /// <summary>
        /// All control characters. Value "C" ("Cc | Cf | Cs | Co | Cn").
        /// <para><see cref="Control"/> | <see cref="Format"/> | <see cref="Surrogate"/> | <see cref="PrivateUse"/> | <see cref="Unassigned"/>.</para>
        /// </summary>
        PositiveUnicodeCategory Other { get; }

        #endregion
    }
}