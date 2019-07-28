namespace TypeRegex
{
    /// <summary>
    /// A hexadecimal representation of a unicode character.
    /// </summary>
    internal class HexadecimalUnicode : Stringable
    {
        /// <summary>
        /// The hexadecimal code.
        /// </summary>
        private readonly string code;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="decimalCode">The character to be represented as hexadecimal.</param>
        internal HexadecimalUnicode(char decimalCode)
        {
            var @int = (int)decimalCode;
            var hex = @int.ToString("X4");
            code = @"\u" + hex;
        }

        /// <summary>
        /// Converts this instance to a <see cref="string"/>.
        /// </summary>
        /// <returns>A regular expression pattern.</returns>
        public override string ToString()
        {
            return code;
        }
    }
}
