using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Common
{
    public class YearUtils
    {
        public static bool IsCurrentYear(DateTime date)
        {
            bool ret = (date.Year == DateTime.Now.Year);
            return ret;
        }

        public static bool IsLastYear(DateTime date)
        {
            bool ret = (date.Year == (DateTime.Now.Year - 1));
            return ret;
        }
    }
}
