﻿namespace Grynwald.MarkdownGenerator
{
    /// <summary>
    /// Base class for all types of leaf blocks (blocks that cannot contain other blocks)
    /// For specification see <see href="https://spec.commonmark.org/0.28/#leaf-blocks">CommonMark - Leaf blocks</see>.
    /// </summary>
    public abstract class MdLeafBlock : MdBlock
    {
        // private protected constructor => class cannot be derived from outside this assembly
        private protected MdLeafBlock()
        {
        }
    }
}
