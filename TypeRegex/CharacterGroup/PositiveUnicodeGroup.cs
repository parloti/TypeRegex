using System;

namespace TypeRegex
{
    /// <summary>
    /// Positive Unicode named groups base class.
    /// </summary>
    public abstract class PositiveUnicodeGroup : UnicodeGroup
    {
        /// <summary>
        /// The regular expression format.
        /// </summary>
        protected override string CompositeFormat => @"\p{{{0}}}";

        /// <summary>
        /// Initializes a new instance of the <see cref="PositiveUnicodeGroup"/> class.
        /// </summary>
        /// <param name="name">The block name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentException"><paramref name="name"/> is <see cref="string.Empty"/> or consists only of white-space characters.</exception>
        protected PositiveUnicodeGroup(string name) : base(name)
        {
        }

    }
}
