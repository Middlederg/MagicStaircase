namespace MagicStaircase.Core
{
    public class Player
    {
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Player)obj).Name.Equals(Name);
        }
        public override int GetHashCode() => Name.GetHashCode();
    }
}
