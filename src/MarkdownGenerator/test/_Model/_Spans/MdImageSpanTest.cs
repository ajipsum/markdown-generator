﻿using Xunit;

namespace Grynwald.MarkdownGenerator.Test
{
    public class MdImageSpanTest
    {
        [Theory]
        [InlineData("http://example.com/image.jpg")] // absolute uri
        [InlineData("./image.png")]                  // relative path
        public void ToString_returns_the_expected_value(string link)
        {
            var description = "Description";
            var expectedValue = $"![{description}]({link})";

            var span = new MdImageSpan(description, link);

            Assert.Equal(expectedValue, span.ToString());
        }

        [Theory]
        [MarkdownSpecialCharacterData]
        public void ToString_escapes_special_characters_in_image_description(char charToEscape)
        {
            var description = $"prefix{charToEscape}suffix";
            var link = "file.png";
            var span = new MdImageSpan(description, link);

            var expectedValue = $"![prefix\\{charToEscape}suffix]({link})";

            Assert.Equal(expectedValue, span.ToString());
        }

        [Fact]
        public void ToString_returns_an_empty_string_if_both_description_and_uri_are_empty()
        {
            Assert.Equal(string.Empty, new MdImageSpan("", "").ToString());
        }
    }
}