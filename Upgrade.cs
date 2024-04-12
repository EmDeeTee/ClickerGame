namespace ClickerGame {
    public class Upgrade {
        // NOTE: What in the holy fork is an ammount? I forgor.
        // TODO: There is no bool to indicate whether the upgrade is bough or not.
        public int Ammount { get; private set; } 
        public int Cost { get; private set; }
        public string Name { get; private set; }

        public Upgrade(string name, int ammount, int cost) {
            Ammount = ammount;
            Cost = cost;
            //Name = name;

            // TODO: This seems to corrupt the save file by repeating the cost after each save
            Name = $"{name} ({cost})";
        }
    }
}
