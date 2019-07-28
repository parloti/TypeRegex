namespace TypeRegex
{
    /// <summary>
    /// The matching behavior for a sub-term of the expression.
    /// </summary>
    public enum MatchingBehavior
    {
        /// <summary>
        /// Uses the default behavior of the expression for the term.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Enables ECMAScript-compliant behavior for the term. Independent of the behavior of the expression.
        /// </summary>
        ECMAScript = 1,

        /// <summary>
        /// Enables canonical behavior for the term. Independent of the behavior of the expression.
        /// </summary>
        Unicode = 2,

        /// <summary>
        /// Enables canonical behavior for the term. Independent of the behavior of the expression.
        /// </summary>
        Canonical = 2,
    }
}
