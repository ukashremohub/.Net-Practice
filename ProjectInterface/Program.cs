public class Program
{
    public static void Main(string[] args)
    {
        IHotel hotel = new Hotel();
       // IHotel hotel = new Resuart();
        hotel.Receptionist();

        var insertions = new Insertions();
        insertions.InsertionMethod();

    }


}
