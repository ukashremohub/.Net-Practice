namespace ProjectInterface.Models;
public class MenuCardModel
{
    public int Id { get; set; }
    // virutal example 
    public virtual string Briyani => "Chicken Briyani";
    public string Starter => "Grilled Chicken";
    public virtual string LemonJuice => "Sugar";

}
