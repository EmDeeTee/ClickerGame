using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame {
    public static class ProgramArgumentParser {
        public enum OPTIONS {
            NO_SAVE
        }

        private static readonly Dictionary<OPTIONS, bool> ProgramOptions = new Dictionary<OPTIONS, bool>();

        public static void Parse(string[] args) {
            foreach (var option in Enum.GetValues(typeof(OPTIONS)).Cast<OPTIONS>()) {
                ProgramOptions[option] = false;
            }

            if (args.Length == 0) 
                return;

            // NOTE: TODO: For now, just one argument is expected so I'm doing it like this
            if (args.Contains("--NoSave")) {
                ProgramOptions[OPTIONS.NO_SAVE] = true;
            }
        }

        public static bool Option(OPTIONS option) {
            return ProgramOptions[option];
        }
    }
}
