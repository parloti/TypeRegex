using System;

namespace FluentRegex
{
    /// <summary>
    /// Typified help in building regular expressions pattern.
    /// </summary>
	public partial class Pattern
    {
        #region Character Classes

        #region Positive character group

        /// <summary>
        /// Matches any single character in <paramref name="set"/>. By default, the match is case-sensitive.
        /// Pattern: "[set]".
        /// </summary>
        /// <param name="set">The set of characters to be matched.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is <see cref="string.Empty"/>.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AnyIn(string set, bool escape = true)
        {
            var group = new PositiveCharacterGroup(set, escape);

            return Add(group.ToString(), false);
        }

        /// <summary>
        /// Matches any single character in <paramref name="set"/>. By default, the match is case-sensitive.
        /// Pattern: "[^set]".
        /// </summary>
        /// <param name="set">The set of characters to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is empty.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AnyIn(params char[] set)
        {
            var group = new PositiveCharacterGroup(set);

            return Add(group.ToString(), false);
        }

        /// <summary>
        /// Character range: Matches any single character in the range from <paramref name="first"/> to <paramref name="last"/>.
        /// Pattern: "[first-last]".
        /// </summary>
        /// <param name="first">The first character in the range.</param>
        /// <param name="last">The last character in the range.</param>
        /// <param name="caseSensitive">If it must be case-sensitive.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Range(char first, char last, bool caseSensitive = true)
        {
            var group = new PositiveCharacterGroup(first, last, caseSensitive);

            return Add(group.ToString(), false);
        }

        /// <summary>
        /// Character range: Matches any single decimal digit in the range from <paramref name="first"/> to <paramref name="last"/>.
        /// Pattern: "[first-last]".
        /// </summary>
        /// <param name="first">The first digit in the range.</param>
        /// <param name="last">The last digit in the range.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="first"/> or <paramref name="last"/> are greater as 9.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Range(uint first, uint last)
        {
            var group = new PositiveCharacterGroup(first, last);

            return Add(group.ToString(), false);
        }

        /// <summary>
        /// Wildcard: Matches any single character.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Any()
        {
            return Add(CharacterClass.Any.ToString(), false);
        }

        #endregion

        #region Negative character group

        /// <summary>
        /// Negation: Matches any single character that is not in <paramref name="set"/>. By default, the match is case-sensitive.
        /// Pattern: "[^set]".
        /// </summary>
        /// <param name="set">The set of characters to be not matched.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is <see cref="string.Empty"/>.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AnyNotIn(string set, bool escape = true)
        {
            var group = new NegativeCharacterGroup(set, escape);

            return Add(group.ToString(), false);
        }

        /// <summary>
        /// Negation: Matches any single character that is not in <paramref name="set"/>. By default, the match is case-sensitive.
        /// Pattern: "[^set]".
        /// </summary>
        /// <param name="set">The set of characters to be not matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is empty.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AnyNotIn(params char[] set)
        {
            var group = new NegativeCharacterGroup(set);

            return Add(group.ToString(), false);
        }

        /// <summary>
        /// Character range: Matches any single character that is not in the range from <paramref name="first"/> to <paramref name="last"/>.
        /// Pattern: "[^first-last]".
        /// </summary>
        /// <param name="first">The first character in the range.</param>
        /// <param name="last">The last character in the range.</param>
        /// <param name="caseSensitive">If it must be case-sensitive.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern NotInRange(char first, char last, bool caseSensitive = true)
        {
            var group = new NegativeCharacterGroup(first, last, caseSensitive);

            return Add(group.ToString(), false);
        }

        /// <summary>
        /// Character range: Matches any single decimal digit that is not in the range from <paramref name="first"/> to <paramref name="last"/>.
        /// Pattern: "[^first-last]".
        /// </summary>
        /// <param name="first">The first decimal digit in the range.</param>
        /// <param name="last">The last decimal digit in the range.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="first"/> or <paramref name="last"/> are greater as 9.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern NotInRange(uint first, uint last)
        {
            var group = new NegativeCharacterGroup(first, last);

            return Add(group.ToString(), false);
        }

        #endregion

        /// <summary>
        /// Matches any single character in the Unicode general category specified by <paramref name="term"/>.
        /// Pattern: "\p{category}".
        /// </summary>
        /// <param name="term">The Unicode general category, <see cref="FluentRegex.UnicodeCategory"/>).</param>
        /// <exception cref="ArgumentNullException"><paramref name="term"/> is <see langword="null"/></exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Add(Stringable term)
        {
            if (term is null)
            {
                throw new ArgumentNullException(nameof(term));
            }
            return Add(term.ToString(), false);
        }

        #region Word

        /// <summary>
        /// Matches any word character.
        /// Pattern: Default: "\w", ECMAScript: "[a-zA-Z_0-9]", Canonical: "[\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// </summary>
        /// <param name="matchingBehavior">The matching behavior for the term.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Word(MatchingBehavior matchingBehavior = MatchingBehavior.Default)
        {
            switch (matchingBehavior)
            {
                case MatchingBehavior.Default:
                    Add(CharacterClass.Word, false);
                    break;
                case MatchingBehavior.ECMAScript:
                    ECMAScriptWord();
                    break;
                case MatchingBehavior.Unicode:
                    UnicodeWord();
                    break;
            }

            return this;
        }

        /// <summary>
        /// Matches any non-word character.
        /// Pattern: Default: "\W", ECMAScript: "[^a-zA-Z_0-9]", Canonical: "[^\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// </summary>
        /// <param name="matchingBehavior">The matching behavior for the term.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern NonWord(MatchingBehavior matchingBehavior = MatchingBehavior.Default)
        {
            switch (matchingBehavior)
            {
                case MatchingBehavior.Default:
                    Add(CharacterClass.NonWord, false);
                    break;
                case MatchingBehavior.ECMAScript:
                    ECMAScriptNonWord();
                    break;
                case MatchingBehavior.Unicode:
                    UnicodeNonWord();
                    break;
            }

            return this;
        }

        /// <summary>
        /// Matches any alphanumeric or underscore character.
        /// Pattern: "[a-zA-Z_0-9]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern ECMAScriptWord()
        {
            Add(CharacterClass.ECMAScriptWord, false);

            return this;
        }

        /// <summary>
        /// Matches any non alphanumeric or underscore character.
        /// Pattern: "[^a-zA-Z_0-9]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern ECMAScriptNonWord()
        {
            Add(CharacterClass.ECMAScriptNonWord, false);

            return this;
        }

        /// <summary>
        /// Matches any Unicode non word character.
        /// Pattern: "[^\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// <para><see cref="UnicodeCategory.Letter"/> | <see cref="UnicodeCategory.NonspacingMark"/> | <see cref="UnicodeCategory.DecimalNumber"/> | <see cref="UnicodeCategory.ConnectorPunctuation"/>.</para>
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern UnicodeWord()
        {
            Add(CharacterClass.UnicodeWord, false);

            return this;
        }

        /// <summary>
        /// Matches any non Unicode word character.
        /// Pattern: "[^\p{L}\p{Mn}\p{Nd}\p{Pc}]".
        /// <para><see cref="UnicodeCategory.Letter"/> | <see cref="UnicodeCategory.NonspacingMark"/> | <see cref="UnicodeCategory.DecimalNumber"/> | <see cref="UnicodeCategory.ConnectorPunctuation"/>.</para>
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern UnicodeNonWord()
        {
            Add(CharacterClass.UnicodeNonWord, false);

            return this;
        }

        #endregion

        #region WhiteSpace

        /// <summary>
        /// Matches any white-space character.
        /// Pattern: Default: "\s", ECMAScript: "[ \f\n\r\t\v]", Canonical: "[\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        /// <param name="matchingBehavior">The matching behavior for the term.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern WhiteSpace(MatchingBehavior matchingBehavior = MatchingBehavior.Default)
        {
            switch (matchingBehavior)
            {
                case MatchingBehavior.Default:
                    Add(CharacterClass.WhiteSpace, false);
                    break;
                case MatchingBehavior.ECMAScript:
                    ECMAScriptWhiteSpace();
                    break;
                case MatchingBehavior.Unicode:
                    UnicodeWhiteSpace();
                    break;
            }

            return this;
        }

        /// <summary>
        /// Matches any white-space character.
        /// Pattern: "[ \f\n\r\t\v]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern ECMAScriptWhiteSpace()
        {
            Add(CharacterClass.ECMAScriptWhiteSpace, false);

            return this;
        }

        /// <summary>
        /// Matches any white-space character.
        /// Pattern: "[\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern UnicodeWhiteSpace()
        {
            Add(CharacterClass.UnicodeWhiteSpace, false);

            return this;
        }

        /// <summary>
        /// Matches any non-white-space character.
        /// Pattern: Default: "\S", ECMAScript: "[^ \f\n\r\t\v]", Canonical: "[^\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        /// <param name="matchingBehavior">The matching behavior for the term.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern NonWhiteSpace(MatchingBehavior matchingBehavior = MatchingBehavior.Default)
        {
            switch (matchingBehavior)
            {
                case MatchingBehavior.Default:
                    Add(CharacterClass.NonWhiteSpace, false);
                    break;
                case MatchingBehavior.ECMAScript:
                    ECMAScriptNonWhiteSpace();
                    break;
                case MatchingBehavior.Unicode:
                    UnicodeNonWhiteSpace();
                    break;
            }

            return this;
        }

        /// <summary>
        /// Matches any non-white-space character.
        /// Pattern: "[^ \f\n\r\t\v]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern ECMAScriptNonWhiteSpace()
        {
            Add(CharacterClass.ECMAScriptNonWhiteSpace, false);

            return this;
        }

        /// <summary>
        /// Matches any non-white-space character.
        /// Pattern: "[^\f\n\r\t\v\x85\p{Z}]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern UnicodeNonWhiteSpace()
        {
            Add(CharacterClass.UnicodeNonWhiteSpace, false);

            return this;
        }

        #endregion

        #region Digit

        /// <summary>
        /// Matches any decimal digit.
        /// Pattern: Default: "\d", ECMAScript: "[0-9]", Canonical: "\p{Nd}".
        /// </summary>
        /// <param name="matchingBehavior">The matching behavior for the term.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Digit(MatchingBehavior matchingBehavior = MatchingBehavior.Default)
        {
            switch (matchingBehavior)
            {
                case MatchingBehavior.Default:
                    Add(CharacterClass.Digit, false);
                    break;
                case MatchingBehavior.ECMAScript:
                    ECMAScriptDigit();
                    break;
                case MatchingBehavior.Unicode:
                    UnicodeDigit();
                    break;
            }

            return this;
        }

        /// <summary>
        /// Matches any decimal digit.
        /// Pattern: "[0-9]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern ECMAScriptDigit()
        {
            Add(CharacterClass.ECMAScriptDigit, false);

            return this;
        }

        /// <summary>
        /// Matches any decimal digit.
        /// Pattern: "\p{Nd}".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern UnicodeDigit()
        {
            Add(CharacterClass.UnicodeDigit, false);

            return this;
        }

        /// <summary>
        /// Matches any character other than a decimal digit.
        /// </summary>
        /// Pattern: Default: "\D", ECMAScript: "[^0-9]", Canonical: "\P{Nd}".
        /// <param name="matchingBehavior">The matching behavior for the term.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern NonDigit(MatchingBehavior matchingBehavior = MatchingBehavior.Default)
        {
            switch (matchingBehavior)
            {
                case MatchingBehavior.Default:
                    Add(CharacterClass.NonDigit, false);
                    break;
                case MatchingBehavior.ECMAScript:
                    ECMAScriptNonDigit();
                    break;
                case MatchingBehavior.Unicode:
                    UnicodeNonDigit();
                    break;
            }

            return this;
        }

        /// <summary>
        /// Matches any character other than a decimal digit.
        /// Pattern: "[^0-9]".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern ECMAScriptNonDigit()
        {
            Add(CharacterClass.ECMAScriptNonDigit, false);

            return this;
        }

        /// <summary>
        /// Matches any character other than a decimal digit.
        /// Pattern: "\P{Nd}".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern UnicodeNonDigit()
        {
            Add(CharacterClass.UnicodeNonDigit, false);

            return this;
        }

        #endregion

        /// <summary>
        /// Character class subtraction yields a set of characters that is the result of excluding the characters in one character class from another character class.
        /// </summary>
        /// <param name="baseGroup"></param>
        /// <param name="excludedGroup"></param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Subtraction(CharacterGroup baseGroup, CharacterGroup excludedGroup)
        {
            //subtractable
            Add("[" + baseGroup.Set + "-" + excludedGroup.ToString() + "]", false);
            return this;
        }

        #endregion
    }
}
