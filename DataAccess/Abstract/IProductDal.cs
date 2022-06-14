using Entities.Concrete;
using Entities.DTOs;
using ProjectCore.DataAccess;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
