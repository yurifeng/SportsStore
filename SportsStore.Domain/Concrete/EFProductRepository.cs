using System.Collections.Generic;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    
    //创建Product的存储库
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext _dbcontext = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return _dbcontext.Products; }
        }
    }
}