using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    class UserOperations
    {
        static int user_choice;
        public static void checkCredentials()
        {
            Console.Clear();
            string pattern = "^[A-Z][a-zA-Z]*$";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            if (!regex.IsMatch(username))
            {
                var ctx = new MyDebContext();




                var find = ctx.USERS.First(x => x.User_Name == username);
                Console.WriteLine(find);
                //if (ctx.SaveChanges() > 0)
                //{
                //    Console.WriteLine("Table Updated");
                //}

            }
            Console.WriteLine("Password: ");
        }
        public static void UserMenu()
        {
            var ctx = new MyDebContext();
            //Console.WriteLine("inside usermenu");
            while (user_choice == 0)
            {
                Console.WriteLine("----------------------------------------\nWhat operation do you wish to perform?\n1. Add Product\n2. Add Subproduct\n3. Get All Product Data\n0. Logout\n----------------------------------------");
                user_choice = Convert.ToInt32(Console.ReadLine());
                switch (user_choice)
                {
                    case 1:
                        {
                            Console.WriteLine("----------------------------------------\nEnter following details:");
                            Console.Write("Product Name: ");
                            string productName = Console.ReadLine();
                            Console.Write("Product Description: ");
                            string description = Console.ReadLine();
                            ProductCategories data = new ProductCategories() { Product_Name = productName, Description = description };
                            ctx.PRODUCT_CATEGORIES.Add(data);
                            if (ctx.SaveChanges() > 0)
                            {
                                Console.WriteLine("Result-> New product Added");
                            }
                            else
                            {
                                Console.WriteLine("Result-> Product not added. Please confront admin");
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("----------------------------------------\nEnter following details:");
                            Console.Write("Category Name: ");
                            var find = ctx.PRODUCT_CATEGORIES.First(x => x.Product_Category_ID == Convert.ToInt32(Console.ReadLine()));
                            int categoryId = find.Product_Category_ID;
                            Console.WriteLine(categoryId);
                            Console.Write("Subproduct Name: ");
                            string subProductName = Console.ReadLine();
                            Console.Write("Product Description: ");
                            string description = Console.ReadLine();
                            Console.Write("Current Storage: ");
                            int currentStorage = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Sold: ");
                            int sold = Convert.ToInt32(Console.ReadLine());
                            int remainingQuantity = currentStorage - sold;
                            Console.Write("Unit Price: ");
                            int unitPrice = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Total Selling Amount: ");
                            int totalSellingAmount = unitPrice * sold;



                            Products data = new Products() { Product_Category_ID = categoryId, SubProduct_Name = subProductName, Description = description, Current_Storage = currentStorage, Sold = sold, Remaining_Quantity = remainingQuantity, Unit_Price = unitPrice, Total_Selling_Amount = totalSellingAmount };
                            ctx.PRODUCTS.Add(data);
                            if (ctx.SaveChanges() > 0)
                            {
                                Console.WriteLine("Result-> New product subcategory Added");
                            }
                            else
                            {
                                Console.WriteLine("Result-> Product subcategory not added. Please confront admin");
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.Clear();
                            return;

                        }
                    case 3:
                        {
                            //Console.WriteLine("----------------------------------------\nProduct Data:");
                            //IEnumerable<ProductCategories> Query = .Where(s => s.name[0] == 'S');
                            //var find = ctx.PRODUCT_CATEGORIES.First(x => x.Product_Category_ID == Convert.ToInt32(Console.ReadLine()));

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter correct choice");
                            break;
                        }
                }
            }

        }
    }
}
