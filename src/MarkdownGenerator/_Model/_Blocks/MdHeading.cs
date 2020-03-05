﻿using System;
using Grynwald.MarkdownGenerator.Internal;

namespace Grynwald.MarkdownGenerator
{
    /// <summary>
    /// Represents a heading in a markdown document
    /// For specification see <see href="https://spec.commonmark.org/0.28/#atx-headings">CommonMark - ATX headings</see>
    /// respectively <see href="https://spec.commonmark.org/0.28/#setext-headings">CommonMark - Setext headings</see>.
    /// </summary>
    /// <remarks>
    /// If a heading is serialized as ATX heading (lines prefixed with '#') or as setext heading (underlined with '=' respectively '-')
    /// Is controlled using <see cref="MdSerializationOptions.HeadingStyle" /> property.
    /// See <see cref="MdSerializationOptions"/> for details.
    /// </remarks>
    /// <seealso cref="MdHeadingStyle"/>
    /// <seealso cref="MdHeadingAnchorStyle"/>
    public sealed class MdHeading : MdLeafBlock
    {
        /// <summary>
        /// The text of the heading
        /// </summary>
        public MdSingleLineSpan Text { get; }

        /// <summary>
        /// Gets the level of the heading, 1 being the top-most heading.
        /// </summary>
        /// <remarks>
        /// Value will always be in the range of 1-6 (inclusive)
        /// </remarks>
        public int Level { get; }


        /// <summary>
        /// Gets or sets the HTML anchor for this heading.        
        /// </summary>
        /// <remarks>
        /// The HTML anchor can be used for linking to a heading within a page.
        /// <para>
        /// Property is initialized with an auto-generated value derived from the heading text by removing all
        /// punctuation, replacing spaces with dashes and converting the text to lower case.
        /// </para>
        /// <para>
        /// The anchor does not include the leading '#' required for links.
        /// </para>
        /// <para>
        /// Note: Text anchors are not part of the CommonMark spec so linking to this anchor
        /// might not work in  every markdown implementation.
        /// To explicitly include an anchor tag in the output, set <see cref="MdSerializationOptions.HeadingAnchorStyle"/> to <see cref="MdHeadingAnchorStyle.Tag"/>.
        /// </para>
        /// </remarks>
        public string? Anchor { get; set; }


        /// <summary>
        /// Initializes a new instance of <see cref="MdHeading"/>
        /// </summary>
        /// <param name="text">The text of the heading. Must not be null.</param>
        /// <param name="level">The heading's level. Value must be in the range [1,6]</param>
        public MdHeading(MdSpan text, int level)
        {
            if (level < 1 || level > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(level), "Value must be in the range [1,6]");
            }

            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (text is MdSingleLineSpan singleLineSpan)
            {
                Text = singleLineSpan;
            }
            else
            {
                Text = new MdSingleLineSpan(text);
            }

            Level = level;

            Anchor = HtmlUtilities.ToUrlSlug(Text.ToString());
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MdHeading"/>
        /// </summary>
        /// <param name="level">The heading's level. Value must be in the range [1,6]</param>
        /// <param name="text">The text of the heading. Must not be null.</param>
        public MdHeading(int level, MdSpan text) : this(text, level)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdHeading"/>
        /// </summary>
        /// <param name="level">The heading's level. Value must be in the range [1,6]</param>
        /// <param name="text">The text of the heading. Must not be null.</param>
        public MdHeading(int level, params MdSpan[] text) : this(new MdCompositeSpan(text), level)
        { }


        /// <inheritdoc />
        public override bool DeepEquals(MdBlock? other) => DeepEquals(other as MdHeading);


        /// <inheritdoc />
        internal override void Accept(IBlockVisitor visitor) => visitor.Visit(this);


        private bool DeepEquals(MdHeading? other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Level == other.Level &&
                   Text.DeepEquals(other.Text);
        }
    }
}
