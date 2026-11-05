using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BiciGestion.BLL;
using BiciGestion.Entidades;

namespace BiciGestion.UI
{
    public partial class Form1 : Form
    {
        private readonly AlquilerBLL alquilerBLL = new AlquilerBLL();
        private List<Alquiler> borrador = new List<Alquiler>();

        public Form1()
        {
            InitializeComponent();
            CargarAlquileres();
            ConfigurarBorrador();
        }

        private void CargarAlquileres()
        {
            try
            {
                dgvAlquileres.DataSource = null;
                dgvAlquileres.DataSource = alquilerBLL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Limpiar()
        {
            txtDni.Clear();
            txtImporte.Clear();
            cmbTipo.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void ConfigurarBorrador()
        {
            dgvBorrador.AutoGenerateColumns = false;
            dgvBorrador.Columns.Clear();

            dgvBorrador.Columns.Add("Dni", "DNI");
            dgvBorrador.Columns.Add("Bicicleta", "Tipo de bicicleta");
            dgvBorrador.Columns.Add("Importe", "Importe");
            dgvBorrador.Columns.Add("Fecha", "Fecha de alquiler");

            dgvBorrador.ReadOnly = true;
            dgvBorrador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrador.MultiSelect = false;
            dgvBorrador.AllowUserToAddRows = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtImporte.Text, out decimal importe))
                    throw new Exception("El importe no tiene un formato válido.");

                int idTipo = cmbTipo.SelectedIndex + 1;

                Bicicleta bicicleta;

                switch (idTipo)
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
                        throw new Exception("Seleccione un tipo de bicicleta válido.");
                }

                bicicleta.IdTipoBicicleta = idTipo;

                Alquiler alquiler = new Alquiler
                {
                    Bicicleta = bicicleta,
                    DniCliente = txtDni.Text,
                    ImporteTotal = importe,
                    FechaAlquiler = dtpFecha.Value,
                    FechaRegistro = DateTime.Now
                };

                alquilerBLL.Insert(alquiler);

                MessageBox.Show("Alquiler registrado correctamente.");
                Limpiar();
                CargarAlquileres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarAlquileres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID del alquiler que desea modificar:",
                    "Modificar alquiler");

                if (!int.TryParse(respuesta, out int id))
                    throw new Exception("El ID debe ser un número entero.");

                Alquiler alquiler = alquilerBLL.GetById(id);

                if (alquiler == null)
                    throw new Exception("No existe un alquiler con ese ID.");

                string dni = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el DNI del cliente:",
                    "Modificar alquiler",
                    alquiler.DniCliente);

                string importeTexto = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el importe:",
                    "Modificar alquiler",
                    alquiler.ImporteTotal.ToString());

                if (!decimal.TryParse(importeTexto, out decimal importe))
                    throw new Exception("El importe no tiene un formato válido.");

                string fechaTexto = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la fecha del alquiler (dd/MM/yyyy):",
                    "Modificar alquiler",
                    alquiler.FechaAlquiler.ToString("dd/MM/yyyy"));

                if (!DateTime.TryParseExact(
                    fechaTexto,
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime fecha))
                    throw new Exception("La fecha no tiene un formato válido.");

                alquiler.DniCliente = dni;
                alquiler.ImporteTotal = importe;
                alquiler.FechaAlquiler = fecha;

                DialogResult confirmacion = MessageBox.Show(
                    "¿Confirma la modificación del alquiler?",
                    "Confirmar modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    alquilerBLL.Update(alquiler);

                    MessageBox.Show("Alquiler modificado correctamente.");

                    CargarAlquileres();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el ID del alquiler que desea eliminar:",
                    "Eliminar alquiler");

                if (!int.TryParse(respuesta, out int id))
                    throw new Exception("El ID debe ser un número entero.");

                alquilerBLL.Delete(id);

                MessageBox.Show("Alquiler eliminado correctamente.");

                Limpiar();
                CargarAlquileres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAgregarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtImporte.Text, out decimal importe))
                    throw new Exception("El importe no tiene un formato válido.");

                if (cmbTipo.SelectedIndex < 0)
                    throw new Exception("Seleccione un tipo de bicicleta.");

                int idTipo = cmbTipo.SelectedIndex + 1;

                Bicicleta bicicleta;

                switch (idTipo)
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
                        throw new Exception("Tipo de bicicleta inválido.");
                }

                bicicleta.IdTipoBicicleta = idTipo;
                bicicleta.Descripcion = cmbTipo.Text;

                Alquiler alquiler = new Alquiler
                {
                    Bicicleta = bicicleta,
                    DniCliente = txtDni.Text,
                    ImporteTotal = importe,
                    FechaAlquiler = dtpFecha.Value,
                    FechaRegistro = DateTime.Now
                };

                alquilerBLL.ValidarAlquiler(alquiler);

                borrador.Add(alquiler);

                dgvBorrador.Rows.Add(
                    alquiler.DniCliente,
                    alquiler.Bicicleta.Descripcion,
                    alquiler.ImporteTotal,
                    alquiler.FechaAlquiler.ToShortDateString()
                );

                MessageBox.Show("Alquiler agregado al borrador.");

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnConfirmarBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                if (borrador.Count == 0)
                    throw new Exception("No hay alquileres en el borrador.");

                alquilerBLL.InsertarLista(borrador);

                MessageBox.Show("Todos los alquileres se registraron correctamente.");

                borrador.Clear();
                dgvBorrador.Rows.Clear();

                CargarAlquileres();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
