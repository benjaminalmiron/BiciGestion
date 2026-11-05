using System;
using BiciGestion.Entidades;

namespace BiciGestion.Mapper
{
    public static class BicicletaMapper
    {
        public static Bicicleta Mapear(int id, string descripcion)
        {
            Bicicleta bicicleta;

            switch (id)
            {
                case 1:
                    bicicleta = new BicicletaUrbana();
                    break;

                case 2:
                    bicicleta = new BicicletaMontana();
                    break;

                case 3:
                    bicicleta = new BicicletaElectrica();
                    break;

                default:
                    throw new Exception("Tipo de bicicleta inexistente.");
            }

            bicicleta.IdTipoBicicleta = id;
            bicicleta.Descripcion = descripcion;

            return bicicleta;
        }
    }
}