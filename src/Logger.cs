using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

namespace Cordova.Extension.Commands
{
    class Logger : BaseCommand
    {
        public void log(String options) {
            System.Diagnostics.Debug.WriteLine("Logging From Plugin");
            string optVal = null;
            try {
                optVal = JsonHelper.Deserialize<string[]>(options)[0];
                System.Diagnostics.Debug.WriteLine(optVal);
                DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "Logger Logged"));
            }
            catch (Exception)
            {
                DispatchCommandResult(new PluginResult(PluginResult.Status.ERROR, "Logger signaled an error"));
            }
        }
    }
}
