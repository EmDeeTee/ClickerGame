using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            Log.Write("Program startup");
            ProgramArgumentParser.Parse(args);
            if (ProgramArgumentParser.Option(ProgramArgumentParser.OPTIONS.NO_SAVE)) {
                Log.Write("No save option enabled");
            }

            Game.InitGame();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
