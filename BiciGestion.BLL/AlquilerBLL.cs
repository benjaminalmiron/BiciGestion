using System;
using System.Collections.Generic;
using BiciGestion.DAL;
using BiciGestion.Entidades;
using System.Transactions;


namespace BiciGestion.BLL
{
    public class AlquilerBLL
    {
        private readonly AlquilerDAL dal = new AlquilerDAL();

        public List<Alquiler> GetAll()
        {
            return dal.GetAll();
        }

        public Alquiler GetById(int id)
        {
            if (id <= 0)
                throw new Exception("El ID debe ser mayor a cero.");

            return dal.GetById(id);
        }

        public void Insert(Alquiler alquiler)
        {
            Validar(alquiler);
            alquiler.FechaRegistro = DateTime.Now;

            using (TransactionScope transaccion = new TransactionScope())
            {
                dal.Insert(alquiler);

                transaccion.Complete();
            }
        }

        public void InsertarLista(List<Alquiler> alquileres)
        {
            if (alquileres == null || alquileres.Count == 0)
                throw new Exception("No hay alquileres para registrar.");

            foreach (Alquiler alquiler in alquileres)
            {
                Validar(alquiler);
                alquiler.FechaRegistro = DateTime.Now;
            }

            using (TransactionScope transaccion = new TransactionScope())
            {
                foreach (Alquiler alquiler in alquileres)
                {
                    dal.Insert(alquiler);
                }

                transaccion.Complete();
            }
        }


        public void Update(Alquiler alquiler)
        {
            if (alquiler == null)
                throw new Exception("El alquiler es obligatorio.");

            if (alquiler.IdAlquiler <= 0)
                throw new Exception("El ID debe ser mayor a cero.");

            Alquiler existente = GetById(alquiler.IdAlquiler);

            if (existente == null)
                throw new Exception("No existe un alquiler con ese ID.");

            if (string.IsNullOrWhiteSpace(alquiler.DniCliente))
                throw new Exception("El DNI es obligatorio.");

            if (alquiler.DniCliente.Length <= 5)
                throw new Exception("El DNI debe tener más de 5 caracteres.");

            if (alquiler.ImporteTotal <= 0)
                throw new Exception("El importe debe ser mayor a cero.");

            if (alquiler.FechaAlquiler.Date < DateTime.Now.Date)
                throw new Exception("La fecha del alquiler no puede ser anterior a hoy.");

            using (TransactionScope transaccion = new TransactionScope())
            {
                dal.Update(alquiler);

                transaccion.Complete();
            }
        }

        public void Delete(int id)
        {
            Alquiler existente = GetById(id);

            if (existente == null)
                throw new Exception("No existe un alquiler con ese ID.");

            using (TransactionScope transaccion = new TransactionScope())
            {
                dal.Delete(id);

                transaccion.Complete();
            }
        }

        private void Validar(Alquiler alquiler)
        {
            if (alquiler == null)
                throw new Exception("El alquiler es obligatorio.");

            if (alquiler.Bicicleta == null)
                throw new Exception("Debe seleccionar una bicicleta.");

            if (alquiler.Bicicleta.IdTipoBicicleta <= 0)
                throw new Exception("Debe seleccionar un tipo de bicicleta.");

            if (string.IsNullOrWhiteSpace(alquiler.DniCliente))
                throw new Exception("El DNI es obligatorio.");

            if (alquiler.DniCliente.Length <= 5)
                throw new Exception("El DNI debe tener más de 5 caracteres.");

            if (alquiler.ImporteTotal <= 0)
                throw new Exception("El importe debe ser mayor a cero.");

            if (alquiler.FechaAlquiler.Date < DateTime.Now.Date)
                throw new Exception("La fecha del alquiler no puede ser anterior a hoy.");
        }

        public void ValidarAlquiler(Alquiler alquiler)
        {
            Validar(alquiler);
        }
    }
}