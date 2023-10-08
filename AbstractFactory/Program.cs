
using RoomAbstractFactory.Factories;
using RoomAbstractFactory.Interfaces;

var factories = new Dictionary<string, IRoomFactory>()
{   
    { "Simple", new SimpleRoomFactory() },
    { "HiTech", new HiTechRoomFactory() },
    { "Mixed", new MixedRoomFactory() }
};

while (true)
{
    Console.WriteLine("\t -------------------------");
    Console.WriteLine("\n> IKEA welcomes you, which room furniture do you want to buy?");
    Console.WriteLine($"\n> Available rooms: {string.Join(", ", factories.Keys)}");
    Console.Write("> Choose your room design: ");

    string customerName = "Alberto";
    string? selectedRoomFactory = Console.ReadLine();
    
    Console.WriteLine($"You bought furniture for {selectedRoomFactory} room\n");

    var roomConcreteFactory = factories[selectedRoomFactory!];
    var lamp = roomConcreteFactory.BuyLamp();
    var bed = roomConcreteFactory.BuyBed();
    
    lamp.ToggleSwitch(customerName);
    bed.GoSleep(customerName);
    
    Console.WriteLine("\n IKEA thanks you. Come back :)\n");
}