namespace MarsRoverKata
{
    public class MarsRoverGrid
    {
        private readonly int _maximumX;
        private readonly int _maximumY;

        public MarsRoverGrid(int maximumX, int maximumY)
        {
            _maximumX = maximumX;
            _maximumY = maximumY;
        }

        public Coordinate Move(string currentDirection, Coordinate currentPosition)
        {
            if (currentDirection == "E")
            {
                currentPosition.IncrementX();                
                if (currentPosition.GetX() == -1) return new Coordinate(_maximumX - 1, currentPosition.GetY());
                if (currentPosition.GetX() == _maximumX) return new Coordinate(0, currentPosition.GetY());
            }

            if (currentDirection == "W")
            {
                currentPosition.DecrementX();
                if (currentPosition.GetX() == -1) return new Coordinate(_maximumX - 1, currentPosition.GetY());
                if (currentPosition.GetX() == _maximumX) return new Coordinate(0, currentPosition.GetY());
            }

            if (currentDirection == "N")
            {
                currentPosition.IncrementY();
                if (currentPosition.GetY() == -1) return new Coordinate(currentPosition.GetX(), _maximumY - 1);
                if (currentPosition.GetY() == _maximumY) return new Coordinate(currentPosition.GetX(), 0);
            }

            if (currentDirection == "S")
            {
                currentPosition.DecrementY();
                if (currentPosition.GetY() == -1) return new Coordinate(currentPosition.GetX(), _maximumY - 1);
                if (currentPosition.GetY() == _maximumY) return new Coordinate(currentPosition.GetX(), 0);
            }

            return currentPosition;
        }
    }
}