namespace RoomAbstractFactory.Interfaces;

public interface IRoomFactory
{
    IBed BuyBed();
    ILamp BuyLamp();
}