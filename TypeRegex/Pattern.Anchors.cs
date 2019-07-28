namespace TypeRegex
{
    /// <summary>
    /// Typified help in building regular expressions pattern.
    /// </summary>
	public partial class Pattern
    {
        #region Anchors

        /// <summary>
        /// By default, the match must occur at the beginning of the string; in multiline mode, it must occur at the beginning of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtStartOfStringOrLine()
        {
            Add(Anchors.StartOfStringOrLine, false);

            return this;
        }

        /// <summary>
        /// By default, the match must occur at the end of the string or before \n at the end of the string; in multiline mode, it must occur before the end of the line or before \n at the end of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtEndOfStringOrLine()
        {
            Add(Anchors.EndOfStringOrLine, false);

            return this;
        }

        /// <summary>
        /// The match must occur at the beginning of the string only (no multiline support).
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtStartOfStringOnly()
        {
            Add(Anchors.StartOfStringOnly, false);

            return this;
        }

        /// <summary>
        /// The match must occur at the end of the string, or before \n at the end of the string.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtEndOfStringOrBeforeEndingNewline()
        {
            Add(Anchors.EndOfStringOrBeforeEndingNewline, false);

            return this;
        }

        /// <summary>
        /// The match must occur at the end of the string only.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtEndOfStringOnly()
        {
            Add(Anchors.EndOfStringOnly, false);

            return this;
        }

        /// <summary>
        /// The match must start at the position where the previous match ended.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtContiguousMatches()
        {
            Add(Anchors.ContiguousMatches, false);

            return this;
        }

        /// <summary>
        /// The match must occur on a word boundary.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtWordBoundary()
        {
            Add(Anchors.WordBoundary, false);

            return this;
        }

        /// <summary>
        /// The match must not occur on a word boundary.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern AtNonWordBoundary()
        {
            Add(Anchors.NonWordBoundary, false);

            return this;
        }

        #endregion
    }
}
