namespace TypeRegex
{
    /// <summary>
    /// Anchors, or atomic zero-width assertions, specify a position in the string where a match must occur.
    /// </summary>
    public class Anchors
    {
        /// <summary>
        /// By default, the match must occur at the beginning of the string; in multiline mode, it must occur at the beginning of the line.
        /// </summary>
        public static string StartOfStringOrLine = "^";

        /// <summary>
        /// By default, the match must occur at the end of the string or before \n at the end of the string; in multiline mode, it must occur at the end of the line or before \n at the end of the line.
        /// </summary>
        public static string EndOfStringOrLine = "$";

        /// <summary>
        /// The match must occur at the beginning of the string only (no multiline support).
        /// </summary>
        public static string StartOfStringOnly = @"\A";

        /// <summary>
        /// The match must occur at the end of the string, or before \n at the end of the string.
        /// </summary>
        public static string EndOfStringOrBeforeEndingNewline = @"\Z";

        /// <summary>
        /// The match must occur at the end of the string only.
        /// </summary>
        public static string EndOfStringOnly = @"\z";

        /// <summary>
        /// The match must start at the position where the previous match ended.
        /// </summary>
        public static string ContiguousMatches = @"\G";

        /// <summary>
        /// The match must occur on a word boundary.
        /// </summary>
        public static string WordBoundary = @"\b";

        /// <summary>
        /// The match must not occur on a word boundary.
        /// </summary>
        public static string NonWordBoundary = @"\B";
    }
}
