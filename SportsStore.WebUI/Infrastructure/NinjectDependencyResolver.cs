using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        //声明接口当作字段
        private IKernel kernel;

        //构造方法(将接口当作参数)
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        #region 两个GetService和GetServices的方法

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        #endregion

        //添加绑定
        private void AddBindings()
        {
            #region 1.写死的Moq测试

            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>()
            //{
            //    new Product {Name = "soccer", Price = 30},
            //    new Product {Name = "football", Price = 36},
            //    new Product {Name = "basketball", Price = 45}
            //});

            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);

            #endregion

            #region 2.绑定从数据库中得出数据

            kernel.Bind<IProductRepository>().To<EFProductRepository>();

            #endregion

        }
    }
}