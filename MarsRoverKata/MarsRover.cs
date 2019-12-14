namespace MarsRoverKata
{
    public class MarsRover
    {
        private readonly MarsRoverRotator _rotator = new MarsRoverRotator();
        private readonly MarsRoverMover _mover = new MarsRoverMover();
        private string _currentDirection;
        private Coordinate _currentPosition;

        public MarsRover()
        {
            _currentDirection = "N";
            _currentPosition = new Coordinate(0, 0);
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
                    _currentPosition = _mover.Move(_currentDirection, _currentPosition);
                }
            }

            return $"{_currentPosition.GetX()}:" +
                   $"{_currentPosition.GetY()}:" +
                   $"{_currentDirection}";
        }
    }
}