namespace ProjectInterface.Implementations;
public class Hotel : IHotel
{
    private SpecialRooms _rooms;
    private ICustomers _customers;
    private CustomersModel _customersModel;
    private IMenuCard _menuCard;

    public Hotel()
    {
        _menuCard = new MenuCard();
        _customers = new Customers();
        _customersModel = new CustomersModel();
        _rooms = new SpecialRooms();
       
    }
    public void Receptionist()
    {
        var receptionist = new Receptionist();
        receptionist.ReceptionistNegotiation("Nalla Hotel", _customersModel, _rooms);

    }

    // Shorthand version for method implementating using Lambda expression
    public CustomersModel CustomersRoomSelection() => _customers.RoomType();

    //var customers = _customers.MethodCustomers();
    //return (Customers)Convert.ChangeType(customers, typeof(Customers)); // implicit type casting
    // return _customersModel = _customers.RoomType(); // explicit type cast

    public MenuCardModel Dishes() => _menuCard.MenuCardMethod();

    public Rooms Rooms()
    {
        Console.WriteLine("Normal Rooms available : ");
        _rooms.AvailableRooms();
        Console.WriteLine("Special Rooms available : ");
        _rooms.AvailableSpecialRooms();

        return _rooms;
    }

}

