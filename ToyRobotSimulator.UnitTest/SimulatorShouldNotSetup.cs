using ToyRobotSimulator.Model.Entity;
using ToyRobotSimulator.Model.Enumerations;
using ToyRobotSimulator.Model.Exceptions;
using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class SimulatorShouldNotSetup
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(5, 0)]
        [InlineData(0, 5)]
        public void DimensionLessThanOne(int width, int height)
        {
            //Arrange
            var simulator = new Model.Entity.ToyRobotSimulator();

            //Act
            var ex = Assert.Throws<ToyRobotException>(() => simulator.Setup(width, height));

            //Assert
            Assert.Equal("Dimension can only greater than zero atleast (1,1)!", ex.Message);
        }
    }
}
