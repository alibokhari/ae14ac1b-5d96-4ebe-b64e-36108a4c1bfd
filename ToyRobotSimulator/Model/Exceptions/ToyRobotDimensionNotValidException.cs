using System;

namespace ToyRobotSimulator.Model.Exceptions
{
    public class ToyRobotDimensionNotValidException : ToyRobotException
    {
        public ToyRobotDimensionNotValidException() : base("Dimension can't be negative or zero!") { }
    }
}
