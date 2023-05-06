using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNlog
{
    public class AddNumber
    {
        private readonly NLog nlog = new NLog();
        public int Sum(int first, int second)
        {
            if (first == 0 || second == 0)
            {
                nlog.LogDebug("Debug successfully");
                nlog.LogError("Having null value");
                nlog.LogWarning("Any number should not equal to zero");
            }
            int result = first + second;
            nlog.LogDebug("Debug successfully");
            nlog.LogInfo("Passed or executed " + result);
            return result;
        }
    }
}
