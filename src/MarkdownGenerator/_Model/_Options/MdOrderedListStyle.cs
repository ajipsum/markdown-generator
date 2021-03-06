﻿namespace Grynwald.MarkdownGenerator
{
    /// <summary>
    /// Defines the available serialization styles for ordered lists (see <see cref="MdBulletList"/>).
    /// For specification see <see href="https://spec.commonmark.org/0.28/#list-items">CommonMark - List items</see>.
    /// </summary>
    /// <seealso cref="MdOrderedList"/>
    public enum MdOrderedListStyle
    {
        /// <summary>
        /// Use dots for ordered list item markers (e.g. "1.", "2." ...) (default)
        /// </summary>
        Dot = 0,

        /// <summary>
        /// Use parentheses for ordered list item markers (e.g. "1)", "2)" ...)
        /// </summary>
        Parenthesis = 1
    }
}
