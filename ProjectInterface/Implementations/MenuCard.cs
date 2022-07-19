namespace ProjectInterface.Implementations;
public class MenuCard : IMenuCard
{
    public MenuCardModel MenuCardMethod()
    {
        var _menuCardModel = new MenuCardModel();
        // virutal override example 
        Console.WriteLine(_menuCardModel.Briyani + " with");
        Console.WriteLine(_menuCardModel.LemonJuice == "Salt" ? "Salt Lemon Juice" : "Sugar Lemon Juice ");

        return _menuCardModel;
    }

}

