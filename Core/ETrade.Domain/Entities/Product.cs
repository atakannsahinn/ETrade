namespace ETrade.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public int UnitsInStock { get; set; }
    public decimal Price { get; set; }


    public ICollection<Order> Orders { get; set; }
}
