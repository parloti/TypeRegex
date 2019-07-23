using System;
using System.Text.RegularExpressions;

namespace FluentRegex
{
    /// <summary>
    /// A character class defines a set of characters, any one of which can occur in an input string for a match to succeed.
    /// </summary>
    public abstract class CharacterGroup : Stringable, ISubtractable
    {
        #region Stringable

        /// <summary>
        /// Converts this instance to a regular expression pattern that can be passed to a <see cref="Regex"/> constructor.
        /// </summary>
        /// <returns>A regular expression character class.</returns>
        public override string ToString()
        {
            return "[" + Set + "]";
        }

        #endregion

        #region ISubtractable

        /// <summary>
        /// Regular expression pattern builder.
        /// </summary>
        public string Set { get; private set; }

        #endregion

        #region Main

        /// <summary>
        /// A prefix to the character set to indicate whether the group is positive or negative.
        /// </summary>
        protected virtual string Prefix { get { return string.Empty; } }

        /// <summary>
        /// Adds a trivial term to the expression.
        /// </summary>
        /// <param name="term">Term to be added to the expression.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        private void Add(string term, bool escape = true)
        {
            if (term is null)
            {
                term = string.Empty;
            }
            else if (escape)
            {
                term = Regex.Escape(term);
            }

            Set = Prefix + term;
        }

        #endregion

        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterGroup"/> class that has a set of characters specified individually.
        /// </summary>
        /// <param name="set">The set of characters to be matched.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is <see cref="string.Empty"/>.</exception>
        protected CharacterGroup(string set, bool escape = true)
        {
            if (set is null)
            {
                throw new ArgumentNullException(nameof(set));
            }

            if (set.Length < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(set), "Is empty.");
            }

            Add(set, escape);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterGroup"/> class that has a set of characters specified individually.
        /// </summary>
        /// <param name="set">The set of characters to be matched.</param>
        /// <exception cref="ArgumentNullException"><paramref name="set"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="set"/> is empty.</exception>
        protected CharacterGroup(params char[] set)
            : this(set is null ? throw new ArgumentNullException(nameof(set)) : new string(set), true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterGroup"/> class that has a set of characters specified as a range.
        /// </summary>
        /// <param name="first">The first character in the range.</param>
        /// <param name="last">The last character in the range.</param>
        /// <param name="caseSensitive">If it must be case-sensitive.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        protected CharacterGroup(char first, char last, bool caseSensitive = true)
        {
            if (first > last)
            {
                throw new ArgumentException($"[{first}-{last}], [x-y] range in reverse order.", nameof(first) + ", " + nameof(last));
            }

            if (caseSensitive)
            {
                Add(new HexadecimalUnicode(first) + "-" + new HexadecimalUnicode(last), false);
            }
            else
            {
                var startLowerRange = new HexadecimalUnicode(char.ToLower(first));
                var endLowerRange = new HexadecimalUnicode(char.ToLower(last));

                var lowerRange = startLowerRange + "-" + endLowerRange;

                var startUpperRange = new HexadecimalUnicode(char.ToUpper(first));
                var endUpperRange = new HexadecimalUnicode(char.ToUpper(last));

                var upperRange = startUpperRange + "-" + endUpperRange;
                Add(lowerRange + upperRange, false);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterGroup"/> class that has a set of decimal digits specified as a range.
        /// </summary>
        /// <param name="first">The first digit in the range.</param>
        /// <param name="last">The last digit in the range.</param>
        /// <exception cref="ArgumentException"><paramref name="first"/> is greater as <paramref name="last"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="first"/> or <paramref name="last"/> are greater as 9.</exception>
        protected CharacterGroup(uint first, uint last)
        {
            if (first > last)
            {
                throw new ArgumentException($"[{first}-{last}], [x-y] range in reverse order.", nameof(first) + ", " + nameof(last));
            }

            if (first > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(first), first, "Must be less than 9.");
            }

            if (last > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(last), last, "Must be less than 9.");
            }

            Add(first + "-" + last, false);
        }

        #endregion
    }
}
