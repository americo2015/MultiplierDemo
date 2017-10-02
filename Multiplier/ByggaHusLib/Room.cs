using System.Collections.Generic;
using System.Linq;
using System;

namespace ByggaHusLib
{
    public class Room
    {
        private List<Window> Windows = new List<Window>();

        public int NumberOfClosedWindows
        {
            get
            {
                return Windows.Where(window => !window.IsOpen)
                    .Sum(window => 1);
            }
        }

        public void AddWindow(Window window1)
        {
            Windows.Add(window1);
        }
    }

}