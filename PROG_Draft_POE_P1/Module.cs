using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Module
    {public Module() { }    
        public Module(string moduleName, string moduleCode, double numberCredits, double numClassHours)
        {
            ModuleName = moduleName;
            ModuleCode = moduleCode;
            NumberCredits = numberCredits;
            NumClassHours = numClassHours;
        }

        public string ModuleName { get; set; }
       
        public string ModuleCode { get; set; }
        public double NumberCredits { get; set; }
        public double NumClassHours { get; set; }  

override
            public string ToString()
        {
            
            return ModuleName + ModuleCode + NumberCredits + NumClassHours;
        }
    }
}
