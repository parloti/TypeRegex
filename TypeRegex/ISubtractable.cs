namespace TypeRegex
{
    /// <summary>
    /// Represents a set of characters from which another set can be subtracted.
    /// </summary>
    public interface ISubtractable
    {
        /// <summary>
        /// Set of characters to be used in subtraction.
        /// </summary>
        string Set { get; }
    }
}
