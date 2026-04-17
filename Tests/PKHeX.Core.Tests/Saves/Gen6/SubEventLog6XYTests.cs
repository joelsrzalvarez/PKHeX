using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PKHeX.Core.Tests.Saves.Gen6
{
    public class SubEventLog6XYTests
    {
        [Theory]
        [InlineData((ushort)0, (ushort)0)]
        [InlineData((ushort)1, (ushort)5)]
        [InlineData((ushort)2, (ushort)30)]
        [InlineData((ushort)3, (ushort)100)]
        [InlineData((ushort)4, (ushort)300)]
        [InlineData((ushort)5, (ushort)1000)]
        public void GetChateauPointsForRank_ReturnsExpectedPoints(ushort rank, ushort expectedPoints)
        {
            var result = SubEventLog6XY.GetChateauPointsForRank(rank);
            Assert.Equal(expectedPoints, result);
        }

        [Theory]
        [InlineData((ushort)6)]
        [InlineData((ushort)7)]
        [InlineData((ushort)15)]
        public void GetChateauPointsForRank_InvalidRank_Throws(ushort rank)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => SubEventLog6XY.GetChateauPointsForRank(rank));
        }
    }
}
