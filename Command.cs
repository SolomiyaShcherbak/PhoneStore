using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public class Command
    {
        IRepository<Phone> phoneRepository;

        public int PhoneRepositorySize { get => phoneRepository.Size; }

        public Command()
        {
            var factory = FactoryCreator.GetFactory();
            //busRepository = factory.GetBusRepository();
            phoneRepository = factory.GetPhoneRepository();
        }

        public void SortPhonesByBrand()
        {
            phoneRepository.Sort(new BrandComparer<Phone>());
        }

        public void SortPhonesByModel()
        {
            phoneRepository.Sort(new ModelComparer<Phone>());
        }

        public void SortPhonesByPrice()
        {
            phoneRepository.Sort(new PriceComparer<Phone>());
        }

        public void PrintPhones()
        {
            Console.WriteLine("Phones:");
            phoneRepository.Print();
        }
    }
}
