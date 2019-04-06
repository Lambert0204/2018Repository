using MyShop.Domain;
using MyShop.Persistor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace MyStore.ConsoleApplication
{
    public class Program
    {
        [Dependency]
        public static Context Context { get; set; }

        [Dependency]
        public static IRepository<Product> RepoProduct { get; set; }

        public static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<Context, Context>();
            container.RegisterType<IRepository<Product>, Repository<Product>>();
            container.RegisterType<IRepository<Sale>, Repository<Sale>>();

            Context = container.Resolve<Context>();
            RepoProduct = container.Resolve<Repository<Product>>();

            Start();
        }

        public static void Start()
        {

            // Create and save a new Product
            Console.Write("Enter a name for a new Product: ");

            var name = Console.ReadLine();
            var product = new Product { ProductName = name, NonProfitPrice = 4 };

            RepoProduct.Insert(product);
            Context.SaveChanges();

            //Display all from the database

            Console.WriteLine("All Products in the database:");
            foreach (var item in RepoProduct.GetAll())
                Console.WriteLine(item.ProductName);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }


    }
        
}
