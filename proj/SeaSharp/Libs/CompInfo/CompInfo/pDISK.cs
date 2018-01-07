using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace CompInfo
{
    public class pDISK
    {

        public string Size(string drive) 
        {
            try
            {
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + "\"");
                disk.Get();
                return disk["Size"].ToString();
            }
            catch
            {
                Console.WriteLine("ERORR in Size() method!");
                return "0";
            }
        }

        public string FreeSpace
        {
            get
            {
                Console.WriteLine("Environment.GetEnvironmentVariable('PROCESSOR_ARCHITECTURE').ToString(): " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString());
                return Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString();
            }
        }
    }
}
