using System.Collections.Generic;
using BiciGestion.DAL;
using BiciGestion.Entidades;

namespace BiciGestion.BLL
{
    public class TipoBicicletaBLL
    {
        private readonly TipoBicicletaDAL dal = new TipoBicicletaDAL();

        public List<Bicicleta> GetAll()
        {
            return dal.GetAll();
        }
    }
}