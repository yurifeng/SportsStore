using System.Data.Entity;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    //该类创建了EF的上下文(与web.config中的连接字符串一起使用连接数据库)
    public class EFDbContext : DbContext
    {
        //表明就是Product
        //表中的数据都是Product类型的记录
        public DbSet<Product> Products { get; set; }
    }
}