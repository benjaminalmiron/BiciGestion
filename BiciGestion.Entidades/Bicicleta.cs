namespace BiciGestion.Entidades
{
    public abstract class Bicicleta
    {
        public int IdTipoBicicleta { get; set; }
        public string Descripcion { get; set; }

        public Bicicleta()
        {
        }

        public Bicicleta(int id, string descripcion)
        {
            IdTipoBicicleta = id;
            Descripcion = descripcion;
        }

        public abstract string ObtenerDescripcion();

        public virtual string ObtenerTipo()
        {
            return Descripcion;
        }

        ~Bicicleta()
        {
        }
    }

    public sealed class BicicletaUrbana : Bicicleta
    {
        public BicicletaUrbana() : base(1, "Urbana")
        {
        }

        public override string ObtenerDescripcion()
        {
            return "Bicicleta Urbana";
        }
    }

    public class BicicletaMontana : Bicicleta
    {
        public BicicletaMontana() : base(2, "Montaña")
        {
        }

        public override string ObtenerDescripcion()
        {
            return "Bicicleta de Montaña";
        }
    }

    public class BicicletaElectrica : Bicicleta
    {
        public BicicletaElectrica() : base(3, "Eléctrica")
        {
        }

        public override string ObtenerDescripcion()
        {
            return "Bicicleta Eléctrica";
        }
    }
}
