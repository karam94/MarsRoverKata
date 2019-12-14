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
            _rover = new MarsRover(new MarsRoverGrid(10, 10));
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

        [Test]
        [TestCase("RL", "0:0:N")]
        [TestCase("RRL", "0:0:E")]
        [TestCase("RRLLL", "0:0:W")]
        public void RotateLeftThenRotateRight(string command, string expectedOutput)
        {
            _rover.Execute(command).ShouldBe(expectedOutput);
        }

        [Test]
        [TestCase("M", "0:1:N")]
        [TestCase("MM", "0:2:N")]
        [TestCase("MMM", "0:3:N")]
        public void MoveForward(string command, string expectedOutput)
        {
            _rover.Execute(command).ShouldBe(expectedOutput);
        }     
        
        [Test]
        [TestCase("RM", "1:0:E")]
        [TestCase("RMM", "2:0:E")]
        [TestCase("RMML", "2:0:N")]
        [TestCase("RMMLM", "2:1:N")]
        [TestCase("MMRMMLM ", "2:3:N")]
        [TestCase("RRMMMM ", "0:6:S")]
        [TestCase("RRRMMMM ", "6:0:W")]
        public void RotateAndMoveForward(string command, string expectedOutput)
        {
            _rover.Execute(command).ShouldBe(expectedOutput);
        }

        [Test]
        [TestCase("MMMMMMMMMM", "0:0:N")]
        [TestCase("RMMMMMMMMMM", "0:0:E")]
        [TestCase("RRMMMMMMMMMM ", "0:0:S")]
        [TestCase("RRRMMMMMMMMMM ", "0:0:W")]
        [TestCase("RRRMMMMMMMMM ", "1:0:W")]
        [TestCase("MMMMMMMMMMM", "0:1:N")]
        public void WrapAroundGrid(string command, string expectedOutput)
        {
            _rover.Execute(command).ShouldBe(expectedOutput);
        }
    }
}