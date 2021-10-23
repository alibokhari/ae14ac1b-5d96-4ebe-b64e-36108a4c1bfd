﻿namespace ToyRobotSimulator.Model.ValueObject
{
    public class Dimension
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Dimension(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
