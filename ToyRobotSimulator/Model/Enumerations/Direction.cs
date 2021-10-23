using System.ComponentModel;

namespace ToyRobotSimulator.Model.Enumerations
{
    public enum Direction
    {
        [Description("NORTH")]
        NORTH = 0,
        
        [Description("SOUTH")]
        SOUTH = 1,
        
        [Description("EAST")]
        EAST = 2,
        
        [Description("WEST")]
        WEST = 3
    }
}
