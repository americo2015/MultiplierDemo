using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplier
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {
            List.Add("Marcos");
            List.Add("Gentri");
            List.Add("Nicolas");
            List.Add("Mohammed");
            List.Add("Mattias");
        }

        public void RemoveThirdString()
        {
            List.RemoveAt(2);
        }

        public void Sort()
        {
            List.Sort();
        }
        
    }

}
