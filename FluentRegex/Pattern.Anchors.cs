namespace FluentRegex
{
    /// <summary>
    /// Typified help in building regular expressions pattern.
    /// </summary>
	public partial class Pattern
    {
        #region Anchors

        /// <summary>
        /// By default, the match must start at the beginning of the string; in multiline mode, it must start at the beginning of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern StartOfLine()
        {
            Add("^", false);

            return this;
        }

        /// <summary>
        /// By default, the match must occur at the end of the string or before \n at the end of the string; in multiline mode, it must occur before the end of the line or before \n at the end of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern EndOfLine()
        {
            Add("$", false);

            return this;
        }

        /// <summary>
        /// The match must occur at the start of the string.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern StartOfString()
        {
            Add(@"\A", false);

            return this;
        }

        /// <summary>
        /// The match must occur at the end of the string.
        /// </summary>
        /// <param name="perlMode">If <see langword="true"/> match also before \n at the end of the string.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern EndOfString(bool perlMode = true)
        {
            if (perlMode)
            {
                Add(@"\Z", false);
            }
            else
            {
                Add(@"\z", false);
            }

            return this;
        }

        /// <summary>
        /// By default, the match must occur at the end of the string or before \n at the end of the string; in multiline mode, it must occur before the end of the line or before \n at the end of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern EndOfLine5()
        {
            Add("$", false);

            return this;
        }

        /// <summary>
        /// By default, the match must occur at the end of the string or before \n at the end of the string; in multiline mode, it must occur before the end of the line or before \n at the end of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern EndOfLine4()
        {
            Add("$", false);

            return this;
        }

        /// <summary>
        /// By default, the match must occur at the end of the string or before \n at the end of the string; in multiline mode, it must occur before the end of the line or before \n at the end of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern EndOfLine3()
        {
            Add("$", false);

            return this;
        }

        /// <summary>
        /// By default, the match must occur at the end of the string or before \n at the end of the string; in multiline mode, it must occur before the end of the line or before \n at the end of the line.
        /// </summary>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern EndOfLine2()
        {
            Add("$", false);

            return this;
        }

        #endregion
    }
}
