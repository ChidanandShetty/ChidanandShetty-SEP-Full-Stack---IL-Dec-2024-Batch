﻿class Color
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
    public int Alpha { get; set; } = 255; // Default to opaque

    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public int GetGrayscale()
    {
        return (Red + Green + Blue) / 3;
    }
}
