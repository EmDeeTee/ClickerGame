using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClickerGame
{
    public class Game {
        public static Game Instance = new Game();

        private int _points = 0;
        public int Points {
            get { return _points; }
            set {_points = value; Form1.Instance.UpdatePoints(); } 
        }
        public int ClickPayout { get; set; } = 1;

        public List<Upgrade> Upgrades = new List<Upgrade>();

        public List<Achievement> Achievements = new List<Achievement>();

        public void ApplayUpgrade(Upgrade upgrade) {
            ClickPayout += upgrade.Ammount;
        }
        public void InitUpgrades() {
            Upgrades.Add(new Upgrade("Better Clicks 1", 1, 10));

            foreach (Upgrade upgrade in Upgrades) {
                Form1.Instance.AddUpgradeToList(upgrade);
            }
        }

        public void InitAchievements() {
            Achievements.Add(new Achievement("nice", "Get 69 points"));
            Achievements.Add(new Achievement("Hot reload!", "Press R to reload LUA script"));
        }

        // Has to be like that for LUA bridge
        public void CreateAchievement(string name, string description) {
            Achievements.Add(new Achievement(name, description));
        }

        public Achievement GetAchievement(string name) {
            return Achievements.First(x => x.Name == name);
        }

        public void AddPoints(int points) {
            Points += points;
        }

        // A wrapper for MessageBox.Show for bridge to LUA
        public void ShowMessage(object msg) {
            MessageBox.Show(msg.ToString());
        }

        public void HandleClick() {
            Points += ClickPayout;
            Points = Convert.ToInt32(LuaHandler.InvokeEvent("OnButtonClick", new object[] { Points }));
        }
    }
}
