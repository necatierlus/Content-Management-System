using System;
using System.Collections.Generic;
using System.Text;
using CMS.Core.DataAccess.EntityFrameworkCore;
using CMS.DataAccess.Abstract;
using CMS.Entity.Concrete;

namespace CMS.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfProductImageDal : EfEntityRepositoryBase<ProductImage,TestProjectDbContext>,IProductImageDal
    {
    }
}
