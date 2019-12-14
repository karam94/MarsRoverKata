namespace MarsRoverKata
{
    public class Direction
    {
        public string Name { get; }
        public string LeftDirection { get; }
        public string RightDirection { get; }

        public Direction(string name, string leftDirection, string rightDirection)
        {
            Name = name;
            LeftDirection = leftDirection;
            RightDirection = rightDirection;
        }
    }
}