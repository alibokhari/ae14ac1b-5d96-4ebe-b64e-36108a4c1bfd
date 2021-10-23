namespace ToyRobotSimulator.Model.ValueObject
{
    public class Orientation
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Orientation()
        {
        }

        public void SetOrientation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void IncrementX() => X++;
        public void IncrementY() => Y++;
        public void DecrementX() => X--;
        public void DecrementY() => Y--;

    }
}
