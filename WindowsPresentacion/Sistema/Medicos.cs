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
using Datos;


namespace WindowsPresentacion.Sistema
{
    public partial class Medicos : Form
    {
        public Medicos()
        {
            InitializeComponent();
        }

        private void Insertar(object sender, EventArgs e)
        {
            var medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Domicilio = txtDomicilio.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Especialidad = txtEsp.Text,
                Matricula = txtMatr.Text
            };

            int rowsAffected = DacMedico.Insert(medico);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Medico Insertado Con Éxito");
                ShowAll();

                txtNombre.ResetText();
                txtApellido.ResetText();
                txtDomicilio.ResetText();
                txtTelefono.ResetText();
                txtEmail.ResetText();
                txtEsp.ResetText();
                txtMatr.ResetText();
            }
        }

        private void Editar(object sender, EventArgs e)
        {
            var medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Domicilio = txtDomicilio.Text,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                Especialidad = txtEsp.Text,
                Matricula = txtMatr.Text
            };

            int rowsAffected = DacMedico.Update(medico);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Medico Modificado Con Éxito");
                ShowAll();

                txtNombre.ResetText();
                txtApellido.ResetText();
                txtDomicilio.ResetText();
                txtTelefono.ResetText();
                txtEmail.ResetText();
                txtEsp.ResetText();
            }
        }

        private void VerTodos(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            gridMedicos.DataSource = DacMedico.SelectAll();
        }

        //Ver por ID
        private void VerUno(object sender, EventArgs e)
        {
            var medico = DacMedico.SelectById(int.Parse(txtId.Text));

            MessageBox.Show($"Nombre: {medico.Nombre}\n" +
                            $"Apellido: {medico.Apellido}\n" +
                            $"Matricula: {medico.Matricula}\n" +
                            $"Telefono: {medico.Telefono}");
        }

        private void Eliminar(object sender, EventArgs e)
        {
            var medico = new Medico()
            {
                ID = int.Parse(txtId.Text)
            };

            int rowsAffected = DacMedico.Delete(medico);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Medico eliminado con éxito");
                ShowAll();
            }
            
            txtId.ResetText();
        }        
    }
}

