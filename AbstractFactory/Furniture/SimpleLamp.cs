using RoomAbstractFactory.Interfaces;

namespace RoomAbstractFactory.Furniture;

public class SimpleLamp : ILamp
{
    public void ToggleSwitch(string personName)
    {
        Console.WriteLine($"\t{personName} toggled the Simple Lamp");
    }
}