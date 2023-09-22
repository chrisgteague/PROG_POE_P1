using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Module
    {public Module() { }
        public Module(string ModuleName, string ModuleCode, double NumberCredits, double NumClassHours)
        {
            moduleName = ModuleName;
            moduleCode = ModuleCode;
            numberCredits = NumberCredits;
            numClassHours = NumClassHours;
           
        }

        public string moduleName { get; set; }
       
        public string moduleCode { get; set; }
        public double numberCredits { get; set; }
        public double numClassHours { get; set; }
        public double remainingStudyHours { get; set; }



        override
            public string ToString()
        {
            
            return moduleName + moduleCode + numberCredits + numClassHours + remainingStudyHours;
        }
    }
}
