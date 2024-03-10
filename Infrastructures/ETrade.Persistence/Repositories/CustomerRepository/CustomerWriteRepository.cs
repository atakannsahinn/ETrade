using ETrade.Application.Repositories.CustomerRepository;
using ETrade.Domain.Entities;
using ETrade.Persistence.Contexts;

namespace ETrade.Persistence.Repositories.CustomerRepository;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ETradeDbContext context) : base(context)
    {
    }
}
