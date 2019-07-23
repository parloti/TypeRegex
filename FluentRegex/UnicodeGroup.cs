using System;
using System.Text.RegularExpressions;

namespace FluentRegex
{
    /// <summary>
    /// Unicode named groups base class.
    /// </summary>
    public abstract class UnicodeGroup
    {
        /// <summary>
        /// The regular expression format.
        /// </summary>
        protected abstract string CompositeFormat { get; }
       
        /// <summary>
        /// Converts this instance to a regular expression pattern that can be passed to a <see cref="Regex"/> constructor.
        /// </summary>
        /// <returns>A regular expression character class.</returns>
        public override string ToString()
        {
            return string.Format(CompositeFormat, Name);
        }

        /// <summary>
        /// The group name.
        /// </summary>
        protected string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnicodeGroup"/> class.
        /// </summary>
        /// <param name="name">The block name.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentException"><paramref name="name"/> is <see cref="string.Empty"/> or consists only of white-space characters.</exception>
        protected UnicodeGroup(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }

            Name = name;
        }

    }
}
