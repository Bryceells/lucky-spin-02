using System;
namespace LuckySpin.Models;

public class Spin
{
    // Properties (notice their data types)
    public int Luck { get; set; } = 7; //Default to lucky number 7
    public required int[] Numbers { get; set; } //The question mark means that these properties are nullable
    public string ImageDisplay { get; set; } = "none"; //Default to "none" to hide the image
}
