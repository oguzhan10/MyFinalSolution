using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.inMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

      


            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Sucess)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + item.CategoryName);
                }
            }
            else{
                Console.WriteLine(result.Message);
            }

            




            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryId);
            //}



        }
    }
}