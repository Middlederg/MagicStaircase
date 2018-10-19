namespace MagicStaircase.Core.Model
{
    public class Perfil
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }

        public Perfil(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString() => Nombre;
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return ((Perfil)obj).Id == Id;
        }
        public override int GetHashCode() => Id.GetHashCode();
    }
}
