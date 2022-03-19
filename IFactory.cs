using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public interface IFactory
    {
        IRepository<Phone> GetPhoneRepository();
        //IRepository</> GetBusRepository();
    }
}
