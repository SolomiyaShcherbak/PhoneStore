using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public interface IDevice
    {
        string Brand { get; set; }
        string Model { get; set; }
        double Price { get; set; }
    }
}
