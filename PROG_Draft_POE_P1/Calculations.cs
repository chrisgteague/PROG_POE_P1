using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Draft_POE_P1
{
    public class Calculations
    {
     
        public double creditNum;
        public double classHourNum;
        public double weekNum;


        public static double requiredStudyHrs(double creditNum, double classHourNum, double weekNum)
        {
            
            double selfStudyNum = ((creditNum * 10) / weekNum) - classHourNum;


            return selfStudyNum;
        }





            


        public static double SelfStudyCalc(double selfstudyHrs, double remainingHrs)
        {
            double result = remainingHrs - selfstudyHrs;
            if (result > 0)
            {
                return result;
            }
            else
            { result = 0;
                return result;
            } 


           
        }

      

    }
}
