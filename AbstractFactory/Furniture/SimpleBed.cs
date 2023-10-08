using RoomAbstractFactory.Interfaces;

namespace RoomAbstractFactory.Furniture;

public class SimpleBed : IBed
{
    public void GoSleep(string personName)
    {
        Console.WriteLine($"\t{personName} went to sleep on Simple Bed");
    }
}