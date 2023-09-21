using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Calculations
    {
        public double SelfStudyCalc(double creditNum, double weekNum, double classHourNum, double selfstudyhrNum)
        {
            Module module = new Module();
            Semester semester = new Semester();
            module.NumberCredits = creditNum;
            module.NumClassHours = classHourNum;
            semester.numWeeks = weekNum;
           
            double selfStudyNum = ((creditNum * 10) / weekNum) - classHourNum;
      //where (record => (currentDate - record.date). totaldays < 7)
      //sum(record => record.hours);
    


      return selfStudyNum;
        }

    }
}
