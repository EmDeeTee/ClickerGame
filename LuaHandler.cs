using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLua;
using NLua.Exceptions;

namespace ClickerGame
{
    public static class LuaHandler {
        static Lua Lua = new Lua();
        
        // TODO: The name is misleading, as it not only inits the quote, but also reloads the whole LUA script
        public static void InitQuote() {
            if (!File.Exists("Script.lua")) {
                MessageBox.Show("Script.lua not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                Lua.DoFile("Script.lua");
            } catch (LuaScriptException e) {
                MessageBox.Show($"Error: {e.Message}");
                Application.Exit();
            }
            
            LuaTable quote = Lua["Quotes"] as LuaTable;
            Random random = new Random();
            int randomIndex = random.Next(0, quote.Values.Count);

            string randomElement = quote[randomIndex + 1] as string;
            Form1.Instance.SetQuote(randomElement);
        }

        public static void BridgeCSToLUA() {
            Lua["ShowMessage"] = new Action<string>(Game.Instance.ShowMessage);
            Lua["CompleteAchievement"] = new Action<Achievement>(Achievement.CompleteAchievement);

            Lua["Achievements"] = Game.Instance.Achievements;
            Lua.RegisterFunction("CreateAchievement", Game.Instance, typeof(Game).GetMethod("CreateAchievement"));
            Lua.RegisterFunction("GetAchievement", Game.Instance, typeof(Game).GetMethod("GetAchievement"));
        }

        public static object InvokeEvent(string name, object[] args) {
            LuaFunction function = Lua.GetFunction(name);
            object[] retArgs = function.Call(args);
            if (retArgs.Length > 0) {
                // That's a meh solution, since We always return the first arg... and there might be more
                return retArgs.First();
            }
            else {
                return 0;
            }
        }
    }
}
