using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace UnitTestProject1.Common
{
    public class AppConfigManager
    {
        public static string GetBaseUrl()
        {
            return ConfigurationManager.AppSettings["BaseUrl"];
        }

        public static string GetBrowser()
        {
            return ConfigurationManager.AppSettings["Browser"];
        }

        public static TimeSpan ImplictWaitPeriod()
        {
            return TimeSpan.FromSeconds(double.Parse(ConfigurationManager.AppSettings["ImplicitWaitTime"]));
        }
    }
}
