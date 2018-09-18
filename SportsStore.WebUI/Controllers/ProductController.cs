using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //字段
        private IProductRepository repository;

        //每页显示4的项目
        public int PageSize = 4;

        //构造方法(将字段当作参数)
        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        //显示View视图
        public ViewResult List(int page = 1)
        {
            return View(repository.Products.OrderBy(p => p.ProductId).Skip((page - 1) * PageSize).Take(PageSize));
        }

    }
}