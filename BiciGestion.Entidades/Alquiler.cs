using System;

namespace BiciGestion.Entidades
{
    public class Alquiler
    {
        public int IdAlquiler { get; set; }
        public string DniCliente { get; set; }
        public decimal ImporteTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaAlquiler { get; set; }

        public Bicicleta Bicicleta { get; set; }

        public Alquiler()
        {
        }

        public Alquiler(string dni, decimal importe, DateTime fechaAlquiler, Bicicleta bicicleta)
        {
            DniCliente = dni;
            ImporteTotal = importe;
            FechaAlquiler = fechaAlquiler;
            Bicicleta = bicicleta;
            FechaRegistro = DateTime.Now;
        }

        public Alquiler(int id, string dni, decimal importe,
                        DateTime fechaRegistro, DateTime fechaAlquiler, Bicicleta bicicleta)
        {
            IdAlquiler = id;
            DniCliente = dni;
            ImporteTotal = importe;
            FechaRegistro = fechaRegistro;
            FechaAlquiler = fechaAlquiler;
            Bicicleta = bicicleta;
        }
    }
}
