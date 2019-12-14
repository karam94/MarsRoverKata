namespace MarsRoverKata
{
    public class MarsRover
    {
        private readonly MarsRoverRotator _rotator;
        private readonly MarsRoverGrid _grid;
        private string _currentDirection;
        private Coordinate _currentPosition;

        public MarsRover(MarsRoverGrid grid)
        {
            _grid = grid;

            _currentDirection = "N";
            _currentPosition = new Coordinate(0, 0);
            _rotator = new MarsRoverRotator();
        }

        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                if (command == 'R')
                {
                    _currentDirection = _rotator.RotateRight(_currentDirection);
                }

                if (command == 'L')
                {
                    _currentDirection = _rotator.RotateLeft(_currentDirection);
                }

                if (command == 'M')
                {
                    _currentPosition = _grid.Move(_currentDirection, _currentPosition);
                }
            }

            return $"{_currentPosition.GetX()}:" +
                   $"{_currentPosition.GetY()}:" +
                   $"{_currentDirection}";
        }
    }
}