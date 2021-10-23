using Xunit;

namespace ToyRobotSimulator.UnitTest
{
    public class SimulatorShouldExecute
    {
        [Theory]
        [InlineData("PLACE 1,1,NORTH")]
        [InlineData("pLACE 1,1,south")]
        public void ValidPlaceCommand(string command)
        {
            //Arrange
            var simulator = new Model.Entity.ToyRobotSimulator();
            simulator.Setup(6, 6);

            //Act
            var status = simulator.Command(command);

            //Assert
            Assert.Equal(string.Empty, status);
        }

        [Theory]
        [InlineData("Move")]
        [InlineData("left")]
        [InlineData("RIGHT")]
        [InlineData("report")]
        public void ValidCommand(string command)
        {
            //Arrange
            var simulator = new Model.Entity.ToyRobotSimulator();
            simulator.Setup(6, 6);

            //Act
            simulator.Command("Place 1,1,North");
            var status = simulator.Command(command);

            //Assert
            Assert.Equal(string.Empty, status);
        }

        [Fact]
        public void SampleTest()
        {
            //Arrange
            var simulator = new Model.Entity.ToyRobotSimulator();
            simulator.Setup(6, 6);

            //Act
            simulator.Command("Place 1,1,North");
            simulator.Command("left");
            simulator.Command("move");
            simulator.Command("right");
            simulator.Command("move");
            simulator.Command("right");
            simulator.Command("move");
            simulator.Command("move");
            simulator.Command("right");
            simulator.Command("move");
            simulator.Command("move");
            simulator.Command("left");
            simulator.Command("move");
            simulator.Command("left");
            simulator.Command("move");
            simulator.Command("move");
            simulator.Command("move");
            simulator.Command("move");
            simulator.Command("right");
            var output = simulator.Command("report");

            //Assert
            Assert.Equal("Output: 3,4,EAST", output);
        }
    }
}
