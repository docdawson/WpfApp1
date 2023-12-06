using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Mathe
    {
                  
        /// <summary>
        /// ditte sieht doof aus
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int plus(int x, int y) { 
            return (x + y);   
        }

        public static int minus(int x, int y)
        {
            return (x - y);
        }

        public static int mal(int x, int y)
        {
            return x * y;
            
        }

        public static int geteilt(int x, int y)
        {
            int a;
            try
            {
                a = x / y;
            }
            catch
            {
                throw new ArgumentException();
            }
            return a;
        }

        public static string add(string a, string b)
        {
            return a+b;
        }
    }
}
