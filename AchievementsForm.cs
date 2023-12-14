using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame {
    public partial class AchievementsForm : Form {
        public AchievementsForm() {
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList() {
            foreach (Achievement achievement in Achievement.Achievements) {
                ListBoxA.Items.Add(achievement);
            }
        }

        private void ListBoxA_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBoxA.SelectedItem != null)
                RTBDescription.Text = (ListBoxA.SelectedItem as Achievement).Description;
        }
    }
}
