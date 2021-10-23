using ToyRobotSimulator.Model.Entity;
using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.ValueObject;
using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class ToyRobotShouldPlace
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 5, Direction.NORTH)]
        [InlineData(5, 0, Direction.WEST)]
        [InlineData(5, 5, Direction.SOUTH)]
        [InlineData(2, 3, Direction.EAST)]
        public void AtValidPositionXY_WithinGivenDimension(int x, int y, Direction? direction = null)
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);

            //Act
            var placed = toyRobot.Place(x, y, direction);

            //Assert
            Assert.True(placed);
        }
    }
}
