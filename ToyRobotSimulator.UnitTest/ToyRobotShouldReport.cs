using ToyRobotSimulator.Model.Entity;
using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.Exceptions;
using ToyRobotSimulator.Model.ValueObject;
using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class ToyRobotShouldReport
    {
        [Theory]
        [InlineData(0, 0, Direction.NORTH, "Output: 0,0,NORTH")]
        public void OutputPositionXYAndDirection_WhenPlacedWithDirection(int x, int y, Direction direction, string expecteAnnouncement)
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            toyRobot.Place(x, y, direction);

            //Act
            var announcement = toyRobot.Report();

            //Assert
            Assert.Equal(expecteAnnouncement, announcement);
        }

        [Theory]
        [InlineData(3, 5, "Output: 3,5,WEST")]
        public void OutputPositionXYAndDirection_WhenPlacedWithoutChangingDirection(int x, int y, string expecteAnnouncement)
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            //Place robot
            toyRobot.Place(0, 0, Direction.WEST);

            //Replace without direction when already placed on the table should not change direction
            toyRobot.Place(x, y);

            //Act
            var announcement = toyRobot.Report();

            //Assert
            Assert.Equal(expecteAnnouncement, announcement);
        }
    }
}
