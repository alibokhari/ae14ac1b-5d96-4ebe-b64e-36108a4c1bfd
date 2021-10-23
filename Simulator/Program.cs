using System;
using System.Text;
using ToyRobotSimulator.Model.Exceptions;

namespace Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var readMe = new StringBuilder();
            readMe.AppendLine("**********Welcome to Toy Robot Simulation**********");
            readMe.AppendLine("You have a square table top of dimension 6x6 from (0,0) to (5,5) to move your toy robot");
            readMe.AppendLine("Use the following commands to operate your toy robot");
            readMe.AppendLine("Place  - To place it on the table i.e place 2,3,north");
            readMe.AppendLine("Move   - To move it one unit forward in the direction it is currently facing");
            readMe.AppendLine("Left   - To rotate anti clock wise from current direction");
            readMe.AppendLine("Right  - To rotate clock wise from current direction");
            readMe.AppendLine("Report - To check the current position and direction");
            Console.WriteLine(readMe.ToString());

            try
            {
                var simulator = new ToyRobotSimulator.Model.Entity.ToyRobotSimulator();
                simulator.Setup(6, 6);
                while (true)
                {
                    try
                    {
                        Console.Write(">");
                        var command = Console.ReadLine();
                        var output = simulator.Command(command);
                        if (!string.IsNullOrEmpty(output))
                            Console.WriteLine(output);
                    }
                    catch (ToyRobotException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: { ex.Message }");
            }
            Console.Read();


            Console.ReadLine();
        }
    }
}
