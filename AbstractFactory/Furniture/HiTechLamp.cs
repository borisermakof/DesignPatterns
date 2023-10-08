using RoomAbstractFactory.Interfaces;

namespace RoomAbstractFactory.Furniture;

public class HiTechLamp : ILamp
{
    public void ToggleSwitch(string personName)
    {
        Console.WriteLine($"\t{personName} toggled the HiTech RGB Lamp");
    }
}