using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class DarkTheme:ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public string GetHeader(int width)
        {
            return new string('*', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
