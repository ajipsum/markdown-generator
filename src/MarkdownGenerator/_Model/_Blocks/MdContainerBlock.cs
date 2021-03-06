﻿using System.Collections.Generic;
using Grynwald.MarkdownGenerator.Internal;

namespace Grynwald.MarkdownGenerator
{
    /// <summary>
    /// Represents a block that can contains other blocks.
    /// For specification see <see href="https://spec.commonmark.org/0.28/#container-blocks">CommonMark - Container blocks </see>.
    /// </summary>
    public sealed class MdContainerBlock : MdContainerBlockBase
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MdContainerBlock"/>.
        /// </summary>
        public MdContainerBlock() : base()
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdContainerBlock"/> with the specified content.
        /// </summary>
        /// <param name="content">The block to add to the container.</param>
        public MdContainerBlock(MdContainerBlockBase content) : base(content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdContainerBlock"/> with the specified content.
        /// </summary>
        /// <param name="content">The block to add to the container.</param>
        public MdContainerBlock(MdList content) : base(content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdContainerBlock"/> with the specified content.
        /// </summary>
        /// <param name="content">The blocks to add to the container.</param>
        public MdContainerBlock(params MdBlock[] content) : base(content)
        { }

        /// <summary>
        /// Initializes a new instance of <see cref="MdContainerBlock"/> with the specified content.
        /// </summary>
        /// <param name="content">The blocks the container blocks contains</param>
        public MdContainerBlock(IEnumerable<MdBlock> content) : base(content)
        { }


        /// <inheritdoc />
        public override bool DeepEquals(MdBlock? other) => other is MdContainerBlock containerBlock ? DeepEquals(containerBlock) : false;


        /// <inheritdoc />
        internal override void Accept(IBlockVisitor visitor) => visitor.Visit(this);
    }
}
