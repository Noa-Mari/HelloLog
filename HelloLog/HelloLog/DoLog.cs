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
        private ILog _log = LogManager.GetLogger(typeof(DoLog));
        private Random random = new Random();


        public void runLevel()
        {
            BasicConfigurator.Configure();
            XmlConfigurator.Configure(new FileInfo("/Users/noamari/Desktop/mamas2/HelloLog/HelloLog/HelloLog/App.xml"));

            _log.Info("testttt1");

            try
            {
                int level = random.Next(5); // 0 to 4

                switch (level)
                {
                    case 0:
                        _log.Debug("DEBUG");
                        break;
                    case 1:
                        _log.Info("INFO");
                        break;
                    case 2:
                        _log.Warn("WARN");
                        break;
                    case 3:
                        _log.Error("ERROR");
                        break;
                    case 4:
                        throw new Exception("throw FATAL");
                }

            }
            catch (Exception ex)
            {
                _log.Fatal(ex.Message);
            }

        }

    }
}