using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_04_RangeBasedSwitch
{
    public class Grade
    {
        public static string GetGrade(int score)
        {
            string returnVal = "";

            switch (score)
            {
                case int x when (x >= 95):
                    returnVal = "Distinction";
                    break;
                case int x when (x >= 85):
                    returnVal = "Merit";
                    break;
                case int x when (x >= 75):
                    returnVal = "Pass";
                    break;

                default:
                    returnVal = "Fail";
                    break;
            }

            return returnVal;
        }
    }
}
