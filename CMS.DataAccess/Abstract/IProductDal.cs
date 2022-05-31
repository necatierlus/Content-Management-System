using System;
using System.Collections.Generic;
using System.Text;
using CMS.Core.DataAccess;
using CMS.Entity.ComplexTypes;
using CMS.Entity.Concrete;

namespace CMS.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductCategoryComplexData> GetProductWithCategory();
    }
}
