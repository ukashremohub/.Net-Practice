namespace ProjectInterface.Implementations;
public class Customers : ICustomers
{
    public CustomersModel RoomType() 
    {
        var _customersModel = new CustomersModel();
    Condition:
        int RoomType = Convert.ToInt16(Console.ReadLine());
        if (RoomType.Equals(1))
        {
            Console.WriteLine("\nCustomer : Hey I need a Normal Room \n", _customersModel.NormalRoom++, _customersModel.Flag++);
        }
        else if (RoomType.Equals(2))
            Console.WriteLine("\nCustomer : Hey I need a Special Room \n", _customersModel.SpecialRoom++);
        else
        {
            Console.WriteLine("\nReceptionist : Please provide proper answer \n");
            goto Condition;
        }
        return _customersModel;
    }

}