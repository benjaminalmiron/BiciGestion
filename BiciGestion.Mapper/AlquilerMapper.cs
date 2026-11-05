using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiciGestion.Entidades;

namespace BiciGestion.Mapper
{
    public static class AlquilerMapper
    {
        public static Alquiler Mapear(
            int idAlquiler,
            int idTipoBicicleta,
            string descripcionBicicleta,
            string dni,
            decimal importe,
            DateTime fechaRegistro,
            DateTime fechaAlquiler)
        {
            return new Alquiler
            {
                IdAlquiler = idAlquiler,
                Bicicleta = BicicletaMapper.Mapear(
                    idTipoBicicleta,
                    descripcionBicicleta),
                DniCliente = dni,
                ImporteTotal = importe,
                FechaRegistro = fechaRegistro,
                FechaAlquiler = fechaAlquiler
            };
        }
    }
}