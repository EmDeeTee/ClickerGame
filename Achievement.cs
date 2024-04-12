using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame {
    public class Achievement {
        public int Id { get; private set; } 
        public string Name { get; private set; } 
        public string Description { get; private set; }

        public bool IsCompleted { get; private set; }

        public Achievement(string name, string description) {
            Id = Game.Achievements.Count;
            Name = name;
            Description = description;
        }

        /// <summary>
        /// Silently complete the achievement
        /// </summary>
        public void Complete() {
            IsCompleted = true;
        }

        public void Lock() {
            IsCompleted = false;
        }

        public override string ToString() {
            if (IsCompleted)
                return Name + " (Completed)";
            return Name;
        }

        // For LUA bridge
        public static void CompleteAchievement(Achievement achievement) {
            if (achievement.IsCompleted) return;

            MessageBox.Show($"Achievement \"{achievement.Name}\" completed");
            achievement.Complete();
        }
    }
}
