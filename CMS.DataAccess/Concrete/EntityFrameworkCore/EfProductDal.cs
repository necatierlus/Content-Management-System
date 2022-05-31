using System;
using System.Collections.Generic;
using System.Text;
using CMS.Core.DataAccess.EntityFrameworkCore;
using CMS.DataAccess.Abstract;
using CMS.Entity.ComplexTypes;
using CMS.Entity.Concrete;
using System.Linq;

namespace CMS.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfProductDal : EfEntityRepositoryBase<Product, TestProjectDbContext>, IProductDal
    {
        public List<ProductCategoryComplexData> GetProductWithCategory()
        {
            using (var _context = new TestProjectDbContext())
            {
                var result = from p in _context.Products
                             join c in _context.Categories on p.CategoryId equals c.Id
                             select new ProductCategoryComplexData
                             {
                                 CategoryName = c.Name,
                                 Height = p.Height,
                                 ProductId = p.Id,
                                 ProductName = p.Name,
                                 Weight = p.Weight,
                                 Width = p.Width
                             };
                return result.ToList();
            }
        }
    }
}
