using System;

namespace TypeRegex
{
    /// <summary>
    /// A positive character group specifies a list of characters, any one of which may appear in an input string for a match to occur.
    /// </summary>
    public class PositiveCharacterGroup : CharacterGroup
    {
        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveCharacterGroup"/> class that has a set of characters specified individually.
        /// </summary>
        /// <param name="set">The set of characters to be matched.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is <see cref="string.Empty"/>.</exception>
        public PositiveCharacterGroup(string set, bool escape = true) : base(set, escape)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveCharacterGroup"/> class that has a set of characters specified individually.
        /// </summary>
        /// <param name="set">The set of characters to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is empty.</exception>
        public PositiveCharacterGroup(params char[] set) : base(set)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveCharacterGroup"/> class that has a set of characters specified as a range.
        /// </summary>
        /// <param name="first">The first character in the range.</param>
        /// <param name="last">The last character in the range.</param>
        /// <param name="caseSensitive">If it must be case-sensitive.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        public PositiveCharacterGroup(char first, char last, bool caseSensitive = true) : base(first, last, caseSensitive)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveCharacterGroup"/> class that has a set of decimal digits specified as a range.
        /// </summary>
        /// <param name="first">The first digit in the range.</param>
        /// <param name="last">The last digit in the range.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="first"/> or <paramref name="last"/> are greater as 9.</exception>
        public PositiveCharacterGroup(uint first, uint last) : base(first, last)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveCharacterGroup"/> class that has all characters as set.
        /// </summary>
        public PositiveCharacterGroup() : this(char.MinValue, char.MaxValue)
        {
        }
        #endregion
    }
}
