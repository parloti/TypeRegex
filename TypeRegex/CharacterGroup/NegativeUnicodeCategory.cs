// Not supported in .Net 4.8.
#undef UNSUPORTED

using System;
using System.Text.RegularExpressions;

namespace TypeRegex
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
    public class NegativeUnicodeCategory: NegativeUnicodeGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeUnicodeCategory"/> class.
        /// </summary>
        /// <param name="name">The category name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentException"><paramref name="name"/> is <see cref="string.Empty"/> or consists only of white-space characters.</exception>
        private NegativeUnicodeCategory(string name):base(name)
        {
        }

        #region Letter

        #region Cased letter

        /// <summary>
        /// An uppercase letter. Value: "Lu".
        /// </summary>
        public static NegativeUnicodeCategory UppercaseLetter { get; } = new NegativeUnicodeCategory("Lu");

        /// <summary>
        /// A lowercase letter. Value : "Ll".
        /// </summary>
        public static NegativeUnicodeCategory LowercaseLetter { get; } = new NegativeUnicodeCategory("Ll");

        /// <summary>
        /// A digraphic character, with first part uppercase. Value: "Lt"
        /// </summary>
        public static NegativeUnicodeCategory TitlecaseLetter { get; } = new NegativeUnicodeCategory("Lt");

#if UNSUPORTED
        /// <summary>
        /// Cased letter. Value: "LC" ("LU | Ll | Lt").
        /// <para><see cref="UppercaseLetter"/> | <see cref="LowercaseLetter"/> | <see cref="TitlecaseLetter"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory CasedLetter { get; } = new NegativeUnicodeCategory("LC");
#endif

        #endregion

        /// <summary>
        /// A modifier letter. Value: "Lm".
        /// </summary>
        public static NegativeUnicodeCategory ModifierLetter { get; } = new NegativeUnicodeCategory("Lm");

        /// <summary>
        /// Other letters, including syllables and ideographs. Value: "Lo".
        /// </summary>
        public static NegativeUnicodeCategory OtherLetter { get; } = new NegativeUnicodeCategory("Lo");

        /// <summary>
        /// All letter characters. Value: "L" ("Lu | Ll | Lt | Lm | Lo").
        /// <para><see cref="UppercaseLetter"/> | <see cref="LowercaseLetter"/> | <see cref="TitlecaseLetter"/> | <see cref="ModifierLetter"/> | <see cref="OtherLetter"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory Letter { get; } = new NegativeUnicodeCategory("L");

        #endregion

        #region Mark

        /// <summary>
        ///  A nonspacing combining mark (zero advance width). Value: "Mn".
        /// </summary>
        public static NegativeUnicodeCategory NonspacingMark { get; } = new NegativeUnicodeCategory("Mn");

        /// <summary>
        /// A spacing combining mark (positive advance width). Value: "Mc".
        /// </summary>
        public static NegativeUnicodeCategory SpacingMark { get; } = new NegativeUnicodeCategory("Mc");

        /// <summary>
        /// An enclosing combining mark. Value: "Me".
        /// </summary>
        public static NegativeUnicodeCategory EnclosingMark { get; } = new NegativeUnicodeCategory("Me");

        /// <summary>
        /// All diacritic marks. Value: "M" ("Mn | Mc | Me").
        /// <para><see cref="NonspacingMark"/> | <see cref="SpacingMark"/> | <see cref="EnclosingMark"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory Mark { get; } = new NegativeUnicodeCategory("M");

        #endregion

        #region Number

        /// <summary>
        /// A decimal digit. Value: "Nd".
        /// </summary>
        public static NegativeUnicodeCategory DecimalNumber { get; } = new NegativeUnicodeCategory("Nd");

        /// <summary>
        /// A letterlike numeric character. Value: "Nl".
        /// </summary>
        public static NegativeUnicodeCategory LetterNumber { get; } = new NegativeUnicodeCategory("Nl");

        /// <summary>
        /// A numeric character of other type. Value: "No".
        /// </summary>
        public static NegativeUnicodeCategory OtherNumber { get; } = new NegativeUnicodeCategory("No");

        /// <summary>
        /// All numbers. Value: "N" ("Nd | Nl | No").
        /// <para><see cref="DecimalNumber"/> | <see cref="LetterNumber"/> | <see cref="OtherNumber"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory Number { get; } = new NegativeUnicodeCategory("N");

        #endregion

        #region Punctuation

        /// <summary>
        /// A connecting punctuation mark, like a tie. Value: "Pc".
        /// </summary>
        public static NegativeUnicodeCategory ConnectorPunctuation { get; } = new NegativeUnicodeCategory("Pc");

        /// <summary>
        /// A dash or hyphen punctuation mark. Value: "Pd".
        /// </summary>
        public static NegativeUnicodeCategory DashPunctuation { get; } = new NegativeUnicodeCategory("Pd");

        /// <summary>
        /// An opening punctuation mark(of a pair). Value: "Ps".
        /// </summary>
        public static NegativeUnicodeCategory OpenPunctuation { get; } = new NegativeUnicodeCategory("Ps");

        /// <summary>
        /// A closing punctuation mark(of a pair). Value: "Pe".
        /// </summary>
        public static NegativeUnicodeCategory ClosePunctuation { get; } = new NegativeUnicodeCategory("Pe");

        /// <summary>
        /// An initial quotation mark. Value: "Pi".
        /// </summary>
        public static NegativeUnicodeCategory InitialPunctuation { get; } = new NegativeUnicodeCategory("Pi");

        /// <summary>
        /// A final quotation mark. Value: "Pf"
        /// </summary>
        public static NegativeUnicodeCategory FinalPunctuation { get; } = new NegativeUnicodeCategory("Pf");

        /// <summary>
        /// A punctuation mark of other type. Value: "Po"
        /// </summary>
        public static NegativeUnicodeCategory OtherPunctuation { get; } = new NegativeUnicodeCategory("Po");

        /// <summary>
        /// All punctuation characters. Value : "P" ("Pc | Pd | Ps | Pe | Pi | Pf | Po").
        /// <para><see cref="ConnectorPunctuation"/> | <see cref="DashPunctuation"/> | <see cref="OpenPunctuation"/> | <see cref="ClosePunctuation"/> | <see cref="InitialPunctuation"/> | <see cref="FinalPunctuation"/> | <see cref="OtherPunctuation"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory Punctuation { get; } = new NegativeUnicodeCategory("P");

        #endregion

        #region Symbol

        /// <summary>
        /// A symbol of mathematical use. Value: "Sm".
        /// </summary>
        public static NegativeUnicodeCategory MathSymbol { get; } = new NegativeUnicodeCategory("Sm");

        /// <summary>
        /// A currency sign. Value: "Sc".
        /// </summary>
        public static NegativeUnicodeCategory CurrencySymbol { get; } = new NegativeUnicodeCategory("Sc");

        /// <summary>
        /// A non-letterlike modifier symbol. Value: "Sk".
        /// </summary>
        public static NegativeUnicodeCategory ModifierSymbol { get; } = new NegativeUnicodeCategory("Sk");

        /// <summary>
        /// A symbol of other type. Value: "So".
        /// </summary>
        public static NegativeUnicodeCategory OtherSymbol { get; } = new NegativeUnicodeCategory("So");

        /// <summary>
        /// All symbols. Value: "S" ("Sm | Sc | Sk | So").
        /// <para><see cref="MathSymbol"/> | <see cref="CurrencySymbol"/> | <see cref="ModifierSymbol"/> | <see cref="OtherSymbol"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory Symbol { get; } = new NegativeUnicodeCategory("S");

        #endregion

        #region Separator

        /// <summary>
        /// A space character(of various non-zero widths). Value: "Zs".
        /// </summary>
        public static NegativeUnicodeCategory SpaceSeparator { get; } = new NegativeUnicodeCategory("Zs");

        /// <summary>
        /// U+2028 LINE SEPARATOR only. Value: "Zl".
        /// </summary>
        public static NegativeUnicodeCategory LineSeparator { get; } = new NegativeUnicodeCategory("Zl");

        /// <summary>
        /// U+2029 PARAGRAPH SEPARATOR only. Value: "Zp".
        /// </summary>
        public static NegativeUnicodeCategory ParagraphSeparator { get; } = new NegativeUnicodeCategory("Zp");

        /// <summary>
        /// All separator characters. Value: "Z" ("Zs | Zl | Zp").
        /// <para><see cref="SpaceSeparator"/> | <see cref="LineSeparator"/> | <see cref="ParagraphSeparator"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory Separator { get; } = new NegativeUnicodeCategory("Z");

        #endregion

        #region Other

        /// <summary>
        /// A C0 or C1 control code. Value: "Cc".
        /// </summary>
        public static NegativeUnicodeCategory Control { get; } = new NegativeUnicodeCategory("Cc");

        /// <summary>
        /// A format control character. Value: "Cf".
        /// </summary>
        public static NegativeUnicodeCategory Format { get; } = new NegativeUnicodeCategory("Cf");

        /// <summary>
        /// A surrogate code point. Value: "Cs".
        /// </summary>
        public static NegativeUnicodeCategory Surrogate { get; } = new NegativeUnicodeCategory("Cs");

        /// <summary>
        /// A private-use character. Value: "Co".
        /// </summary>
        public static NegativeUnicodeCategory PrivateUse { get; } = new NegativeUnicodeCategory("Co");

        /// <summary>
        /// A reserved unassigned code point or a noncharacter. Value: "Cn".
        /// </summary>
        public static NegativeUnicodeCategory Unassigned { get; } = new NegativeUnicodeCategory("Cn");

        /// <summary>
        /// All control characters. Value "C" ("Cc | Cf | Cs | Co | Cn").
        /// <para><see cref="Control"/> | <see cref="Format"/> | <see cref="Surrogate"/> | <see cref="PrivateUse"/> | <see cref="Unassigned"/>.</para>
        /// </summary>
        public static NegativeUnicodeCategory Other { get; } = new NegativeUnicodeCategory("C");

        #endregion
    }
}
