using System;
using System.Text.RegularExpressions;
using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.Exceptions;
using ToyRobotSimulator.Model.ValueObject;

namespace ToyRobotSimulator.Model.Entity
{
    public class ToyRobotSimulator
    {
        private static ToyRobot _toyRobot;

        public bool Setup(int width, int height)
        {
            if(width < 1 || height < 1)
            {
                throw new ToyRobotException("Dimension can only greater than zero atleast (1,1)!");
            }

            var dimension = new Dimension(width, height);
            _toyRobot = new ToyRobot(dimension);

            return true;
        }

        public string Command(string input)
        {
            var output = string.Empty;
            var placeCommandPattern = @"^((place \d+,\d+(,north|,south|,east|,west)*)|move|left|right|report)$";

            if (!Regex.IsMatch(input, placeCommandPattern, RegexOptions.IgnoreCase))
            {
                throw new SimulatorCommandException("Invalid command");
            }

            var validCommand = input.ToLower();

            if (validCommand.StartsWith("place"))
            {
                var placeCommand = validCommand.Split(' ');
                var parameters = placeCommand[1].Split(',');
                var x = Convert.ToInt32(parameters[0]);
                var y = Convert.ToInt32(parameters[1]);

                if (parameters.Length == 2)
                    _toyRobot.Place(x, y);
                else
                    _toyRobot.Place(x, y, (Direction)Enum.Parse(typeof(Direction), parameters[2].ToUpper()));
            }
            else if (validCommand.StartsWith("move")) { _toyRobot.Move(); }
            else if (validCommand.StartsWith("left")) { _toyRobot.Left(); }
            else if (validCommand.StartsWith("right")) { _toyRobot.Right(); }
            else if (validCommand.StartsWith("report")) { output = _toyRobot.Report(); }

            return output;
        }
    }
}
