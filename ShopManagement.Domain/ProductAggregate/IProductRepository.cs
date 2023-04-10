﻿using ShopManagement.Domain.Shared;
using System.Collections.Generic;

namespace ShopManagement.Domain.ProductAggregate
{
    public interface IProductRepository : IRepository<long, Product>
    {
        Product GetProductWithCategory(long id);
        EditProduct GetDetails(long id);
        List<ProductViewModel> GetProducts();
        List<ProductViewModel> Search(ProductSearchModel searchModel);
    }
}