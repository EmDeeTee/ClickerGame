namespace ClickerGame {
    public class Upgrade {
        public int Ammount { get; private set; } 
        public int Cost { get; private set; }
        public string Name { get; private set; }

        public Upgrade(string name, int ammount, int cost)
        {
            Ammount = ammount;
            Name = name;
            Cost = cost;

            Name += $" ({cost})";
        }
    }
}
