using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ClickerGame
{
    public static class Game {
        private static int _points = 0;
        public static int Points {
            get { return _points; }
            set {_points = value; Form1.Instance.UpdatePoints(); } 
        }
        public static int ClickPayout { get; private set; } = 1;

        public static Upgrade[] Upgrades = new Upgrade[] {
            new Upgrade("Better Clicks 1", 1, 10),
        };

        /*public static Achievement[] Achievements = new Achievement[] {
            new Achievement("nice", "Get 69 points"),
            new Achievement("Hot reload!", "Press R to reload LUA script"),
        };*/

        public static void InitUpgrades() {
            foreach (Upgrade upgrade in Upgrades) {
                Form1.Instance.AddUpgradeToList(upgrade);
            }
        }

        public static void AddPoints(int points) {
            Points += points;
        }

        public static void ApplayUpgrade(Upgrade upgrade) {
            ClickPayout += upgrade.Ammount;
        }

        // A wrapper for MessageBox.Show for bridge to LUA
        public static void ShowMessage(object msg) {
            MessageBox.Show(msg.ToString());
        }

        public static void HandleClick() {
            Points += ClickPayout;
            Points = Convert.ToInt32(LuaHandler.InvokeEvent("OnButtonClick", new object[] { Points }));
        }
    }
}
