using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateCar.service
{
    public class GetDataService
    {
        private static string selectedModel;

        public static string SelectedModel { get => selectedModel; set => selectedModel = value; }

        public static string TESTINGX
        {
            get
            {
                Console.WriteLine("TESTING GET DATA SERVICE");
                return "TESTING IN GET DATA SERVICE";
            }
        }
    }
}
