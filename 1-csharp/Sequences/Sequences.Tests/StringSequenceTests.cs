using Sequences.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sequences.Tests
{
    public class StringSequenceTests
    {
        [Theory]
        [InlineData("abc")]
        [InlineData("")]
        [InlineData(null)]
        public void AddShouldAdd(string item)
        {
            //arrange (any setup necessary to prepare for the behavior to test)
            var seq = new StringSequence();

            //act (do the thing you want to test)
            seq.Add(item);

            //assert (verify that the behavior was as expected)
            Assert.Equal(item, actual: seq[0]);
        }
        [Fact]
        public void AddShouldAddInConsistentOrder()
        {
            //arrange (any setup necessary to prepare for the behavior to test)
            var seq = new StringSequence();

            //act (do the thing you want to test)
            seq.Add("abc");
            seq.Add("def");

            //assert (verify that the behavior was as expected)
            Assert.Equal(expected: "abc", actual: seq[0]);
            Assert.Equal(expected: "def", actual: seq[1]);
        }
        [Fact]
        public void AccessOutOfBoundsShouldThrow()
        {
            //arrange
            var seq = new StringSequence();

            //act
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() =>
            {
                var x = seq[0];
            });
        }
        [Fact]
        public void LongestStringShouldReturnLongest()
        {
            //arrange
            var seq = new StringSequence();
            seq.Add("");
            seq.Add("abc");
            seq.Add("023456789");

            //act
            var longest = seq.LongestString();

            //assert
            Assert.Equal("0123456789", longest);
        }
        [Fact]
        public void RemoveShouldRemove()
        {
            //arrange
            var seq = new StringSequence();
            seq.Add("");
            seq.Add("abc");
            seq.Add("1234");


            //act
            seq.Remove("abc");

            //assert
            Assert.Equal("", actual: seq[0]);
            Assert.Equal("1234", actual: seq[1]);
        }
    }
}
