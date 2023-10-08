using RoomAbstractFactory.Furniture;
using RoomAbstractFactory.Interfaces;

namespace RoomAbstractFactory.Factories;

public class SimpleRoomFactory : IRoomFactory
{
    public IBed BuyBed()
    {
        return new SimpleBed();
    }

    public ILamp BuyLamp()
    {
        return new SimpleLamp();
    }
}