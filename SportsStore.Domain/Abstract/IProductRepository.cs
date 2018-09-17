using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    //该接口的作用是获得Product的集合
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

    }
}