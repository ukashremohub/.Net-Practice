namespace DelegatesApproaches;

//public delegate int Dele_ChocoPrice(int NoOfChoco);
//public delegate void Dele_ChocoName(string chocoName);
//public delegate bool Dele_Flavour(string flavour);

public class Chocolates
{
    public static int ChocoPrice(int NoOfChoco)
    {
        return 10 * NoOfChoco;
    }

    public static void ChocoName(string chocoName)
    {
        Console.WriteLine(chocoName);
    }

    public static bool Flavour(string flavour)
    {
        if (flavour.Length == 5) //Choco 
            return true;
        return false;
    }

    public static void Main()
    {
        //Dele_ChocoPrice dele_ChocoPrice = ChocoPrice;
        Func<int,int> dele_ChocoPrice = ChocoPrice;
        Console.WriteLine(dele_ChocoPrice.Invoke(2));

        // Dele_ChocoName dele_ChocoName = ChocoName;
        Action<string> dele_ChocoName = ChocoName;
        dele_ChocoName.Invoke("DairyMilk");

        //Dele_Flavour dele_Flavour = Flavour;
        Predicate<string> dele_Flavour = Flavour;
        Console.WriteLine(dele_Flavour.Invoke("choco"));


        //Lambda Expression
        Func<int, int> dele_ChocoPrice1 = (NoOfChoco) => 10 * NoOfChoco;
        Console.WriteLine(dele_ChocoPrice.Invoke(2));

        Action<string> dele_ChocoName1 = (chocoName) => Console.WriteLine(chocoName);
        dele_ChocoName.Invoke("DairyMilk");

        Predicate<string> dele_Flavour1 = (flavour) =>
        {
            if (flavour.Length == 5) //Choco 
                return true;
            return false;
        };
        Console.WriteLine(dele_Flavour.Invoke("choco"));

    }
}
