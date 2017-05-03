using System;
using Xunit;
using Library;
using FluentAssertions;

namespace CharacterCounterTests
{
    public class GetCountForLetter
    {
        [Fact]
        public void Should_return_a_count_of_1_if_there_is_a_single_letter_to_parse()
        {
            CharacterCounter counter = new CharacterCounter();
            counter.ParseString("a");
            Assert.Equal(1,counter.GetCountForLetter('a'));
            counter.GetCountForLetter('a').Should().Be(1);//FluentAssertions
        }
    }
}
