using System;

namespace Polymorphism_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(2, 10);

            string input;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("\n1.Drink product elave et");
                Console.WriteLine("2.Dairy product elave et");
                Console.WriteLine("3.Butun productlara bax");
                Console.WriteLine("4.Verilmis nomreli producta bax");
                Console.WriteLine("5.Drink productlara bax");
                Console.WriteLine("6.Dairy productlara bax");
                Console.WriteLine("7.Ada göre axtarış et");
                Console.WriteLine("8 Qiymet aralığına göre axtarış et");
                Console.WriteLine("9.Siyahıdan mehsul sil");
                Console.WriteLine("0.Menudan cix");
                Console.WriteLine("\nSeciminizi edin:");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nName:");
                        string name1 = Console.ReadLine();

                        Console.WriteLine("Price:");
                        double price1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("AlcoholPercent:");
                        double alcoholPercent = Convert.ToDouble(Console.ReadLine());

                        Drink drink = new Drink(alcoholPercent)
                        {
                            Name = name1,
                            Price = price1
                        };
                        Product product1 = drink;
                        
                        try
                        {
                            if (!store.HasProductByNo(product1.No))
                            {
                                store.AddProduct(product1);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Xeta bas verdi: " + ex.Message);
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nName:");
                        string name2 = Console.ReadLine();

                        Console.WriteLine("Price:");
                        double price2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("FatPercent:");
                        double fatPercent = Convert.ToDouble(Console.ReadLine());

                        Dairy dairy = new Dairy(fatPercent)
                        {
                            Name = name2,
                            Price = price2
                        };
                        Product product2 = dairy;
                        
                        try
                        {
                            if (!store.HasProductByNo(product2.No))
                            {
                                store.AddProduct(product2);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Xeta bas verdi: " + ex.Message);
                        }
                        break;
                    case "3":
                        foreach (var item in store.Products)
                        {
                            item.ShowProducts();
                        }
                        break;
                    case "4":
                        try
                        {
                            Console.WriteLine("\nNo daxil edin...");
                            int no = Convert.ToInt32(Console.ReadLine());
                            Product pr = store.GetProductByNo(no);
                            pr.ShowProducts();
                        }
                        catch (ProductNotFoundException ex)
                        {
                            Console.WriteLine("Xeta bas verdi:" + ex.Message);
                        }
                        break;
                    case "5":
                        Drink[] drinks = store.GetDrinkProducts(store.Products);
                        foreach (var item in drinks)
                        {
                            item.ShowProducts();
                        }
                        break;
                    case "6":
                        Dairy[] dairies = store.GetDairyProducts(store.Products);
                        foreach (var item in dairies)
                        {
                            item.ShowProducts();
                        }
                        break;
                    case "7":
                        Console.WriteLine("\nAxtaris deyeri daxil edin:");
                        string wantedInformation = Console.ReadLine();
                        foreach (var item in store.Products)
                        {
                            if (item.Name.Contains(wantedInformation))
                            {
                                item.ShowProducts();
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("\nMin price deyeri daxil edin:");
                        double minPrice = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Max price deyeri daxil edin:");
                        double maxPrice = Convert.ToDouble(Console.ReadLine());

                        foreach (var item in store.Products)
                        {
                            if (item.Price >= minPrice && item.Price <= maxPrice)
                            {
                                item.ShowProducts();
                            }
                        }
                        break;
                    case "9":
                        Console.WriteLine("\nNo daxil edin:");
                        int removeNo = Convert.ToInt32(Console.ReadLine());
                        store.RemoveProduct(removeNo);
                        break;
                    case "0":
                        input = "-1";
                        Console.WriteLine("\nEminsiniz mi? Yes/No");
                        if (Console.ReadLine() == "Yes")
                        {
                            input = "0";
                        }
                        break;
                    default:
                        Console.WriteLine("\nYanlis secim etdiniz, yeniden secim edin.");
                        break;
                }

            } while (input != "0");



        }
    }
}
