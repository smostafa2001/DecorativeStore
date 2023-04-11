﻿using ShopManagement.Application.Contracts.Shared;
using ShopManagement.Domain.ProductPictureAggregate;
using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.ProductPictureAggregate
{
    public interface IProductPictureApplication
    {
        OperationResult Create(CreateProductPicture command);

        OperationResult Edit(EditProductPicture command);

        OperationResult Remove(long id);

        OperationResult Restore(long id);

        EditProductPicture GetDetails(long id);

        List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel);
    }
}