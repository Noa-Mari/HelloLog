using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace HelloLog
{
    public class DoLog
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(DoLog));

        public void Log()
        {
            BasicConfigurator.Configure();
            XmlConfigurator.Configure(new FileInfo("/Users/noamari/Desktop/mamas2/HelloLog/HelloLog/HelloLog/App.xml"));

            _log.Info("testttt1");

        }
    }
}