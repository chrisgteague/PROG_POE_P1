using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    class Module
    {
        public string moduleName { get; set; }
        public string moduleCode { get; set; }

override
            public string ToString()
        {
            return moduleName + moduleCode;
        }
    }
}
