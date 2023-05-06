using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNlog
{
    public class NLog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string str)
        {
            logger.Debug(str);
        }
        public void LogError(string str)
        {
            logger.Error(str);
        }
        public void LogInfo(string str)
        {
            logger.Info(str);
        }
        public void LogWarning(string str)
        {
            logger.Warn(str);
        }
       
    }
}
