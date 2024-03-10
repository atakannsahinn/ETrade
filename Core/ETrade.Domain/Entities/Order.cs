namespace ETrade.Domain.Entities;

public class Order : BaseEntity
{
    public string Address { get; set; }
    public string Description { get; set; }


    public ICollection<Product> Products { get; set; }
    public Customer Customer { get; set; }

}
