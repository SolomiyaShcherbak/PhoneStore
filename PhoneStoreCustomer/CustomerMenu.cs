using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore;

namespace PhoneStoreCustomer
{
    class CustomerMenu
    {
		IRepository<Phone> phoneRepository;

		public CustomerMenu()
		{
			var factory = FactoryCreator.GetFactory();
			phoneRepository = factory.GetPhoneRepository();
		}


		public void ShowMenu()
		{
			string userInput = "";
			do
			{
				ShowMainMenu();
				userInput = Console.ReadLine();
				handleCustomerInput(userInput);
			}
			while (userInput != "0");
		}

		void ShowMainMenu()
		{
			string menu = @"
You are a customer in the phone shop.
Select an option:
1: Sort by brand 
2: Sort by model
3: Sort by price
p: Print phones
0: Exit customer menu";

			Console.WriteLine(menu);
		}

		void handleCustomerInput(string customerInput)
		{
			switch (customerInput)
			{
				case "1":
					executeSortByBrandMenu();
					break;
				case "2":
					executeSortByModelMenu();
					break;
				case "3":
					executeSortByPriceMenu();
					break;
				case "p":
					executePrintPhonesMenu();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("Wrong command\n");
					break;
			}
		}

		void executeSortByBrandMenu()
		{
			phoneRepository.Sort(new BrandComparer<Phone>());
			executePrintPhonesMenu();
		}

		void executeSortByModelMenu()
        {
			phoneRepository.Sort(new ModelComparer<Phone>());
			executePrintPhonesMenu();
		}

		void executeSortByPriceMenu()
		{
			phoneRepository.Sort(new PriceComparer<Phone>());
			executePrintPhonesMenu();
		}

		void executePrintPhonesMenu()
		{
			Console.WriteLine("Phones:");
			phoneRepository.Print();
		}
	}
}
