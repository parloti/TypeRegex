using System;

namespace FluentRegex
{
    /// <summary>
    /// A negative character group specifies a list of characters that must not appear in an input string for a match to occur.
    /// </summary>
    public class NegativeCharacterGroup : CharacterGroup
    {
        /// <summary>
        /// A prefix to the character set to indicate whether the group is positive or negative.
        /// </summary>
        protected override string Prefix { get { return "^"; } }

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeCharacterGroup"/> class that has a set of characters specified individually.
        /// </summary>
        /// <param name="set">The set of characters to be not matched.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is <see cref="string.Empty"/>.</exception>
        public NegativeCharacterGroup(string set, bool escape = true) : base(set, escape)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeCharacterGroup"/> class that has a set of characters specified individually.
        /// </summary>
        /// <param name="set">The set of characters to be not matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is empty.</exception>
        public NegativeCharacterGroup(params char[] set) : base(set)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeCharacterGroup"/> class that has a set of characters specified as a range.
        /// </summary>
        /// <param name="first">The first character in the range.</param>
        /// <param name="last">The last character in the range.</param>
        /// <param name="caseSensitive">If it must be case-sensitive.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        public NegativeCharacterGroup(char first, char last, bool caseSensitive = true) : base(first, last, caseSensitive)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeCharacterGroup"/> class that has a set of decimal digits specified as a range.
        /// </summary>
        /// <param name="first">The first digit in the range.</param>
        /// <param name="last">The last digit in the range.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="first"/> or <paramref name="last"/> are greater as 9.</exception>
        public NegativeCharacterGroup(uint first, uint last) : base(first, last)
        {
        }

        #endregion
    }
}
