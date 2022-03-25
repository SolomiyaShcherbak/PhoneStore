using System;
using System.Collections.Generic;
using System.Configuration;

namespace PhoneStore
{
    static public class FactoryCreator
    {
        public static IFactory GetFactory()
        {
            var type = System.Configuration.ConfigurationManager.AppSettings["FactoryType"];
            if (type == "TextFactory")
                return new TextFactory();
            else
                return new MemoryFactory();
        }
    }
}