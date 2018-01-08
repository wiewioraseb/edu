using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateCar.service
{
    public class GetDataService
    {
        private static string selectedModel;
        private static BindingSource bindingSourceFromHost;

        public static string SelectedModel { get => selectedModel; set => selectedModel = value; }

        public static BindingSource BindingSourceFromHost
        {
            get
            {
                Console.WriteLine("Getting binding source from host.");
                return bindingSourceFromHost;
            }
            set
            {
                Console.WriteLine("Setting binding source in rate car.");
                bindingSourceFromHost = value;
            }
        }
    }
}
