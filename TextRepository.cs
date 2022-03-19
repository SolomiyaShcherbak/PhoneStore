using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore
{
    public class TextRepository<T> : Repository<T> where T : IDevice
    {
        string sourceFileName;

        public TextRepository()
        {
            //todo: read from file
            //StreamReader, StremWriter, File
        }
    }
}
