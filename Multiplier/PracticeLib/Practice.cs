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

        public string Transformation(string fileContent)
        {
            string[] words = fileContent.Split(';');
            DateTime dt = Convert.ToDateTime(words[0]);
            //var age = (DateTime.Now.Year - dt.Year);

            var age = (int)((DateTime.Today - dt).Days / 365.25);

            var transformedText = $"{words[1]} är {age} år gammal och har telfonnummer {words[2]}";

            return transformedText;
        }
    }
}
