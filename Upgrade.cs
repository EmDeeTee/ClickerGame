using Newtonsoft.Json;

namespace ClickerGame {
    public class Upgrade {
        public int Cost { get; private set; }
        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public bool Purchased { get; private set; }

        public delegate void UpgradeAction();

        public event UpgradeAction OnUpgrade;

        public Upgrade(string name, int cost, UpgradeAction action) {
            Cost = cost;
            Name = name;
            // TODO: This seems to corrupt the save file by repeating the cost after each save
            //Name = $"{name} ({cost})";
            OnUpgrade = action;
        }
        /// <summary>
        /// Invokes the event associated with the upgrade
        /// and marks it as purchased
        /// </summary>
        public void Apply() {
            OnUpgrade.Invoke();
            Purchased = true;
        }
    }
}
