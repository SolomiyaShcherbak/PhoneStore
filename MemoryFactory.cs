using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public class MemoryFactory : IFactory
    {
        public IRepository<Phone> GetPhoneRepository()
        {
            return new Repository<Phone>();
        }
    }
}
