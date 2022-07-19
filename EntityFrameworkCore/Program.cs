using EntityFrameworkCore.Model;

Console.WriteLine("Hello");
var insertion = new Insertion();
insertion.InsertionMethod();
//var ternaryOperator = new TernaryOperator();
//ternaryOperator.TernaryOperatorMethod();



public class Insertion 
{
    public void InsertionMethod()
    {
        using (var db = new EFContext())
        {
            var product = new Product();
            //product.Id = 1;
            product.Name = "Ukash";
            db.Add(product);
            
            db.SaveChanges();

        }
    }
}


//public class TernaryOperator
//{
//    public void TernaryOperatorMethod()
//    {
//        string Name = "";
//        var a = Name != null ? Name : null;
//        Console.WriteLine(a);

//    }
//}