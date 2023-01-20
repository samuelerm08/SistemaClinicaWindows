using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Clinica;
using Datos;
using Entidades.Data;

namespace WindowsPresentacion
{
    public partial class ClinicaApp : Form
    {
        public ClinicaApp()
        {
            InitializeComponent();
        }

        private readonly DbClinicaContext context = new DbClinicaContext();
        private Medico m = new Medico();
        private Habitacion h = new Habitacion();

        //Eventos
        private void ClinicaApp_Load(object sender, EventArgs e)
        {
            foreach (var item in context.Medicos)
            {
                comboMedico.Items.Add($"{item.Nombre}");
            }

            foreach (var item in context.Habitaciones)
            {
                comboHabitacion.Items.Add($"{item.Numero}");
            }
        }
        private void Insertar(object sender, EventArgs e)
        {
            SelectedCombo();

            var p = new Paciente()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Domicilio = txtDomicilio.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                NroHistoriaClinica = int.Parse(txtNroHistCli.Text),
                MedicoId = m.ID,
                HabitacionId = h.ID
            };

            int rowsAffected = DacPaciente.Insert(p);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Paciente Insertado Con Éxito");
                ShowAll();

                txtNombre.ResetText();
                txtApellido.ResetText();
                txtDomicilio.ResetText();
                txtTelefono.ResetText();
                txtEmail.ResetText();
                txtNroHistCli.ResetText();
                comboMedico.ResetText();
                comboHabitacion.ResetText();
            }
        }
        private void Modificar(object sender, EventArgs e)
        {
            SelectedCombo();

            var p = new Paciente()
            {
                ID = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Domicilio = txtDomicilio.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                NroHistoriaClinica = int.Parse(txtNroHistCli.Text),
                MedicoId = m.ID,
                HabitacionId = h.ID
            };

            int rowsAffected = DacPaciente.Update(p);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Paciente Modificar Con Éxito");
                ShowAll();

                txtID.ResetText();
                txtNombre.ResetText();
                txtApellido.ResetText();
                txtDomicilio.ResetText();
                txtTelefono.ResetText();
                txtEmail.ResetText();
                txtNroHistCli.ResetText();
                comboMedico.ResetText();
                comboHabitacion.ResetText();
            }
        }
        private void VerTodos(object sender, EventArgs e)
        {
            ShowAll();
        }
        private void VerUno(object sender, EventArgs e)
        {
            int nro = int.Parse(txtNroHistCli.Text);
            var p = DacPaciente.Select(nro);
            m = DacMedico.SelectById(p.MedicoId);
            h = DacHabitacion.SelectById(p.HabitacionId);

            MessageBox.Show($"Paciente: \n{p}\nMedico: {m.Nombre}\nHabitacion: {h.Numero}");
            txtNroHistCli.ResetText();
        }
        private void Eliminar(object sender, EventArgs e)
        {
            var p = new Paciente() { ID = int.Parse(txtID.Text) };

            int rowsAffected = DacPaciente.Delete(p);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Paciente Eliminado Con Éxito");
                ShowAll();

                txtID.ResetText();
            }
        }
        private void ShowAll()
        {
            gridPacientes.DataSource = DacPaciente.SelectAll();
        }
        private void SelectedCombo()
        {
            foreach (var i in context.Medicos)
            {
                if (comboMedico.Text == i.Nombre)
                {
                    m = i;
                }
            }

            foreach (var j in context.Habitaciones)
            {
                if (comboHabitacion.Text == j.Numero)
                {
                    h = j;
                }
            }
        }
    }
}
