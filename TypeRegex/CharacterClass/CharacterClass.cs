namespace TypeRegex
{
    /// <summary>
    /// Defines a set of characters.
    /// </summary>
    public class CharacterClass : Stringable, ISubtractable
    {
        #region Stringable

        /// <summary>
        /// Converts this instance to a regular expression pattern.
        /// </summary>
        /// <returns>A regular expression pattern.</returns>
        public override string ToString()
        {
            return string.Format(format, Set);
        }

        #endregion

        #region ISubtractable

        /// <summary>
        /// Characters from which another set can be subtracted
        /// </summary>
        public string Set { get; }

        #endregion

        /// <summary>
        /// The pattern format.
        /// </summary>
        private readonly string format;

        /// <summary>
        /// Creates e new instance of the class.
        /// </summary>
        /// <param name="characterGroup">A instance of the class <see cref="CharacterGroup"/>.</param>
        private CharacterClass(CharacterGroup characterGroup) : this(characterGroup.Set, true)
        {
        }

        /// <summary>
        /// Creates e new instance of the class.
        /// </summary>
        /// <param name="charClass">The set of characteres.</param>
        /// <param name="brackets">If the set should be surrounded by square bracktes.</param>
        private CharacterClass(string charClass, bool brackets)
        {
            Set = charClass;
            if (brackets)
            {
                format = "[{0}]";
            }
            else
            {
                format = "{0}";
            }
        }

        /// <summary>
        /// Wildcard: Matches any single character.
        /// </summary>
        public static CharacterClass Any { get; } = new CharacterClass(new PositiveCharacterGroup());

        #region Word

        /// <summary>
        /// Matches any word character.
        /// Pattern: Default: "\w", ECMAScript: "[a-zA-Z_0-9]", Canonical: "[\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// </summary>
        public static CharacterClass Word { get; } = new CharacterClass(@"\w", false);

        /// <summary>
        /// Matches any alphanumeric or underscore character.
        /// Pattern: "[a-zA-Z_0-9]".
        /// </summary>
        public static CharacterClass ECMAScriptWord { get; } = new CharacterClass(@"a-zA-Z_0-9", true);

        /// <summary>
        /// Matches any Unicode non word character.
        /// Pattern: "[^\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// <para><see cref="IUnicodeCategory.Letter"/> | <see cref="IUnicodeCategory.NonspacingMark"/> | <see cref="IUnicodeCategory.DecimalNumber"/> | <see cref="IUnicodeCategory.ConnectorPunctuation"/>.</para>
        /// </summary>
        public static CharacterClass UnicodeWord { get; } = new CharacterClass(@"\p{L}\p{Mn}\p{Nd}\p{Pc}", true);

        /// <summary>
        /// Matches any non-word character.
        /// Pattern: Default: "\W", ECMAScript: "[^a-zA-Z_0-9]", Canonical: "[^\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// </summary>
        public static CharacterClass NonWord { get; } = new CharacterClass(@"\W", false);

        /// <summary>
        /// Matches any non alphanumeric or underscore character.
        /// Pattern: "[^a-zA-Z_0-9]".
        /// </summary>
        public static CharacterClass ECMAScriptNonWord { get; } = new CharacterClass(@"^a-zA-Z_0-9", true);

        /// <summary>
        /// Matches any non Unicode word character.
        /// Pattern: "[^\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// <para><see cref="IUnicodeCategory.Letter"/> | <see cref="IUnicodeCategory.NonspacingMark"/> | <see cref="IUnicodeCategory.DecimalNumber"/> | <see cref="IUnicodeCategory.ConnectorPunctuation"/>.</para>
        /// </summary>
        public static CharacterClass UnicodeNonWord { get; } = new CharacterClass(@"^\p{L}\p{Mn}\p{Nd}\p{Pc}", true);

        #endregion

        #region WhiteSpace

        /// <summary>
        /// Matches any white-space character.
        /// Pattern: Default: "\s", ECMAScript: "[ \f\n\r\t\v]", Canonical: "[\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        public static CharacterClass WhiteSpace { get; } = new CharacterClass(@"\s", false);

        /// <summary>
        /// Matches any white-space character.
        /// Pattern: "[ \f\n\r\t\v]".
        /// </summary>
        public static CharacterClass ECMAScriptWhiteSpace { get; } = new CharacterClass(@" \f\n\r\t\v", true);

        /// <summary>
        /// Matches any white-space character.
        /// Pattern: "[\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        public static CharacterClass UnicodeWhiteSpace { get; } = new CharacterClass(@"\f\n\r\t\v\x85\p{Z}", true);

        /// <summary>
        /// Matches any non-white-space character.
        /// Pattern: Default: "\S", ECMAScript: "[^ \f\n\r\t\v]", Canonical: "[^\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        public static CharacterClass NonWhiteSpace { get; } = new CharacterClass(@"\S", false);

        /// <summary>
        /// Matches any non-white-space character.
        /// Pattern: "[^ \f\n\r\t\v]".
        /// </summary>
        public static CharacterClass ECMAScriptNonWhiteSpace { get; } = new CharacterClass(@"^ \f\n\r\t\v", true);

        /// <summary>
        /// Matches any non-white-space character.
        /// Pattern: "[^\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        public static CharacterClass UnicodeNonWhiteSpace { get; } = new CharacterClass(@"^\f\n\r\t\v\x85\p{Z}", true);

        #endregion

        #region Digit

        /// <summary>
        /// Matches any decimal digit.
        /// Pattern: Default: "\d", ECMAScript: "[0-9]", Canonical: "\p{Nd}".
        /// </summary>
        public static CharacterClass Digit { get; } = new CharacterClass(@"\d", false);

        /// <summary>
        /// Matches any decimal digit.
        /// Pattern: "[0-9]".
        /// </summary>
        public static CharacterClass ECMAScriptDigit { get; } = new CharacterClass(@"0-9", true);

        /// <summary>
        /// Matches any decimal digit.
        /// Pattern: "\p{Nd}".
        /// </summary>
        public static CharacterClass UnicodeDigit { get; } = new CharacterClass(@"\p{Nd}", false);

        /// <summary>
        /// Matches any character other than a decimal digit.
        /// </summary>
        /// Pattern: Default: "\D", ECMAScript: "[^0-9]", Canonical: "\P{Nd}".
        public static CharacterClass NonDigit { get; } = new CharacterClass(@"\D", false);

        /// <summary>
        /// Matches any character other than a decimal digit.
        /// Pattern: "[^0-9]".
        /// </summary>
        public static CharacterClass ECMAScriptNonDigit { get; } = new CharacterClass(@"^0-9", true);

        /// <summary>
        /// Matches any character other than a decimal digit.
        /// Pattern: "\P{Nd}".
        /// </summary>
        public static CharacterClass UnicodeNonDigit { get; } = new CharacterClass(@"\P{Nd}", false);

        #endregion
    }
}
