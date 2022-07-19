namespace ProjectInterface.HotelData;
public class Insertions
{
    public void InsertionMethod()
    {
        using (var db = new EFContext())
        {
            var menuCardModel = new MenuCardModel();
            db.Add(menuCardModel);

            var roomsModel = new RoomsModel();
            db.Add(roomsModel);

            db.SaveChanges();

        }
    }
}
