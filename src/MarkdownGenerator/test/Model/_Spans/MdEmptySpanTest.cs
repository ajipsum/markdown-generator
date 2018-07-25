﻿using Grynwald.MarkdownGenerator.Model;
using Xunit;

namespace Grynwald.MarkdownGenerator.Test.Model
{
    public class MdEmptySpanTest
    {
        [Fact]
        public void ToString_returns_the_expected_value()
        {
            Assert.Equal(string.Empty, MdEmptySpan.Instance.ToString());
        }
    }
}
