using System;
using System.Collections.Generic;
using System.Data;
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
        private static DataTable best3DataTableFromHost;
        private static DataTable most3DataTableFromHost;

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

        public static DataTable Best3DataTableFromHost
        {
            get
            {
                Console.WriteLine("Getting best3 dataTable from host.");
                return best3DataTableFromHost;
            }
            set
            {
                Console.WriteLine("Setting best3 dataTable in rate car.");
                best3DataTableFromHost = value;
            }
        }

        public static DataTable Most3DataTableFromHost
        {
            get
            {
                Console.WriteLine("Getting most3 dataTable from host.");
                return most3DataTableFromHost;
            }
            set
            {
                Console.WriteLine("Setting most3 dataTable in rate car.");
                most3DataTableFromHost = value;
            }
        }
    }
}
