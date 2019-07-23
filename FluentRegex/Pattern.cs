using System.Text;
using System.Text.RegularExpressions;

namespace FluentRegex
{
    /// <summary>
    /// Typified help in building regular expressions pattern.
    /// </summary>
	public partial class Pattern : Stringable
    {
        #region Stringable

        /// <summary>
        /// Converts this instance to a regular expression pattern.
        /// </summary>
        /// <returns>A regular expression pattern.</returns>
        public override string ToString()
        {
            return PatternBuilder.ToString();
        }

        #endregion

        #region Construction

        /// <summary>
        /// Initializes an instance of the class.
        /// </summary>
        public Pattern()
        {
        }

        /// <summary>
        /// Initializes an instance of the class and add <paramref name="term"/> to the expression.
        /// </summary>
        /// <param name="term">Initial term of the expression.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        public Pattern(string term, bool escape = true)
        {
            Add(term, escape);
        }

        #endregion

        #region Main

        /// <summary>
        /// Regular expression pattern builder.
        /// </summary>
        protected StringBuilder PatternBuilder { get; } = new StringBuilder();

        /// <summary>
        /// Adds a trivial term to the expression.
        /// </summary>
        /// <param name="term">Term to be added to the expression.</param>
        /// <param name="escape">Indicates whether the character set (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) should be replaced with their escape codes.</param>
        /// <returns>Current instance of <see cref="Pattern"/>.</returns>
        public Pattern Add(string term, bool escape = true)
        {
            if (term is null)
            {
                term = string.Empty;
            }
            else if (escape)
            {
                term = Regex.Escape(term);
            }

            PatternBuilder.Append("(" + term + ")");

            return this;
        }

        #endregion
    }
}
