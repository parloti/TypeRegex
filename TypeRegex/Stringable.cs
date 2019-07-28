using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TypeRegex
{
	/// <summary>
	/// Provides a way to represent the current object as a string.
	/// </summary>
	public abstract class Stringable
    {
        /// <summary>
        /// Determines whether two specified <see cref="Stringable"/> have the same value.
        /// </summary>
        /// <param name="stringable1">The first <see cref="Stringable"/> to compare, or <see langword="null"/>.</param>
        /// <param name="stringable2">The second <see cref="Stringable"/> to compare, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the value of <paramref name="stringable1"/> is the same as the value of <paramref name="stringable2"/>; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Stringable stringable1, Stringable stringable2)
        {
            return stringable1.ToString() == stringable2.ToString();
        }

        /// <summary>
        /// Determines whether two specified <see cref="Stringable"/> have the different value.
        /// </summary>
        /// <param name="stringable1">The first <see cref="Stringable"/> to compare, or <see langword="null"/>.</param>
        /// <param name="stringable2">The second <see cref="Stringable"/> to compare, or <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if the value of <paramref name="stringable1"/> is different from the value of <paramref name="stringable2"/>; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Stringable stringable1, Stringable stringable2)
        {
            return stringable1.ToString() != stringable2.ToString();
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="Stringable"/> are equal.
        /// </summary>
        /// <param name="obj">The <see cref="Stringable"/> to compare to this instance.</param>
        /// <exception cref="NullReferenceException">The current instance is <see langword="null"/>.</exception>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="Stringable"/> and its value is the same as this instance; otherwise, <see langword="false"/>. If <paramref name="obj"/> is <see langword="null"/>, the method returns <see langword="false"/>.</returns>
        public override bool Equals(object obj)
        {
            if(this is null)
            {
                throw new NullReferenceException();
            }

			if (!(obj is Stringable stringable))
			{
				return false;
			}

			return ToString().Equals(stringable);
        }

        /// <summary>
        /// Serves as a hash function for the specified object for hashing algorithms and data structures, such as a hash table.
        /// </summary>
        /// <returns>A hash code for the specified object.</returns>
        public override int GetHashCode()
        {
            return -2058316596 + EqualityComparer<string>.Default.GetHashCode(this);
        }

        /// <summary>
        /// Implicit conversion to string.
        /// </summary>
        /// <param name="stringable">An instance to be converted to string.</param>
        /// <exception cref="ArgumentNullException"><paramref name="stringable"/> is <see langword="null"/></exception>
        public static implicit operator string(Stringable stringable)
        {
            if (stringable is null)
            {
                throw new ArgumentNullException(nameof(stringable));
            }

            return stringable.ToString();
        }

        /// <summary>
        /// Converts this instance to a regular expression pattern that can be passed to a <see cref="Regex"/> constructor.
        /// </summary>
        /// <returns>A regular expression pattern.</returns>
        public abstract override string ToString();
    }
}
