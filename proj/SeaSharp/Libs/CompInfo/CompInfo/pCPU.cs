using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompInfo
{
    public class pCPU
    {

        public string NumberOfProcessors
        {
            get
            {
                Console.WriteLine("Environment.GetEnvironmentVariable('NUMBER_OF_PROCESSORS').ToString(): " + Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS").ToString());
                return Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS").ToString();
            }
        }

        public string Architecture
        {
            get
            {
                Console.WriteLine("Environment.GetEnvironmentVariable('PROCESSOR_ARCHITECTURE').ToString(): " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString());
                return Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString();
            }
        }

    }
}
