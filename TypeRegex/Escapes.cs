namespace TypeRegex
{
    /// <summary>
    /// List of constant character escapes supported by regular expressions in .NET.
    /// </summary>
    public static class Escapes
    {
        /// <summary>
        /// Matches a bell (alarm) character, \u0007.
        /// </summary>
        public static string Bell { get; } = @"\u0007";

        /// <summary>
        /// Matches a bell (alarm) character, \u0007.
        /// </summary>
        public static string Alarm { get; } = Bell;

        /// <summary>
        /// Matches a backspace character, \u0008.
        /// </summary>
        public static string Backspace { get; } = @"\u0008";

        /// <summary>
        /// Matches a tab character, \u0009.
        /// </summary>
        public static string Tab { get; } = @"\u0009";

        /// <summary>
        /// Matches a carriage return character, \u000D. Note that \r is not equivalent to the newline character, \n.
        /// </summary>
        public static string CarriageReturn { get; } = @"\u000D";

        /// <summary>
        /// Matches a vertical tab character, \u000B.
        /// </summary>
        public static string VerticalTab { get; } = @"\u000B";

        /// <summary>
        /// Matches a form feed character, \u000C.
        /// </summary>
        public static string FormFeed { get; } = @"\u000C";

        /// <summary>
        /// Matches a new line character, \u000A.
        /// </summary>
        public static string NewLine { get; } = @"\u000A";

        /// <summary>
        /// Matches an escape character, \u001B.
        /// </summary>
        public static string Escape { get; } = @"\u001B";

        /// <summary>
        /// Matches a new line character, \u000A, preceded or not by a carriage return character, \u000D.
        /// </summary>
        public static string WindowsNewLine { get; } = @"\u000D?\u000A";
    }
}
