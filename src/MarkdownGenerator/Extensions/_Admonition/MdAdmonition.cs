﻿using System;
using System.Collections.Generic;
using Grynwald.MarkdownGenerator.Internal;

namespace Grynwald.MarkdownGenerator.Extensions
{
    /// <summary>
    /// Represents a "admonition" in a markdown document implemented by
    /// the "Admonition" extension for Python-Markdown.
    /// For details see <see href="https://python-markdown.github.io/extensions/admonition/">Python-Markdown: Admonition</see>.
    /// </summary>
    /// <remarks>
    /// Using this element will produce markdown which will not be rendered correctly
    /// by most Markdown implementation and should only be used, when the renderer
    /// is known to be Python Markdown with the Admonition extension enabled.
    /// </remarks>
    public class MdAdmonition : MdContainerBlockBase
    {
        /// <summary>
        /// Get the admonition's type.
        /// </summary>
        /// <value>The admonition's type as specified when the instance was initialized.</value>
        public string Type { get; }

        /// <summary>
        /// Gets the admonition's (optional) title
        /// </summary>
        /// <value>The admonition's title as specified when the instance was initialized. Value is guaranteed to be not <c>null</c>.</value>
        public MdSpan Title { get; }


        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/> without content.
        /// </summary>
        ///
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        /// 
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        public MdAdmonition(string type) : this(type, MdEmptySpan.Instance, Array.Empty<MdBlock>())
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/> with the specified type and title but without any content.
        /// </summary>
        /// 
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="title">
        /// The admonition's title. To create a admonition without title, use a different constructor overload.
        /// </param>
        ///
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="title"/> is <c>null</c>.</exception>
        public MdAdmonition(string type, MdSpan title) : this(type, title, Array.Empty<MdBlock>())
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/> with the specified type and content.
        /// </summary>
        /// 
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        ///
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        public MdAdmonition(string type, MdContainerBlockBase content) : this(type, MdEmptySpan.Instance, (MdBlock)content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/>.
        /// </summary>
        ///
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="title">
        /// The admonition's title. To create a admonition without title, use a different constructor overload.
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        /// 
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="title"/> is <c>null</c>.</exception>
        public MdAdmonition(string type, MdSpan title, MdContainerBlockBase content) : this(type, title, (MdBlock)content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/>.
        /// </summary>
        /// 
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        /// 
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        public MdAdmonition(string type, MdList content) : this(type, MdEmptySpan.Instance, (MdBlock)content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/>.
        /// </summary>
        /// 
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="title">
        /// The admonition's title. To create a admonition without title, use a different constructor overload.
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        ///
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="title"/> is <c>null</c>.</exception>
        public MdAdmonition(string type, MdSpan title, MdList content) : this(type, title, (MdBlock)content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/>.
        /// </summary>
        /// 
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        ///
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        public MdAdmonition(string type, params MdBlock[] content) : this(type, MdEmptySpan.Instance, (IEnumerable<MdBlock>)content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/>.
        /// </summary>
        ///
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="title">
        /// The admonition's title. To create a admonition without title, use a different constructor overload.
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        /// 
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="title"/> is <c>null</c>.</exception>
        public MdAdmonition(string type, MdSpan title, params MdBlock[] content) : this(type, title, (IEnumerable<MdBlock>)content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/>.
        /// </summary>
        ///
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        /// 
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        public MdAdmonition(string type, IEnumerable<MdBlock> content) : this(type, MdEmptySpan.Instance, content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdAdmonition"/>.
        /// </summary>
        ///
        /// <param name="type">
        /// The admonition's type. Any non-empty string is allowed.
        /// Recommended values are <c>attention</c>, <c>caution</c>, <c>danger</c>, <c>error</c>,
        /// <c>hint</c>, <c>important</c>, <c>note</c>, <c>tip</c> and <c>warning</c>
        /// </param>
        ///
        /// <param name="title">
        /// The admonition's title. To create a admonition without title, use a different constructor overload.
        /// </param>
        ///
        /// <param name="content">
        /// The admonition's content.
        /// </param>
        ///
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> is null or whitespace.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="title"/> is <c>null</c>.</exception>
        public MdAdmonition(string type, MdSpan title, IEnumerable<MdBlock> content) : base(content)
        {
            if (String.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Value must not be null or whitespace", nameof(type));

            Type = type;
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }


        /// <inheritdoc />
        public override bool DeepEquals(MdBlock? other) => other is MdAdmonition containerBlock ? DeepEquals(containerBlock) : false;

        /// <inheritdoc />
        internal override void Accept(IBlockVisitor visitor) => visitor.Visit(this);
    }
}
