namespace MarsRoverKata
{
    public class MarsRoverMover
    {
        public Coordinate Move(string currentDirection, Coordinate currentPosition)
        {
            if (currentDirection == "E")
            {
                currentPosition.IncrementX();                
                if (currentPosition.GetX() == -1) return new Coordinate(9, currentPosition.GetY());
                if (currentPosition.GetX() == 10) return new Coordinate(0, currentPosition.GetY());
            }

            if (currentDirection == "W")
            {
                currentPosition.DecrementX();
                if (currentPosition.GetX() == -1) return new Coordinate(9, currentPosition.GetY());
                if (currentPosition.GetX() == 10) return new Coordinate(0, currentPosition.GetY());
            }

            if (currentDirection == "N")
            {
                currentPosition.IncrementY();
                if (currentPosition.GetY() == -1) return new Coordinate(currentPosition.GetX(), 9);
                if (currentPosition.GetY() == 10) return new Coordinate(currentPosition.GetX(), 0);
            }

            if (currentDirection == "S")
            {
                currentPosition.DecrementY();
                if (currentPosition.GetY() == -1) return new Coordinate(currentPosition.GetX(), 9);
                if (currentPosition.GetY() == 10) return new Coordinate(currentPosition.GetX(), 0);
            }

            return currentPosition;
        }
    }
}