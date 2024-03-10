﻿using ETrade.Application.Repositories.CustomerRepository;
using ETrade.Application.Repositories.OrderRepository;
using ETrade.Domain.Entities;
using ETrade.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Persistence.Repositories.OrderRepository;
public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(ETradeDbContext context) : base(context)
    {
    }
}
