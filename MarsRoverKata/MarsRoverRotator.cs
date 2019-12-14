using System.Collections.Generic;
using System.Linq;

namespace MarsRoverKata
{
    public class MarsRoverRotator
    {
        readonly List<Direction> _directions = new List<Direction>();

        public MarsRoverRotator()
        {
            _directions.Add(new Direction("N", "W", "E"));
            _directions.Add(new Direction("E", "N", "S"));
            _directions.Add(new Direction("S", "E", "W"));
            _directions.Add(new Direction("W", "S", "N"));
        }

        public string RotateRight(string direction)
        {
            return _directions.First(x => x.Name == direction).RightDirection;
        }

        public string RotateLeft(string direction)
        {
            return _directions.First(x => x.Name == direction).LeftDirection;
        }
    }
}