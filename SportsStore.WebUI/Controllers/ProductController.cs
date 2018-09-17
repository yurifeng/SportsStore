using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //字段
        private IProductRepository repository;

        //构造方法
        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        //显示View视图
        public ViewResult List()
        {
            return View(repository.Products);
        }

    }
}