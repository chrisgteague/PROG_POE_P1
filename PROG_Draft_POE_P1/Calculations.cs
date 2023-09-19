using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Calculations
    {
        public string SelfStudyCalc(int creditNum, int weekNum, int classHourNum)
        {
            
            
           
            int selfStudyNum = ((creditNum * 10) / weekNum) - classHourNum;
            
            
            return selfStudyNum.ToString();

        }
    }
}
