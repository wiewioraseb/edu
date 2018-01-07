using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompInfo
{
    public partial class Computer : Component
    {
        pCPU objCPU = new CompInfo.pCPU();
        pOS objOS = new CompInfo.pOS();
        pDISK objDisk = new CompInfo.pDISK();

        public Computer()
        {
            InitializeComponent();
        }

        public Computer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public pCPU CPU
        {
            get
            {
                return objCPU;
            }
        }

        public pOS OS
        {
            get
            {
                return objOS;
            }
        }

        public pDISK Disk
        {
            get
            {
                return objDisk;
            }
        }

    }
}
