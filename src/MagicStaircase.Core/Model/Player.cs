namespace MagicStaircase.Core
{
    public class Player
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Player)obj).Id == Id;
        }
        public override int GetHashCode() => Id.GetHashCode();
    }
}
