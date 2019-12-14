using MarsRoverKata;
using NUnit.Framework;
using Shouldly;

namespace MarsRoverKataTests
{
    public class MarsRoverShould
    {
        private MarsRover _rover;

        [SetUp]
        public void Setup()
        {
            _rover = new MarsRover();
        }

        [Test]
        public void StartByFacingNorth()
        {
            _rover.Execute("").ShouldBe("0:0:N");
        }

        [Test]
        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        [TestCase("RRRRR", "0:0:E")]
        public void RotateRight(string command, string expectedOutput)
        {
            _rover.Execute(command).ShouldBe(expectedOutput);
        }

        [Test]
        [TestCase("L", "0:0:W")]
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        [TestCase("LLLL", "0:0:N")]
        [TestCase("LLLLL", "0:0:W")]
        public void RotateLeft(string command, string expectedOutput)
        {
            _rover.Execute(command).ShouldBe(expectedOutput);
        }
    }
}