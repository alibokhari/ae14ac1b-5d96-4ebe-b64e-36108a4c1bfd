﻿using ToyRobotSimulator.Model.Entity;
using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.ValueObject;
using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class ToyRobotShouldMove
    {
        [Theory]
        [InlineData(0, 0, Direction.NORTH, 0, 1)]
        [InlineData(0, 1, Direction.NORTH, 0, 2)]
        [InlineData(0, 2, Direction.NORTH, 0, 3)]
        [InlineData(0, 3, Direction.NORTH, 0, 4)]
        [InlineData(0, 4, Direction.NORTH, 0, 5)]
        [InlineData(1, 0, Direction.NORTH, 1, 1)]
        [InlineData(1, 1, Direction.NORTH, 1, 2)]
        [InlineData(1, 2, Direction.NORTH, 1, 3)]
        [InlineData(1, 3, Direction.NORTH, 1, 4)]
        [InlineData(1, 4, Direction.NORTH, 1, 5)]
        [InlineData(2, 0, Direction.NORTH, 2, 1)]
        [InlineData(2, 1, Direction.NORTH, 2, 2)]
        [InlineData(2, 2, Direction.NORTH, 2, 3)]
        [InlineData(2, 3, Direction.NORTH, 2, 4)]
        [InlineData(2, 4, Direction.NORTH, 2, 5)]
        [InlineData(3, 0, Direction.NORTH, 3, 1)]
        [InlineData(3, 1, Direction.NORTH, 3, 2)]
        [InlineData(3, 2, Direction.NORTH, 3, 3)]
        [InlineData(3, 3, Direction.NORTH, 3, 4)]
        [InlineData(3, 4, Direction.NORTH, 3, 5)]
        [InlineData(4, 0, Direction.NORTH, 4, 1)]
        [InlineData(4, 1, Direction.NORTH, 4, 2)]
        [InlineData(4, 2, Direction.NORTH, 4, 3)]
        [InlineData(4, 3, Direction.NORTH, 4, 4)]
        [InlineData(4, 4, Direction.NORTH, 4, 5)]
        [InlineData(5, 0, Direction.NORTH, 5, 1)]
        [InlineData(5, 1, Direction.NORTH, 5, 2)]
        [InlineData(5, 2, Direction.NORTH, 5, 3)]
        [InlineData(5, 3, Direction.NORTH, 5, 4)]
        [InlineData(5, 4, Direction.NORTH, 5, 5)]

        [InlineData(0, 5, Direction.SOUTH, 0, 4)]
        [InlineData(0, 4, Direction.SOUTH, 0, 3)]
        [InlineData(0, 3, Direction.SOUTH, 0, 2)]
        [InlineData(0, 2, Direction.SOUTH, 0, 1)]
        [InlineData(0, 1, Direction.SOUTH, 0, 0)]
        [InlineData(1, 5, Direction.SOUTH, 1, 4)]
        [InlineData(1, 4, Direction.SOUTH, 1, 3)]
        [InlineData(1, 3, Direction.SOUTH, 1, 2)]
        [InlineData(1, 2, Direction.SOUTH, 1, 1)]
        [InlineData(1, 1, Direction.SOUTH, 1, 0)]
        [InlineData(2, 5, Direction.SOUTH, 2, 4)]
        [InlineData(2, 4, Direction.SOUTH, 2, 3)]
        [InlineData(2, 3, Direction.SOUTH, 2, 2)]
        [InlineData(2, 2, Direction.SOUTH, 2, 1)]
        [InlineData(2, 1, Direction.SOUTH, 2, 0)]
        [InlineData(3, 5, Direction.SOUTH, 3, 4)]
        [InlineData(3, 4, Direction.SOUTH, 3, 3)]
        [InlineData(3, 3, Direction.SOUTH, 3, 2)]
        [InlineData(3, 2, Direction.SOUTH, 3, 1)]
        [InlineData(3, 1, Direction.SOUTH, 3, 0)]
        [InlineData(4, 5, Direction.SOUTH, 4, 4)]
        [InlineData(4, 4, Direction.SOUTH, 4, 3)]
        [InlineData(4, 3, Direction.SOUTH, 4, 2)]
        [InlineData(4, 2, Direction.SOUTH, 4, 1)]
        [InlineData(4, 1, Direction.SOUTH, 4, 0)]
        [InlineData(5, 5, Direction.SOUTH, 5, 4)]
        [InlineData(5, 4, Direction.SOUTH, 5, 3)]
        [InlineData(5, 3, Direction.SOUTH, 5, 2)]
        [InlineData(5, 2, Direction.SOUTH, 5, 1)]
        [InlineData(5, 1, Direction.SOUTH, 5, 0)]

        [InlineData(0, 5, Direction.EAST, 1, 5)]
        [InlineData(0, 4, Direction.EAST, 1, 4)]
        [InlineData(0, 3, Direction.EAST, 1, 3)]
        [InlineData(0, 2, Direction.EAST, 1, 2)]
        [InlineData(0, 1, Direction.EAST, 1, 1)]
        [InlineData(0, 0, Direction.EAST, 1, 0)]
        [InlineData(1, 5, Direction.EAST, 2, 5)]
        [InlineData(1, 4, Direction.EAST, 2, 4)]
        [InlineData(1, 3, Direction.EAST, 2, 3)]
        [InlineData(1, 2, Direction.EAST, 2, 2)]
        [InlineData(1, 1, Direction.EAST, 2, 1)]
        [InlineData(1, 0, Direction.EAST, 2, 0)]
        [InlineData(2, 5, Direction.EAST, 3, 5)]
        [InlineData(2, 4, Direction.EAST, 3, 4)]
        [InlineData(2, 3, Direction.EAST, 3, 3)]
        [InlineData(2, 2, Direction.EAST, 3, 2)]
        [InlineData(2, 1, Direction.EAST, 3, 1)]
        [InlineData(2, 0, Direction.EAST, 3, 0)]
        [InlineData(3, 5, Direction.EAST, 4, 5)]
        [InlineData(3, 4, Direction.EAST, 4, 4)]
        [InlineData(3, 3, Direction.EAST, 4, 3)]
        [InlineData(3, 2, Direction.EAST, 4, 2)]
        [InlineData(3, 1, Direction.EAST, 4, 1)]
        [InlineData(3, 0, Direction.EAST, 4, 0)]
        [InlineData(4, 5, Direction.EAST, 5, 5)]
        [InlineData(4, 4, Direction.EAST, 5, 4)]
        [InlineData(4, 3, Direction.EAST, 5, 3)]
        [InlineData(4, 2, Direction.EAST, 5, 2)]
        [InlineData(4, 1, Direction.EAST, 5, 1)]
        [InlineData(4, 0, Direction.EAST, 5, 0)]

        [InlineData(1, 5, Direction.WEST, 0, 5)]
        [InlineData(1, 4, Direction.WEST, 0, 4)]
        [InlineData(1, 3, Direction.WEST, 0, 3)]
        [InlineData(1, 2, Direction.WEST, 0, 2)]
        [InlineData(1, 1, Direction.WEST, 0, 1)]
        [InlineData(1, 0, Direction.WEST, 0, 0)]
        [InlineData(2, 5, Direction.WEST, 1, 5)]
        [InlineData(2, 4, Direction.WEST, 1, 4)]
        [InlineData(2, 3, Direction.WEST, 1, 3)]
        [InlineData(2, 2, Direction.WEST, 1, 2)]
        [InlineData(2, 1, Direction.WEST, 1, 1)]
        [InlineData(2, 0, Direction.WEST, 1, 0)]
        [InlineData(3, 5, Direction.WEST, 2, 5)]
        [InlineData(3, 4, Direction.WEST, 2, 4)]
        [InlineData(3, 3, Direction.WEST, 2, 3)]
        [InlineData(3, 2, Direction.WEST, 2, 2)]
        [InlineData(3, 1, Direction.WEST, 2, 1)]
        [InlineData(3, 0, Direction.WEST, 2, 0)]
        [InlineData(4, 5, Direction.WEST, 3, 5)]
        [InlineData(4, 4, Direction.WEST, 3, 4)]
        [InlineData(4, 3, Direction.WEST, 3, 3)]
        [InlineData(4, 2, Direction.WEST, 3, 2)]
        [InlineData(4, 1, Direction.WEST, 3, 1)]
        [InlineData(4, 0, Direction.WEST, 3, 0)]
        [InlineData(5, 5, Direction.WEST, 4, 5)]
        [InlineData(5, 4, Direction.WEST, 4, 4)]
        [InlineData(5, 3, Direction.WEST, 4, 3)]
        [InlineData(5, 2, Direction.WEST, 4, 2)]
        [InlineData(5, 1, Direction.WEST, 4, 1)]
        [InlineData(5, 0, Direction.WEST, 4, 0)]

        public void ForwardFromCurrentPosition_ToExpectedOrientation(int x, int y, Direction direction, int expectedX, int expectedY)
        {
            //Arrange
            var dimension = new Dimension(6, 6);
            var toyRobot = new ToyRobot(dimension);
            toyRobot.Place(x, y, direction);

            //Act
            var newPosition = toyRobot.Move();

            //Assert
            Assert.Equal(expectedX, newPosition.X);
            Assert.Equal(expectedY, newPosition.Y);
        }
    }
}
