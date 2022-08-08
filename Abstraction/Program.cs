
//Child child = new();
//child.Cola();

//public abstract class Drinks  
//{
//    public abstract void Cola();


//}


//public class Child : Drinks
//{
//    public override void Cola() //Reimplementing 
//    {
//        Console.WriteLine("Override");
//    }
//}




public abstract class AbsParent
{
    public void Addition(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    public void Subtraction(int x , int y)
    {
        Console.WriteLine(x - y);
    }
    public abstract void Multiplication(int x, int y);
    public abstract void Division(int x, int y);
}

public class AbsChild : AbsParent
{
    public override void Division(int x, int y)
    {
       Console.WriteLine(x / y);
    }

    public override void Multiplication(int x, int y)
    {
        Console.WriteLine(x * y);
    }

    static void Main()
    {
        AbsChild absChild = new();
        absChild.Addition(10, 20);
        absChild.Division(10, 20);
        AbsParent absParent = absChild;
        absParent.Subtraction(10, 20);
        absParent.Multiplication(10, 20);
    }
}

