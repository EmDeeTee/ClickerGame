using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame {
    public class Achievement {
        private static int CurrentId = 0;

        /*public static Achievement[] Achievements = new Achievement[] {
            new Achievement("nice", "Get 69 points"),
            new Achievement("Hot reload!", "Press R to reload LUA script"),
        };*/

        public static List<Achievement> Achievements = new List<Achievement>() {
            new Achievement("nice", "Get 69 points"),
            new Achievement("Hot reload!", "Press R to reload LUA script"),
        };

        public int Id { get; private set; } 
        public string Name { get; private set; } 
        public string Description { get; private set; }

        public bool IsCompleted { get; private set; }

        public Achievement(string name, string description) {
            Id = CurrentId;
            Name = name;
            Description = description;

            CurrentId++;
        }

        // Has to be like that for LUA bridge
        public static void CreateAchievement(string name, string description) {
            Achievements.Add(new Achievement(name, description));
        }

        public static Achievement GetAchievement(string name) {
            return Achievements.First(x => x.Name == name);
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
