using System;
using System.Collections.Generic;

namespace PhoneStore
{
    static public class FactoryCreator
    {
        public static IFactory GetFactory()
        {
            //todo: dynamic based on parameter from config!
            return new MemoryFactory();
        }
    }
}