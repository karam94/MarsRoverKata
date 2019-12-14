namespace MarsRoverKata
{
    public class MarsRover
    {
        private readonly MarsRoverRotator _rotator = new MarsRoverRotator();
        private string _direction = "N";

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
            }

            return $"0:0:{_direction}"; ;
        }
    }
}