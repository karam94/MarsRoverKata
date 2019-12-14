namespace MarsRoverKata
{
    public class MarsRover
    {
        private readonly MarsRoverRotator _rotator = new MarsRoverRotator();
        private string _direction = "N";
        private int _x;
        private int _y;

        public string Execute(string commands)
        {
            foreach (var command in commands)
            {
                if (command == 'R')
                {
                    _direction = _rotator.RotateRight(_direction);
                }

                if (command == 'L')
                {
                    _direction = _rotator.RotateLeft(_direction);
                }

                if (command == 'M')
                {
                    if (_direction == "E" || _direction == "W") _x += 1;
                    else _y += 1;
                }
            }

            return $"{_x}:{_y}:{_direction}"; ;
        }
    }
}