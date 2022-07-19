namespace ProjectInterface.Implementations;
public class Rooms : IRooms
{
    public RoomsModel _roomsModel;
    public IDictionary<int, string> _availableRooms;

    public Rooms()
    {
        _roomsModel = new RoomsModel();
        _availableRooms = new Dictionary<int, string>();
    }

    public void AvailableRooms() // Method overload
    {
        _availableRooms.Add(_roomsModel.Number1, _roomsModel.RoomType);
        _availableRooms.Add(_roomsModel.Number2, _roomsModel.RoomType);
        _availableRooms.Add(_roomsModel.Number3, _roomsModel.RoomType);

        foreach (KeyValuePair<int, string> item in _availableRooms)
            Console.WriteLine($"{item.Key} : {item.Value}");

    }

    public void AvailableRooms(int NormalRoom) // Method overload
    {
        var _ = NormalRoom switch
        {
            1 => _availableRooms.Remove(_roomsModel.Number1),
            2 => _availableRooms.Remove(_roomsModel.Number2),
            3 => _availableRooms.Remove(_roomsModel.Number3),
            _ => throw new NotImplementedException()
        };
        Console.WriteLine("Receptionist : Available of Normal Room after choosing :");
        foreach (KeyValuePair<int, string> item in _availableRooms)
            Console.WriteLine($"{item.Key} : {item.Value}");

    }
}

public class SpecialRooms : Rooms
{
    public IDictionary<int, string> _availableSpecialRooms;
    public SpecialRooms()
    {
        _availableSpecialRooms = new Dictionary<int, string>();

    }
    public void AvailableSpecialRooms() // Method overload
    {
        _availableSpecialRooms.Add(_roomsModel.Number1, _roomsModel.RoomType + ' ' + _roomsModel.Drinks);
        _availableSpecialRooms.Add(_roomsModel.Number2, _roomsModel.RoomType + ' ' + _roomsModel.Drinks);
        _availableSpecialRooms.Add(_roomsModel.Number3, _roomsModel.RoomType + ' ' + _roomsModel.Drinks);
        _availableSpecialRooms.Add(_roomsModel.Number4, _roomsModel.RoomType + ' ' + _roomsModel.Drinks);

        foreach (KeyValuePair<int, string> item in _availableSpecialRooms)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }

    public void AvailableSpecialRooms(int SpecialRoom) // Method overload
    {
        var _ = SpecialRoom switch
        {
            1 => _availableSpecialRooms.Remove(_roomsModel.Number1),
            2 => _availableSpecialRooms.Remove(_roomsModel.Number2),
            3 => _availableSpecialRooms.Remove(_roomsModel.Number3),
            _ => throw new NotImplementedException()
        };
        Console.WriteLine("Receptionist : Available Specail Room after choosing : ");
        foreach (KeyValuePair<int, string> item in _availableSpecialRooms)
            Console.WriteLine($"{item.Key} : {item.Value}");
    }
}


