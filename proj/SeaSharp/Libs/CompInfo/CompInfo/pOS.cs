using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompInfo
{
    public class pOS
    {
        private int osVersion = 7;

        public int OsVersion
        {
            get
            {
                return osVersion;
            }
            set
            {
                if (value > 0 && value < 13)
                {
                    osVersion = value;
                }
                else
                {
                    osVersion = 55;
                }
            }
        
        }

        public string OsPlatform
        {
            get
            {
                Console.WriteLine("Environment.OSVersion.Platform: " + Environment.OSVersion.Platform.ToString());
                return Environment.OSVersion.Platform.ToString();
            }
        }

    }
}
