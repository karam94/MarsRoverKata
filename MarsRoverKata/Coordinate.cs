namespace MarsRoverKata
{
    public class Coordinate
    {
        private int X { get; set; }
        private int Y { get; set; }
        private bool Crashed { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
            Crashed = false;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public void IncrementX()
        {
            X += 1;
        }

        public void DecrementX()
        {
            X -= 1;
        }

        public void IncrementY()
        {
            Y += 1;
        }

        public void DecrementY()
        {
            Y -= 1;
        }

        public void SetCrashed()
        {
            Crashed = true;
        }

        public bool HasCrashed()
        {
            return Crashed;
        }
    }
}