using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Class
    {
        public bool IsUrFavColorPurple(string color)
        {
            if (color.ToLower() == "purple")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsUrFavColorGray(string color)
        {
            if (color.ToLower() == "gray") return true;
            return false;
        }
        public bool IsUrFavColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true : false;
        }
    }
}
