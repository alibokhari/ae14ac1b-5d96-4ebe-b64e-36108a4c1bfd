using ToyRobotSimulator.Model.Entity;
using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class SimulatorShouldSetup
    {
        [Theory]
        [InlineData(1, 5)]
        [InlineData(1, 1)]
        [InlineData(9, 5)]
        [InlineData(6, 6)]
        public void OnlyDimensionGreaterThanZero(int width, int height)
        {
            //Arrange
            var simulator = new Model.Entity.ToyRobotSimulator();

            //Act
            var status = simulator.Setup(width, height);

            //Assert
            Assert.True(status);
        }
    }
}
