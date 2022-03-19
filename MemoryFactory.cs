using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    /// <summary>
    /// Sync will not work!!!
    /// </summary>
    public class MemoryFactory : IFactory
    {
        public IRepository<Phone> GetPhoneRepository()
        {
            return new Repository<Phone>();
        }

        //public IRepository<Bus> GetBusRepository()
        //{
        //    return new Repository<Bus>();
        //}
    }
}
