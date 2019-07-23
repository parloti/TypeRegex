using System;

namespace FluentRegex
{
    /// <summary>
    /// Typified help in building regular expressions pattern.
    /// </summary>
	public partial class Pattern
    {
        #region Character Escapes

        #region Constants

        /// <summary>
        /// Matches a bell (alarm) character, \u0007.
        /// Pattern: "\u0007".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Bell()
        {
            return Add(Escapes.Bell, false);
        }

        /// <summary>
        /// In a character class, matches a backspace, \u0008.
        /// Pattern: "\u0008".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Backspace()
        {
            return Add(Escapes.Backspace, false);
        }

        /// <summary>
        /// Matches a tab, \u0009.
        /// Pattern: "\u0009".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Tab()
        {
            return Add(Escapes.Tab, false);
        }

        /// <summary>
        /// Matches a carriage return, \u000D. ("\r" is not equivalent to the newline character, "\n".)
        /// Pattern: "\u000D".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern CarriageReturn()
        {
            return Add(Escapes.CarriageReturn, false);
        }

        /// <summary>
        /// Matches a vertical tab, \u000B.
        /// Pattern: "\u000B".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern VerticalTab()
        {
            return Add(Escapes.VerticalTab, false);
        }

        /// <summary>
        /// Matches a form feed, \u000C.
        /// Pattern: "\u000C".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern FormFeed()
        {
            return Add(Escapes.FormFeed, false);
        }

        /// <summary>
        /// Matches a new line, \u000A.
        /// Pattern: "\u000A" or "\u000D?\u000A".
        /// </summary>
        /// <param name="windowsMode">If <see langword="true"/> match also '\r\n'. Pattern: "\u000D?\u000A".</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern NewLine(bool windowsMode = true)
        {
            if (windowsMode)
            {
                // TODO: Maybe(Escapes.CarriageReturn).Then(Escapes.NewLine)
                return Add(@"\u000D?\u000A", false);
            }
            else
            {
                return Add(Escapes.NewLine, false);
            }
        }

        /// <summary>
        /// Matches an escape, \u001B.
        /// Pattern: "\u001B".
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Escape()
        {
            return Add(Escapes.Escape, false);
        }

        #endregion

        /// <summary>
        /// Matches an ASCII character, where nnn consists of two or three digits that represent the octal character code.
        /// Pattern: "\nnn".
        /// </summary>
        /// <example>
        /// For example, \040 represents a space character.
        /// </example>
        /// <param name="octalNumber">Octal equivalent of the character to be matched.</param>
        /// <exception cref="ArgumentException"><paramref name="octalNumber"/> is prefixed with a negative sign.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="octalNumber"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="octalNumber"/> length is not 2 or 3 or <paramref name="octalNumber"/> is <see cref="string.Empty"/>.</exception>
        /// <exception cref="FormatException"><paramref name="octalNumber"/> contains a character that is not a valid digit in the octal base.</exception>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Octal(string octalNumber)
        {
            if (octalNumber is null)
            {
                throw new ArgumentNullException(nameof(octalNumber));
            }

            Convert.ToInt32(octalNumber, 8);

            var length = octalNumber.Length;
            if (length != 2 && length != 3)
            {
                throw new ArgumentOutOfRangeException(nameof(octalNumber) + "." + nameof(octalNumber.Length), length, "Must be 2 or 3.");
            }

            return Add(@"\" + octalNumber, false);
        }

        /// <summary>
        /// Matches an ASCII character, where nn is a two-digit hexadecimal character code.
        /// Pattern: "\xnn".
        /// </summary>
        /// <param name="hexadecimalNumber">Hexadecimal equivalent of the character to be matched.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        /// <exception cref="ArgumentException"><paramref name="hexadecimalNumber"/> is prefixed with a negative sign.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="hexadecimalNumber"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="hexadecimalNumber"/> length is not 2 or <paramref name="hexadecimalNumber"/> is <see cref="string.Empty"/>.</exception>
        /// <exception cref="FormatException"><paramref name="hexadecimalNumber"/> contains a character that is not a valid digit in the hexadecimal base.</exception>
        public Pattern Hexadecimal(string hexadecimalNumber)
        {
            if (hexadecimalNumber is null)
            {
                throw new ArgumentNullException(nameof(hexadecimalNumber));
            }

            Convert.ToInt32(hexadecimalNumber, 16);

            var length = hexadecimalNumber.Length;
            if (length != 2)
            {
                throw new ArgumentOutOfRangeException(nameof(hexadecimalNumber) + "." + nameof(hexadecimalNumber.Length), length, "Must be 2.");
            }

            return Add(@"\" + hexadecimalNumber, false);
        }

        /// <summary>
        /// Matches the ASCII control character that is specified by X or x, where X or x is the letter of the control character.
        /// Pattern: "\cX" or "\cx".
        /// </summary>
        /// <param name="controlCharacter">The letter of the control character.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern ASCIIControl(char controlCharacter)
        {
            return Add(@"\c" + controlCharacter, false);
        }

        /// <summary>
        /// Matches a Unicode character by using hexadecimal representation (exactly four digits, as represented by nnnn).
        /// Pattern: "\unnnn".
        /// </summary>
        /// <param name="hexadecimal">The hexadecimal representation.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        /// <exception cref="ArgumentException"><paramref name="hexadecimal"/> is prefixed with a negative sign.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="hexadecimal"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="hexadecimal"/> length is not 4 or <paramref name="hexadecimal"/> is <see cref="string.Empty"/>.</exception>
        /// <exception cref="FormatException"><paramref name="hexadecimal"/> contains a character that is not a valid digit in the hexadecimal base.</exception>
        public Pattern Unicode(string hexadecimal)
        {
            if (hexadecimal is null)
            {
                throw new ArgumentNullException(nameof(hexadecimal));
            }

            Convert.ToInt32(hexadecimal, 16);

            var length = hexadecimal.Length;
            if (length != 4)
            {
                throw new ArgumentOutOfRangeException(nameof(hexadecimal) + "." + nameof(hexadecimal.Length), length, "Must be 4.");
            }

            return Add(@"\u" + hexadecimal, false);
        }

        /// <summary>
        /// Matches a character that is not recognized as an escape character.
        /// Pattern: "\c".
        /// </summary>
        /// <example>
        /// For example, \* is the same as \x2A, and \. is the same as \x2E. This allows the regular expression engine to disambiguate language elements (such as * or ?) and character literals (represented by \* or \?).
        /// </example>
        /// <param name="character">The character to be matched.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Literal(char character)
        {
            int value = character;
            return Add(@"\u" + value.ToString("X4"), false);
        }

        #endregion
    }
}
