using Datos;
using Entidades;
using Entidades.Clinica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion.Sistema
{
    public partial class Habitaciones : Form
    {
        public Habitaciones()
        {
            InitializeComponent();
        }

        private void Insert(object sender, EventArgs e)
        {
            var hab = new Habitacion()
            {
                Numero = txtNumero.Text,
                Estado = txtEstado.Text
            };

            var rA = DacHabitacion.Insert(hab);

            if (rA > 0)
            {
                MessageBox.Show("Habitación insertada con éxito");
                ShowAll();

                txtNumero.ResetText();
                txtEstado.ResetText();
            }
        }

        private void Editar(object sender, EventArgs e)
        {
            var hab = new Habitacion()
            {
                Numero = txtNumero.Text,
                Estado = txtEstado.Text
            };

            var rA = DacHabitacion.Insert(hab);

            if (rA > 0)
            {
                MessageBox.Show("Habitación insertada con éxito");
                ShowAll();

                txtNumero.ResetText();
                txtEstado.ResetText();
            }
        }

        private void VerTodos(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            gridHabitacion.DataSource = DacHabitacion.SelectAll();
        }

        //Ver por ID
        private void VerUno(object sender, EventArgs e)
        {
            var hab = DacHabitacion.SelectById(int.Parse(txtID.Text));

            MessageBox.Show($"ID: {hab.ID}\n" +
                            $"Numero: {hab.Numero}\n" +
                            $"Estado: {hab.Estado}\n");
        }

        private void Eliminar(object sender, EventArgs e)
        {
            var habitacion = new Habitacion()
            {
                ID = int.Parse(txtID.Text)
            };

            int rowsAffected = DacHabitacion.Delete(habitacion);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Habitación eliminada con éxito");
                ShowAll();
            }

            txtID.ResetText();
        }
    }
}
