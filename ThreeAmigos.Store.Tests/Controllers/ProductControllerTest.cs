using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreeAmigos.Store.Controllers;
using ThreeAmigos.Store.Models;
using ThreeAmigos.Store.DAL;

namespace ThreeAmigos.Store.Tests.Controllers
{
    [TestClass]
    class ProductControllerTest
    {
        //[TestMethod]
        //public void GetAllProducts_ShouldReturnAllProducts()
        //{
        //    var testProducts = GetTestProducts();
        //    var controller = new ProductController(new StoreContext);

        //    var result = controller.GetAllProducts() as List<ProductViewModel>;
        //    Assert.AreEqual(testProducts.Count, result.Count);
        //}

        private List<ProductViewModel> GetTestProducts()
        {
            var testProducts = new List<ProductViewModel>();
            testProducts.Add(new ProductViewModel { Name = "Demo1", Price = 1.99M });
            testProducts.Add(new ProductViewModel { Name = "Demo2", Price = 2.59M });
            testProducts.Add(new ProductViewModel { Name = "Demo3", Price = 5.00M });
            testProducts.Add(new ProductViewModel { Name = "Demo4", Price = 7.00M });
            testProducts.Add(new ProductViewModel { Name = "Demo5", Price = 6.99M });
            testProducts.Add(new ProductViewModel { Name = "Demo6", Price = 9.00M });
            testProducts.Add(new ProductViewModel { Name = "Demo7", Price = 10.99M });
            testProducts.Add(new ProductViewModel { Name = "Demo8", Price = 3.00M });
            testProducts.Add(new ProductViewModel { Name = "Demo9", Price = 3.99M });

            return testProducts;
        }

        //Test Create Method
        //[TestMethod]
        //public void PutProduct_ShouldReturnStatusCode()
        //{
        //    var controller = new ProductController(new TestStoreAppContext());

        //    var item = GetDemoProduct();

        //    var result = controller.PutProduct(item.Id, item) as StatusCodeResult;
        //    Assert.IsNotNull(result);
        //    Assert.IsInstanceOfType(result, typeof(StatusCodeResult));
        //    Assert.AreEqual(HttpStatusCode.NoContent, result.StatusCode);
        //}

        [TestMethod]
        public void PutProduct_ShouldFail_WhenDifferentID()
        {
            var controller = new ProductController(new TestStoreAppContext());

            var badresult = controller.PutProduct(999, GetDemoProduct());
            Assert.IsInstanceOfType(badresult, typeof(BadRequestResult));
        }

        [TestMethod]
        public void GetProduct_ShouldReturnProductWithSameID()
        {
            var context = new TestStoreAppContext();
            context.Products.Add(GetDemoProduct());

            var controller = new ProductController(context);
            var result = controller.GetProduct(3) as OkNegotiatedContentResult<Product>;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Content.Id);
        }

        [TestMethod]
        public void GetProducts_ShouldReturnAllProducts()
        {
            var context = new TestStoreAppContext();
            context.Products.Add(new Product { Id = 1, Name = "Demo1", Price = 20 });
            context.Products.Add(new Product { Id = 2, Name = "Demo2", Price = 30 });
            context.Products.Add(new Product { Id = 3, Name = "Demo3", Price = 40 });

            var controller = new ProductController(context);
            var result = controller.GetProducts() as TestProductDbSet;

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Local.Count);
        }

        [TestMethod]
        public void DeleteProduct_ShouldReturnOK()
        {
            var context = new TestStoreAppContext();
            var item = GetDemoProduct();
            context.Products.Add(item);

            var controller = new ProductController(context);
            var result = controller.DeleteProduct(3) as OkNegotiatedContentResult<Product>;

            Assert.IsNotNull(result);
            Assert.AreEqual(item.Id, result.Content.Id);
        }

        Product GetDemoProduct()
        {
            return new Product() { Id = 3, Name = "Demo name", Price = 5 };
        }
    }
}
    }
}
