using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_04_CSharpSyntax
{
    public class GetGrade
    {
        public static string GetGrading(int score)
        {
            if (score >= 95) { return "Distinction"; }
            else if (score >= 85) { return "Merit"; }
            else if (score >= 75) { return "Pass"; }
            else { return "Fail"; }
        }
    }
}
