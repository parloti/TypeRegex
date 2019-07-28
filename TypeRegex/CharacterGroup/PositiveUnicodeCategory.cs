// Not supported in .Net 4.8.
#undef UNSUPORTED

using System;

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
    public class PositiveUnicodeCategory : PositiveUnicodeGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveUnicodeCategory"/> class.
        /// </summary>
        /// <param name="name">The category name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentException"><paramref name="name"/> is <see cref="string.Empty"/> or consists only of white-space characters.</exception>
        private PositiveUnicodeCategory(string name):base(name)
        {
        }

        #region Letter

        #region Cased letter

        /// <summary>
        /// An uppercase letter. Value: "Lu".
        /// </summary>
        public static PositiveUnicodeCategory UppercaseLetter { get; } = new PositiveUnicodeCategory("Lu");

        /// <summary>
        /// A lowercase letter. Value : "Ll".
        /// </summary>
        public static PositiveUnicodeCategory LowercaseLetter { get; } = new PositiveUnicodeCategory("Ll");

        /// <summary>
        /// A digraphic character, with first part uppercase. Value: "Lt"
        /// </summary>
        public static PositiveUnicodeCategory TitlecaseLetter { get; } = new PositiveUnicodeCategory("Lt");

#if UNSUPORTED
        /// <summary>
        /// Cased letter. Value: "LC" ("LU | Ll | Lt").
        /// <para><see cref="UppercaseLetter"/> | <see cref="LowercaseLetter"/> | <see cref="TitlecaseLetter"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory CasedLetter { get; } = new PositiveUnicodeCategory("LC");
#endif

        #endregion

        /// <summary>
        /// A modifier letter. Value: "Lm".
        /// </summary>
        public static PositiveUnicodeCategory ModifierLetter { get; } = new PositiveUnicodeCategory("Lm");

        /// <summary>
        /// Other letters, including syllables and ideographs. Value: "Lo".
        /// </summary>
        public static PositiveUnicodeCategory OtherLetter { get; } = new PositiveUnicodeCategory("Lo");

        /// <summary>
        /// All letter characters. Value: "L" ("Lu | Ll | Lt | Lm | Lo").
        /// <para><see cref="UppercaseLetter"/> | <see cref="LowercaseLetter"/> | <see cref="TitlecaseLetter"/> | <see cref="ModifierLetter"/> | <see cref="OtherLetter"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory Letter { get; } = new PositiveUnicodeCategory("L");

        #endregion

        #region Mark

        /// <summary>
        ///  A nonspacing combining mark (zero advance width). Value: "Mn".
        /// </summary>
        public static PositiveUnicodeCategory NonspacingMark { get; } = new PositiveUnicodeCategory("Mn");

        /// <summary>
        /// A spacing combining mark (positive advance width). Value: "Mc".
        /// </summary>
        public static PositiveUnicodeCategory SpacingMark { get; } = new PositiveUnicodeCategory("Mc");

        /// <summary>
        /// An enclosing combining mark. Value: "Me".
        /// </summary>
        public static PositiveUnicodeCategory EnclosingMark { get; } = new PositiveUnicodeCategory("Me");

        /// <summary>
        /// All diacritic marks. Value: "M" ("Mn | Mc | Me").
        /// <para><see cref="NonspacingMark"/> | <see cref="SpacingMark"/> | <see cref="EnclosingMark"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory Mark { get; } = new PositiveUnicodeCategory("M");

        #endregion

        #region Number

        /// <summary>
        /// A decimal digit. Value: "Nd".
        /// </summary>
        public static PositiveUnicodeCategory DecimalNumber { get; } = new PositiveUnicodeCategory("Nd");

        /// <summary>
        /// A letterlike numeric character. Value: "Nl".
        /// </summary>
        public static PositiveUnicodeCategory LetterNumber { get; } = new PositiveUnicodeCategory("Nl");

        /// <summary>
        /// A numeric character of other type. Value: "No".
        /// </summary>
        public static PositiveUnicodeCategory OtherNumber { get; } = new PositiveUnicodeCategory("No");

        /// <summary>
        /// All numbers. Value: "N" ("Nd | Nl | No").
        /// <para><see cref="DecimalNumber"/> | <see cref="LetterNumber"/> | <see cref="OtherNumber"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory Number { get; } = new PositiveUnicodeCategory("N");

        #endregion

        #region Punctuation

        /// <summary>
        /// A connecting punctuation mark, like a tie. Value: "Pc".
        /// </summary>
        public static PositiveUnicodeCategory ConnectorPunctuation { get; } = new PositiveUnicodeCategory("Pc");

        /// <summary>
        /// A dash or hyphen punctuation mark. Value: "Pd".
        /// </summary>
        public static PositiveUnicodeCategory DashPunctuation { get; } = new PositiveUnicodeCategory("Pd");

        /// <summary>
        /// An opening punctuation mark(of a pair). Value: "Ps".
        /// </summary>
        public static PositiveUnicodeCategory OpenPunctuation { get; } = new PositiveUnicodeCategory("Ps");

        /// <summary>
        /// A closing punctuation mark(of a pair). Value: "Pe".
        /// </summary>
        public static PositiveUnicodeCategory ClosePunctuation { get; } = new PositiveUnicodeCategory("Pe");

        /// <summary>
        /// An initial quotation mark. Value: "Pi".
        /// </summary>
        public static PositiveUnicodeCategory InitialPunctuation { get; } = new PositiveUnicodeCategory("Pi");

        /// <summary>
        /// A final quotation mark. Value: "Pf"
        /// </summary>
        public static PositiveUnicodeCategory FinalPunctuation { get; } = new PositiveUnicodeCategory("Pf");

        /// <summary>
        /// A punctuation mark of other type. Value: "Po"
        /// </summary>
        public static PositiveUnicodeCategory OtherPunctuation { get; } = new PositiveUnicodeCategory("Po");

        /// <summary>
        /// All punctuation characters. Value : "P" ("Pc | Pd | Ps | Pe | Pi | Pf | Po").
        /// <para><see cref="ConnectorPunctuation"/> | <see cref="DashPunctuation"/> | <see cref="OpenPunctuation"/> | <see cref="ClosePunctuation"/> | <see cref="InitialPunctuation"/> | <see cref="FinalPunctuation"/> | <see cref="OtherPunctuation"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory Punctuation { get; } = new PositiveUnicodeCategory("P");

        #endregion

        #region Symbol

        /// <summary>
        /// A symbol of mathematical use. Value: "Sm".
        /// </summary>
        public static PositiveUnicodeCategory MathSymbol { get; } = new PositiveUnicodeCategory("Sm");

        /// <summary>
        /// A currency sign. Value: "Sc".
        /// </summary>
        public static PositiveUnicodeCategory CurrencySymbol { get; } = new PositiveUnicodeCategory("Sc");

        /// <summary>
        /// A non-letterlike modifier symbol. Value: "Sk".
        /// </summary>
        public static PositiveUnicodeCategory ModifierSymbol { get; } = new PositiveUnicodeCategory("Sk");

        /// <summary>
        /// A symbol of other type. Value: "So".
        /// </summary>
        public static PositiveUnicodeCategory OtherSymbol { get; } = new PositiveUnicodeCategory("So");

        /// <summary>
        /// All symbols. Value: "S" ("Sm | Sc | Sk | So").
        /// <para><see cref="MathSymbol"/> | <see cref="CurrencySymbol"/> | <see cref="ModifierSymbol"/> | <see cref="OtherSymbol"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory Symbol { get; } = new PositiveUnicodeCategory("S");

        #endregion

        #region Separator

        /// <summary>
        /// A space character(of various non-zero widths). Value: "Zs".
        /// </summary>
        public static PositiveUnicodeCategory SpaceSeparator { get; } = new PositiveUnicodeCategory("Zs");

        /// <summary>
        /// U+2028 LINE SEPARATOR only. Value: "Zl".
        /// </summary>
        public static PositiveUnicodeCategory LineSeparator { get; } = new PositiveUnicodeCategory("Zl");

        /// <summary>
        /// U+2029 PARAGRAPH SEPARATOR only. Value: "Zp".
        /// </summary>
        public static PositiveUnicodeCategory ParagraphSeparator { get; } = new PositiveUnicodeCategory("Zp");

        /// <summary>
        /// All separator characters. Value: "Z" ("Zs | Zl | Zp").
        /// <para><see cref="SpaceSeparator"/> | <see cref="LineSeparator"/> | <see cref="ParagraphSeparator"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory Separator { get; } = new PositiveUnicodeCategory("Z");

        #endregion

        #region Other

        /// <summary>
        /// A C0 or C1 control code. Value: "Cc".
        /// </summary>
        public static PositiveUnicodeCategory Control { get; } = new PositiveUnicodeCategory("Cc");

        /// <summary>
        /// A format control character. Value: "Cf".
        /// </summary>
        public static PositiveUnicodeCategory Format { get; } = new PositiveUnicodeCategory("Cf");

        /// <summary>
        /// A surrogate code point. Value: "Cs".
        /// </summary>
        public static PositiveUnicodeCategory Surrogate { get; } = new PositiveUnicodeCategory("Cs");

        /// <summary>
        /// A private-use character. Value: "Co".
        /// </summary>
        public static PositiveUnicodeCategory PrivateUse { get; } = new PositiveUnicodeCategory("Co");

        /// <summary>
        /// A reserved unassigned code point or a noncharacter. Value: "Cn".
        /// </summary>
        public static PositiveUnicodeCategory Unassigned { get; } = new PositiveUnicodeCategory("Cn");

        /// <summary>
        /// All control characters. Value "C" ("Cc | Cf | Cs | Co | Cn").
        /// <para><see cref="Control"/> | <see cref="Format"/> | <see cref="Surrogate"/> | <see cref="PrivateUse"/> | <see cref="Unassigned"/>.</para>
        /// </summary>
        public static PositiveUnicodeCategory Other { get; } = new PositiveUnicodeCategory("C");

        #endregion
    }
}
