namespace TwoPlayer
{
    public class spelare
    {
        public string? name;
        public int points;
        public bool isBot;
        public spelare(string name, bool isBot = false)
        {
            this.name = name;
            this.isBot = isBot;
        }
    }

}
