﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame {
    public partial class Form1 : Form {
        public static Form1 Instance;

        public Form1() {
            InitializeComponent();
            Instance = this;

            Task waitDialogTask = ShowWaitDialogAsync();
            Thread.Sleep(1000);
            UpdatePoints();
            Game.Instance.InitAchievements();
            LuaHandler.BridgeCSToLUA();
            LuaHandler.InitQuote();
            StateSaver.LoadGameInstance();
            Game.Instance.InitUpgrades();

            LuaHandler.InvokeEvent("OnGameStart", new object[] {});
            Game.StartBackgroundWorker();
        }

        public async Task ShowWaitDialogAsync()  {
            using (WaitDialog waitDialog = new WaitDialog("Loading database...")) {
                waitDialog.Show(Form1.Instance);
                waitDialog.Focus();
                await Task.Delay(2000); // Simulate some asynchronous work
            }
        }

        // I'm trying to separate the visual stuff from the logic
        // So the visual components, like the points label are 'private' and are invisible to other classes
        public void UpdatePoints() {
            if (LabelPoints.InvokeRequired) {
                LabelPoints.Invoke(new MethodInvoker(delegate
                {
                    LabelPoints.Text = Game.Instance.Points.ToString();
                }));
            }

            // NOTE: I think this will crash sometimes due to cross thread stuff...?
            LabelPoints.Text = Game.Instance.Points.ToString();
        }

        public void AddUpgradeToList(Upgrade upgrade) {
            ListBoxUpgrades.Items.Add(upgrade.Name);
        }

        public void RemoveUpgradeFromList(string upgrade) {
            ListBoxUpgrades.Items.Remove(upgrade);
        }

        private void ButtonClick_Click(object sender, EventArgs e) {
            Game.Instance.HandleClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (!ProgramArgumentParser.Option(ProgramArgumentParser.OPTIONS.NO_SAVE)) {
                StateSaver.SaveGameInstance();
            }
            Log.Flush();
        }

        public void SetQuote(string quote) {
            LabelQuote.Text = quote;
        }

        private void ButtonUpgradeBuy_Click(object sender, EventArgs e) {
            object item = ListBoxUpgrades.SelectedItem;
            if (item == null)
                return;
            
            Upgrade SelectedUpgrade = Game.Instance.Upgrades.FirstOrDefault(upgrade => upgrade.Name == item.ToString());

            if (SelectedUpgrade.Cost > Game.Instance.Points) 
                return;
            Game.Instance.Points -= SelectedUpgrade.Cost;
            RemoveUpgradeFromList(item.ToString());
            SelectedUpgrade.Apply();
        }

        private void ButtonClear_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to erase the database?", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                StateSaver.EraseSavedInstance();
                Application.Restart();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)  {
            if (e.KeyCode == Keys.R) {
                LuaHandler.InitQuote();
                Achievement.CompleteAchievement(Game.Instance.GetAchievement("Hot reload!"));
            }
        }

        private void achievementToolStripMenuItem_Click(object sender, EventArgs e) {
            //new AchievementsForm().ShowDialog();
        }

        private void achievementToolStripMenuItem_Click_1(object sender, EventArgs e) {
            new AchievementsForm().ShowDialog();
        }

        private void saveNowToolStripMenuItem_Click(object sender, EventArgs e) {
            StateSaver.SaveGameInstance();
        }
    }
}
