using ToyRobotSimulator.Model.Entity;
using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.Exceptions;
using ToyRobotSimulator.Model.ValueObject;
using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class ToyRobotShouldNotMove
    {
        [Fact]
        public void ForwardTowardNorth_FromMaxOrientationY()
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            toyRobot.Place(5, 5, Direction.NORTH);
            
            //Assert
            var ex = Assert.Throws<ToyRobotInvalidMoveException>(() => toyRobot.Move());
            Assert.Equal("Can't move forward toward north!", ex.Message);
        }

        [Fact]
        public void ForwardTowardEast_FromMaxOrientationX()
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            toyRobot.Place(5, 5, Direction.EAST);

            //Assert
            var ex = Assert.Throws<ToyRobotInvalidMoveException>(() => toyRobot.Move());
            Assert.Equal("Can't move forward toward east!", ex.Message);
        }

        [Fact]
        public void ForwardTowardWest_FromMinOrientationX()
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            toyRobot.Place(0, 5, Direction.WEST);

            //Assert
            var ex = Assert.Throws<ToyRobotInvalidMoveException>(() => toyRobot.Move());
            Assert.Equal("Can't move forward toward west!", ex.Message);
        }

        [Fact]
        public void ForwardTowardSouth_FromMinOrientationY()
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            toyRobot.Place(5, 0, Direction.SOUTH);

            //Assert
            var ex = Assert.Throws<ToyRobotInvalidMoveException>(() => toyRobot.Move());
            Assert.Equal("Can't move forward toward south!", ex.Message);
        }
    }
}
