﻿using Shoppers.Data;
using Shoppers.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppers.Storage.Repositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}
