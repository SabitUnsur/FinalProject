using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleUİ
{
    //SOLID
    //Open Closed Principle 

    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation Object
            //IoC
           // ProductTest();

            // CategoryTest();
        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var category in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());

        //    var result = productManager.GetProductDetails();

        //    if (result.Success)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine(product.ProductName);
        //        }
        //    }

        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

           
        //}
    }
}
