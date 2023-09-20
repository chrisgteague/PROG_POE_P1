using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Module
    {
        public String moduleName { get; set; }
       
        public String moduleCode { get; set; }
        public double numberCredits { get; set; }
        public double numClassHours { get; set; }  

override
            public String ToString()
        {
            
            return moduleName + moduleCode + numberCredits + numClassHours;
        }
    }
}
