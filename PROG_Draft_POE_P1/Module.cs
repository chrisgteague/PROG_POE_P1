using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Module
    {
        public string moduleName { get; set; }
        public List<Semester> semesters = new List<Semester>();
        public List<RecordStudy> recordStudy = new List<RecordStudy>();
        public string moduleCode { get; set; }
        public int numberCredits { get; set; }
        public int numClassHours { get; set; }  

override
            public string ToString()
        {
            
            return moduleName + moduleCode;
        }
    }
}
