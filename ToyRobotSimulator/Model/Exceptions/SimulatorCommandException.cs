using System;

namespace ToyRobotSimulator.Model.Exceptions
{
    public class SimulatorCommandException : ToyRobotException
    {
        public SimulatorCommandException(string message) : base(message){ }
    }
}
