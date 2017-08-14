using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NewEmployee
{
    public static class RegexStrings
    {
        static Regex regex;
        static string regEmployee = @"(?<=Employee:\s)(\b\w*\b)\s(\b\w*\b)";
        static string regPosition = @"(?<=Position:\s)(.*)";
        static string regDM = @"(?<=Direct Manager:\s)(.*)";
        static string regDepartment = @"(?<=Department:\s)(.*)";
        static string regCity = @"(?<=City:\s)(.*)";
        static string regOffice = @"(?<=Office:\s)(.*)";
        static string regRoom = @"(?<=Office Room:\s)(.*)";

        public static string Name(this string str)
        {   
            regex = new Regex(regEmployee);
            return regex.Match(str).Value.Split()[0].Trim();         
        }
        public static string Surname(this string str)
        {
            regex = new Regex(regEmployee);
            return regex.Match(str).Value.Split()[1].Trim();
        }
        public static string Position(this string str)
        {
            regex = new Regex(regPosition);
            return regex.Match(str).Value.Trim();
            
        }
        public static string DM(this string str)
        {
            regex = new Regex(regDM);
            var DM = regex.Match(str).Value.Split();
            return DM[1] + " " + DM[0];
        }
        public static string Department(this string str)
        {
            regex = new Regex(regDepartment);
            return regex.Match(str).Value.Trim();           
        }
        public static string City(this string str)
        {
            regex = new Regex(regCity);
            return regex.Match(str).Value.Trim();
        }
        public static string Office(this string str)
        {
            regex = new Regex(regOffice);
            return regex.Match(str).Value.Trim();
        }
        public static string Room(this string str)
        {
            regex = new Regex(regRoom);
            return regex.Match(str).Value.Trim();
        }
    }
}
