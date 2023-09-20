using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Calculations
    {
        public static double SelfStudyCalc(double creditNum, double weekNum, double classHourNum)
        {
            Module module = new Module();
            Semester semester = new Semester();
            module.numberCredits = creditNum;
            module.numClassHours = classHourNum;
            semester.numWeeks = weekNum;
           
            double selfStudyNum = ((creditNum * 10) / weekNum) - classHourNum;



      return selfStudyNum;
        }
    }
}
