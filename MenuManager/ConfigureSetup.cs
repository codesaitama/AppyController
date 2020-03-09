using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuManager
{
    public class ConfigureSetup
    {

        public static ConfigureSetup Current;

        public ConfigureSetup()
        {
            Current = this;
        }

        public String Authority { get; set; }
        public String MenuServiceAPI { get; set; }
        public String URLAPIService { get; set; }
    }
}
