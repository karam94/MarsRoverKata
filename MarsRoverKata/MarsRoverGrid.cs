using System.Collections.Generic;
using System.Linq;

namespace MarsRoverKata
{
    public class MarsRoverGrid
    {
        private readonly int _maximumX;
        private readonly int _maximumY;
        private readonly List<Coordinate> _obstacles;

        public MarsRoverGrid(int maximumX, int maximumY, List<Coordinate> obstacles)
        {
            _maximumX = maximumX;
            _maximumY = maximumY;
            _obstacles = obstacles;
        }

        public Coordinate Move(string currentDirection, Coordinate currentPosition)
        {
            if (currentPosition.HasCrashed()) return currentPosition;

            if (currentDirection == "E")
            {
                if (!HasHitObstacle(currentPosition))
                {
                    currentPosition.IncrementX();
                    if (currentPosition.GetX() == -1) return new Coordinate(_maximumX - 1, currentPosition.GetY());
                    if (currentPosition.GetX() == _maximumX) return new Coordinate(0, currentPosition.GetY());
                    return currentPosition;
                }

                RoverHasCrashed(currentPosition);
                currentPosition.DecrementX(); // Crashed, so move back.
                return currentPosition;
            }

            if (currentDirection == "W")
            {
                if (!HasHitObstacle(currentPosition))
                {
                    currentPosition.DecrementX();
                    if (currentPosition.GetX() == -1) return new Coordinate(_maximumX - 1, currentPosition.GetY());
                    if (currentPosition.GetX() == _maximumX) return new Coordinate(0, currentPosition.GetY());
                    return currentPosition;
                }

                RoverHasCrashed(currentPosition);
                currentPosition.IncrementX(); // Crashed, so move back.
                return currentPosition;
            }

            if (currentDirection == "N")
            {
                if (!HasHitObstacle(currentPosition))
                {
                    currentPosition.IncrementY();
                    if (currentPosition.GetY() == -1) return new Coordinate(currentPosition.GetX(), _maximumY - 1);
                    if (currentPosition.GetY() == _maximumY) return new Coordinate(currentPosition.GetX(), 0);
                    return currentPosition;
                }

                RoverHasCrashed(currentPosition);
                currentPosition.DecrementY(); // Crashed, so move back.
                return currentPosition;
            }

            if (currentDirection == "S")
            {
                if (!HasHitObstacle(currentPosition))
                {
                    currentPosition.DecrementY();
                    if (currentPosition.GetY() == -1) return new Coordinate(currentPosition.GetX(), _maximumY - 1);
                    if (currentPosition.GetY() == _maximumY) return new Coordinate(currentPosition.GetX(), 0);
                    return currentPosition;
                }

                RoverHasCrashed(currentPosition);
                currentPosition.IncrementY(); // Crashed, so move back.
                return currentPosition;
            }

            return currentPosition;
        }

        private bool HasHitObstacle(Coordinate newPosition)
        {
            return _obstacles.Any(x => x.GetX().Equals(newPosition.GetX())
                                       && x.GetY().Equals(newPosition.GetY()));
        }

        private void RoverHasCrashed(Coordinate roverPosition)
        {
            roverPosition.SetCrashed();
        }
    }
}