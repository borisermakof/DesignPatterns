using RoomAbstractFactory.Furniture;
using RoomAbstractFactory.Interfaces;

namespace RoomAbstractFactory.Factories;

public class HiTechRoomFactory : IRoomFactory
{
    public IBed BuyBed()
    {
        return new HiTechBed();
    }

    public ILamp BuyLamp()
    {
        return new HiTechLamp();
    }
}