﻿using ETrade.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Application.Repositories.OrderRepository;
public interface IOrderReadRepository : IReadRepository<Order>
{
}
