using System;

namespace ToyRobotSimulator.Model.Exceptions
{
    public class ToyRobotException : Exception
    {
        public ToyRobotException(string message) : base(message){ }
    }
}
