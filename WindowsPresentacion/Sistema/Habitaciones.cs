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
                Estado = comboEstado.Text
            };

            try
            {
                var rA = DacHabitacion.Insert(hab);

                if (rA > 0)
                {
                    MessageBox.Show("Habitación insertada con éxito");
                    ShowAll();

                    txtNumero.ResetText();
                    comboEstado.ResetText();
                }
            }
            catch
            {
                MessageBox.Show("Se deben llenar todos los campos correctamente");
            }            
        }

        private void Editar(object sender, EventArgs e)
        {
            var hab = new Habitacion()
            {
                Numero = txtNumero.Text,
                Estado = comboEstado.Text
            };

            try
            {
                var rA = DacHabitacion.Insert(hab);

                if (rA > 0)
                {
                    MessageBox.Show("Habitación insertada con éxito");
                    ShowAll();

                    txtNumero.ResetText();
                    comboEstado.ResetText();
                }
            }
            catch
            {
                MessageBox.Show("Se deben llenar todos los campos correctamente");
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
            try
            {
                var hab = DacHabitacion.SelectById(int.Parse(txtID.Text));
                MessageBox.Show($"ID: {hab.ID}\n" +
                            $"Numero: {hab.Numero}\n" +
                            $"Estado: {hab.Estado}\n");
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un ID Válido");
            }
            
        }
        private void Eliminar(object sender, EventArgs e)
        {
            var habitacion = new Habitacion()
            {
                ID = int.Parse(txtID.Text)
            };

            try
            {
                int rowsAffected = DacHabitacion.Delete(habitacion);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Habitación eliminada con éxito");
                    ShowAll();
                }

                txtID.ResetText();
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un ID Válido");
            }            
        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {
            comboEstado.Items.Add("Disponible");
            comboEstado.Items.Add("Ocupada");
        }
    }
}
