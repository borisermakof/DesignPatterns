using RoomAbstractFactory.Interfaces;

namespace RoomAbstractFactory.Furniture;

public class HiTechBed : IBed
{
    public void GoSleep(string personName)
    {
        Console.WriteLine($"\t{personName} went to sleep on HiTech Bed");
    }
}