using System;
namespace LuckySpin.Models;

public class Spin
{
    // Properties (notice their data types)
    public int Luck { get; set; } = 7; //Default to 7
    public required int[] Numbers { get; set; } //Made required to ensure it's always set or an error is thrown
    public string ImageDisplay { get; set; } = "none"; //Default to "none" so the image is hidden unless set to "block"
}