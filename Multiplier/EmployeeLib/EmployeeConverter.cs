using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class EmployeeConverter
    {
        private string myString;

        public string MyString {
            get
            {
                return myString;
            }
        }

        public void Convert(string myString)
        {
            string pattern = @"\""?([^\""""]*)\""? \""?([^\""""]*)\""? (\d{2}) (\d{5}).(\d{2}) (\d{3}-\d{7})";
            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";

            Match m = Regex.Match(input, pattern);

            var firstName = m.Groups[1].Value;
            var lastName = m.Groups[2].Value;
            var bornYear = DateTime.Now.AddYears(-int.Parse(m.Groups[3].Value)).Year;
            var salary1 = m.Groups[4].Value;
            var salary2 = m.Groups[5].Value;
            var phone = m.Groups[6].Value;


            this.myString = $"{lastName}, {firstName} (Lön: {salary1},{salary2} SEK) Telefon:{phone} Födelseår:{bornYear}";
        }
    }
}
