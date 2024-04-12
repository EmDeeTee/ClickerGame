using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
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

        public static List<Upgrade> Upgrades = new List<Upgrade>();

        public static List<Achievement> Achievements = new List<Achievement>();

        public static void ApplayUpgrade(Upgrade upgrade) {
            ClickPayout += upgrade.Ammount;
        }
        public static void InitUpgrades() {
            Upgrades.Add(new Upgrade("Better Clicks 1", 1, 10));

            foreach (Upgrade upgrade in Upgrades) {
                Form1.Instance.AddUpgradeToList(upgrade);
            }
        }

        public static void InitAchievements() {
            Achievements.Add(new Achievement("nice", "Get 69 points"));
            Achievements.Add(new Achievement("Hot reload!", "Press R to reload LUA script"));
        }

        // Has to be like that for LUA bridge
        public static void CreateAchievement(string name, string description) {
            Achievements.Add(new Achievement(name, description));
        }

        public static Achievement GetAchievement(string name) {
            return Achievements.First(x => x.Name == name);
        }

        public static void AddPoints(int points) {
            Points += points;
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
