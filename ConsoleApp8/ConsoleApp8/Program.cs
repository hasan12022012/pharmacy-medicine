using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy();
            string option;
            do
            {
                Console.WriteLine("\n1.Derman yarat");
                Console.WriteLine("2.Dermanlara bax");
                Console.WriteLine("3.Endirimli dermanlari goster");
                Console.WriteLine("4.Verilmis endirim araliqinda olan dermanlari goster");
                Console.WriteLine("5.Verilmis kateqoriya ucun dermanlari goster");
                Console.WriteLine("6.Verilmis kateqoriyada stokda nece eded derman qalib");

                Console.WriteLine("\nSeciminizi edin");
                option = Console.ReadLine();


                switch (option)
                {
                    case "1":
                        Console.WriteLine("Dermanin adini daxil edin:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Category:");
                        string category = Console.ReadLine();

                        Console.WriteLine("Price:");
                        string priceStr = Console.ReadLine();
                        double price = Convert.ToDouble(priceStr);

                        Console.WriteLine("Discount price");
                        string discountStr = Console.ReadLine();
                        double discount = Convert.ToDouble(discountStr);

                        Medicine medicine = new Medicine
                        {
                            Name = name,
                            Category = category,
                            Price = price,
                            DiscountPrice = discount
                        };

                        pharmacy.AddMedicine(medicine);
                        break;

                    case "2":
                        for(int i = 0; i < pharmacy.medicinies.Length; i++)
                        {
                            Console.WriteLine($"\nName: {pharmacy.medicinies[i].Name}");
                            Console.WriteLine($"Price: {pharmacy.medicinies[i].Price}");
                            Console.WriteLine($"DiscountPrice: {pharmacy.medicinies[i].DiscountPrice}");
                            Console.WriteLine($"Category: {pharmacy.medicinies[i].Category}");
                        }
                        break;

                    case "3":
                        for (int i = 0; i < pharmacy.medicinies.Length; i++)
                        {
                            if (pharmacy.medicinies[i].DiscountPrice > 0)
                            {
                                Console.WriteLine($"\nName: {pharmacy.medicinies[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.medicinies[i].Price}");
                                Console.WriteLine($"DiscountPrice: {pharmacy.medicinies[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.medicinies[i].Category}");
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("Araligin min qiymetin qedy edin:");
                        string minStr = Console.ReadLine();
                        var min = Convert.ToInt32(minStr);

                        Console.WriteLine("Araligin max qiymetin qedy edin:");
                        string maxStr = Console.ReadLine();
                        var max = Convert.ToInt32(maxStr);

                        for (int i = 0; i < pharmacy.medicinies.Length; i++)
                        {
                            if (pharmacy.medicinies[i].DiscountPrice >= min && pharmacy.medicinies[i].DiscountPrice <= max)
                            {
                                Console.WriteLine($"\nName: {pharmacy.medicinies[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.medicinies[i].Price}");
                                Console.WriteLine($"DiscountPrice: {pharmacy.medicinies[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.medicinies[i].Category}");
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine("Kateqoriyani daxil edin:");
                        string searchMedicine = Console.ReadLine();

                        for (int i = 0; i < pharmacy.medicinies.Length; i++)
                        {
                            if (pharmacy.medicinies[i].Category.Contains(searchMedicine))
                            {
                                Console.WriteLine($"\nName: {pharmacy.medicinies[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.medicinies[i].Price}");
                                Console.WriteLine($"DiscountPrice: {pharmacy.medicinies[i].DiscountPrice}");
                            }
                        }
                        break;

                    case "6":
                        Console.WriteLine("Kateqoriyani daxil edin:");
                        string searchMedicine2 = Console.ReadLine();
                        var count = 0;

                        for (int i = 0; i < pharmacy.medicinies.Length; i++)
                        {
                            if (pharmacy.medicinies[i].Category== searchMedicine2)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Bu kateqoriyada {count} eded derman qalib");
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Secim dyzgun deyil");
                        break;

                }
            } while (option != "0");
        }
    }
}
