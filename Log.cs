using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame {
    public static class Log {
        public static readonly int LOG_BUFFER_FLUSH_CAP = 100;
        private static List<string> _LogBuffer = new List<string>();

        /// <summary>
        /// Writes the message to the _LogBuffer. If the message will cause the LOG_BUFFER_FLUSH_CAP
        /// constant to be reached, only then the IO operation of writing the file will be performed.
        /// </summary>
        /// <returns></returns>
        public static bool Write(string msg) {
            // TODO: Add error handling
            if (_LogBuffer.Count < LOG_BUFFER_FLUSH_CAP) {
                _LogBuffer.Add($"[{DateTime.Now}] - {msg}");
            }
            else {
                Flush();
            }
                
            return true;
        }

        public static bool Flush() {
            // TODO: Add error handling

            File.AppendAllLines("./log.log", _LogBuffer);
            _LogBuffer.Clear();

            return true;
        }
    }
}
