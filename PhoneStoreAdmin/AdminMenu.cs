using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore;

namespace PhoneStoreAdmin
{
    class AdminMenu
    {
        IRepository<Phone> phoneRepository;

        public AdminMenu()
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
                safeHandleAdminInput(userInput);
            }
            while (userInput != "0");
        }

        void ShowMainMenu()
        {
            string menu = @"
You are the admin of a phone shop.
Select an option:
1: Add phone
2: Add several phones
3: Remove phone 
4: Remove last phones
5: Remove by brand
6: Remove by model
7: Replace phone
p: Print phones
0: Exit admin menu";
            Console.WriteLine(menu);
        }

        void handleAdminInput(string adminInput)
        {
            switch (adminInput)
            {
                case "1":
                    executeAddPhoneMenu();
                    break;
                case "2":
                    executeAddSeveralPhonesMenu(enterQuantity());
                    break;
                case "3":
                    executeRemovePhoneMenu(enterIdx());
                    break;
                case "4":
                    executeRemoveLastPhonesMenu(enterQuantity());
                    break;
                case "5":
                    executeRemoveByBrandMenu(enterBrand());
                    break;
                case "6":
                    executeRemoveByModelMenu(enterModel());
                    break;
                case "7":
                    executeReplacePhoneMenu(enterIdx());
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

        void safeHandleAdminInput(string adminInput)
        {
            try
            {
                handleAdminInput(adminInput);
            }
            catch (Error error)
            {
                Logger.Instance().LogError(error);
            }

            catch 
            {
                Logger.Instance().LogError(new Error(ErrorCode.UnknownError));
            }
        }

        void executeAddPhoneMenu()
        {
            phoneRepository.Add(new Phone());
        }

        void executeAddSeveralPhonesMenu(int quantity)
        {
            Phone phone = new Phone();
            for (int i = 0; i < quantity; i++)
            {
                phoneRepository.Add(phone);
            }
        }

        void executeRemovePhoneMenu(int idx)
        {
            phoneRepository.Remove(idx);
        }

        void executeRemoveLastPhonesMenu(int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                phoneRepository.Remove(phoneRepository.Size - 1);
            }
        }

        void executeRemoveByBrandMenu(string brand)
        {
            for (int i = 0; i < phoneRepository.Size; i++)
            {
                if (phoneRepository[i].Brand == brand)
                {
                    phoneRepository.Remove(i);
                    i--;
                }
            }
        }

        void executeRemoveByModelMenu(string model)
        {
            for (int i = 0; i < phoneRepository.Size; i++)
            {
                if (phoneRepository[i].Model == model)
                {
                    phoneRepository.Remove(i);
                    i--;
                }
            }
        }

        void executeReplacePhoneMenu(int idx)
        {
            phoneRepository.Replace(new Phone(), idx);
        }

        void executePrintPhonesMenu()
        {
            Console.WriteLine("Phones:");
            phoneRepository.Print();
        }

        int enterIdx()
        {
            int idx;
            Console.WriteLine("Enter id:");
            idx = int.Parse(Console.ReadLine());

            return idx;
        }

        int enterQuantity()
        {
            int quantity;
            Console.WriteLine("Enter quantity:");
            quantity = int.Parse(Console.ReadLine());

            return quantity;
        }

        string enterBrand()
        {
            string brand;
            Console.WriteLine("Enter brand:");
            brand = Console.ReadLine();

            return brand;
        }

        string enterModel()
        {
            string model;
            Console.WriteLine("Enter model:");
            model = Console.ReadLine();

            return model;
        }
    }
}
