namespace Entities
{
public class Product
{
    public int ProductNumber { get; set; }
    public string ProductName { get; set; }     
    public float CostPerUnit { get; set; }
    public Product(int ProductNumber, string ProductName, float CostPerUnit)
    {
        this.ProductNumber = ProductNumber;
        this.ProductName = ProductName;
        this.CostPerUnit = CostPerUnit;
    }
}
}