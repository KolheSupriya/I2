using Microsoft.EntityFrameworkCore;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static int choice;
        //static int logout=0;
        static void Main(string[] args)
        {
            while(choice==0)
            {


                Console.WriteLine("Please login. Choices are as follows\n1. Admin \n2. User\n0. Exit\n----------------------------------------");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            AdminOperations.AdminMenu();
                            break;
                        }

                    case 2:
                        {
                            UserOperations.UserMenu();
                                                       
                            //logout = 0;
                            continue;
                        }
                    case 3:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong choice entered. Please try again. ");
                            break;
                        }
                }
            }
        }
    }
    class MyDebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server =.; Database = AngularReact; Trusted_Connection = True; ");
            optionsBuilder.UseSqlServer(@"Server =SUPRIYAKOL-VD\SQL2017; Database=InventoryMgtSystem; User ID=sa; Password=cybage@123456;");
        }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<INVOICE> INVOICE_DATA { get; set; }
        public virtual DbSet<ProductCategories> PRODUCT_CATEGORIES { get; set; }
        //public virtual DbSet<STORAGE> STORAGES { get; set; }
        public virtual DbSet<Products> PRODUCTS { get; set; }
        public virtual DbSet<ROLE> ROLES { get; }
        public virtual DbSet<SHIPPING> SHIPPING { get; set; }

    }


}
