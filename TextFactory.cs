using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public class TextFactory : IFactory
    {
        public IRepository<Phone> GetPhoneRepository()
        {
            return new TextRepository<Phone>();
        }

        //public IRepository<Bus> GetBusRepository()
        //{
        //    return new TextRepository<Bus>();
        //}
    }
}
