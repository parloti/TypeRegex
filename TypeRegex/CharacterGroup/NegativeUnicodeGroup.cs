using System;

namespace TypeRegex
{
    /// <summary>
    /// Negative Unicode named groups base class.
    /// </summary>
    public abstract class NegativeUnicodeGroup : UnicodeGroup
    {
        /// <summary>
        /// The regular expression format.
        /// </summary>
        protected override string CompositeFormat => @"\P{{{0}}}";

        /// <summary>
        /// Initializes a new instance of the <see cref="NegativeUnicodeGroup"/> class.
        /// </summary>
        /// <param name="name">The block name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentException"><paramref name="name"/> is <see cref="string.Empty"/> or consists only of white-space characters.</exception>
        protected NegativeUnicodeGroup(string name) : base(name)
        {
        }
    }
}
