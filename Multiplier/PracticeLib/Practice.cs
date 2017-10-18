using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLib
{
    public class Practice
    {
        public string FullText(string birthDate, string name, string phone)
        {
            var convertedText = $"{birthDate };{name };{phone }";
            return convertedText;
        }
        
    }
}
