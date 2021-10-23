using ToyRobotSimulator.Model.Entity;
using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.ValueObject;
using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class ToyRobotShouldLeft
    {
        [Theory]
        [InlineData(Direction.NORTH, Direction.WEST)]
        [InlineData(Direction.WEST, Direction.SOUTH)]
        [InlineData(Direction.SOUTH, Direction.EAST)]
        [InlineData(Direction.EAST, Direction.NORTH)]
        public void Turn(Direction currentDirection, Direction expectedDirection)
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            toyRobot.Place(0, 0, currentDirection);

            //Act
            var newDirection = toyRobot.Left();

            //Assert
            Assert.Equal(expectedDirection, newDirection);
        }
    }
}
