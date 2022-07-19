namespace ProjectInterface.Implementations;
public class Receptionist : IReceptionist
{
    public void ReceptionistNegotiation(string HotelName, CustomersModel _customersModel, SpecialRooms _rooms)
    {
        var hotel = new Hotel();
        Console.WriteLine($"Receptionist : Hi Guest, Welcome to the {HotelName} ");
        hotel.Rooms();
        Console.WriteLine("\nReceptionist : Which type of room do you want? 1 for Normal , 2 for Special");
        _customersModel = hotel.CustomersRoomSelection();
        Console.WriteLine(_customersModel.Flag != 1 ? "Receptionist : Enjoy you Special Room with unlimited drinks\n" : "Receptionist : Enjoy your Normal Room\n");
        Thread.Sleep(1000);
        if (_customersModel.Flag == 1)
            _rooms.AvailableRooms(_customersModel.NormalRoom);
        else
            _rooms.AvailableSpecialRooms(_customersModel.SpecialRoom);

        Console.WriteLine("\nReceptionist : Thank you for choosing and Please have this food as a welcome\n");
        Thread.Sleep(1000);

        hotel.Dishes();
    }
}
