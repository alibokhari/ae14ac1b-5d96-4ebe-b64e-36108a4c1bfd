using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.Exceptions;
using ToyRobotSimulator.Model.ValueObject;

namespace ToyRobotSimulator.Model.Entity
{
    public class ToyRobot
    {
        private bool _isPlaced = false;

        private Orientation Orientation { get; set; }
        private Direction Direction { get; set; }
        private Dimension Dimension { get; set; }

        public ToyRobot(Dimension dimension)
        {
            if(dimension.Width <= 0 || dimension.Height <= 0)
            {
                throw new ToyRobotDimensionNotValidException();
            }

            Dimension = dimension;
            Orientation = new Orientation();
        }

        public Direction Right()
        {
            if (!_isPlaced)
            {
                throw new ToyRobotInvalidRightException("Please first place toy robot on the table!");
            }

            switch (Direction)
            {
                case Direction.NORTH:
                    Direction = Direction.EAST;
                    break;
                case Direction.SOUTH:
                    Direction = Direction.WEST;
                    break;
                case Direction.EAST:
                    Direction = Direction.SOUTH;
                    break;
                case Direction.WEST:
                    Direction = Direction.NORTH;
                    break;
                default:
                    break;
            }
            return Direction;
        }

        public Direction Left()
        {
            if (!_isPlaced)
            {
                throw new ToyRobotInvalidLeftException("Please first place toy robot on the table!");
            }

            switch (Direction)
            {
                case Direction.NORTH:
                    Direction = Direction.WEST;
                    break;
                case Direction.SOUTH:
                    Direction = Direction.EAST;
                    break;
                case Direction.EAST:
                    Direction = Direction.NORTH;
                    break;
                case Direction.WEST:
                    Direction = Direction.SOUTH;
                    break;
                default:
                    break;
            }
            return Direction;
        }

        public string Report()
        {
            if (!_isPlaced)
            {
                throw new ToyRobotInvalidReportException("Please first place toy robot on the table!");
            }

            return $"Output: {Orientation.X},{Orientation.Y},{Direction.GetDescription()}";
        }

        public bool Place(int x, int y, Direction? direction = null)
        {
            _isPlaced = true;
            if (x >= 0 && x < Dimension.Width && y >= 0 && y < Dimension.Height)
            {
                Orientation.SetOrientation(x, y);

                if (direction.HasValue)
                {
                    Direction = direction.Value;
                }

                return true;
            }

            var exceptionMessage = $"Can't place toy robot at {x},{y}, valid dimension is (0,0) ({Dimension.Width-1},{Dimension.Height-1})";
            throw new ToyRobotInvalidPlaceException(exceptionMessage);
        }

        public Orientation Move()
        {
            if (!_isPlaced)
                throw new ToyRobotInvalidMoveException("Please first place toy robot on the table!");

            if (Direction == Direction.NORTH && Orientation.Y == Dimension.Height - 1)
                throw new ToyRobotInvalidMoveException("Can't move forward toward north!");

            if (Direction == Direction.EAST && Orientation.X == Dimension.Width - 1)
                throw new ToyRobotInvalidMoveException("Can't move forward toward east!");

            if (Direction == Direction.WEST && Orientation.X == 0)
                throw new ToyRobotInvalidMoveException("Can't move forward toward west!");
            
            if (Direction == Direction.SOUTH && Orientation.Y == 0)
                throw new ToyRobotInvalidMoveException("Can't move forward toward south!");

            switch (Direction)
            {
                case Direction.NORTH:
                    Orientation.IncrementY();
                    break;
                case Direction.SOUTH:
                    Orientation.DecrementY();
                    break;
                case Direction.EAST:
                    Orientation.IncrementX();
                    break;
                case Direction.WEST:
                    Orientation.DecrementX();
                    break;
            }

            return Orientation;
        }
    }
}
