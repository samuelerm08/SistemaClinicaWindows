using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPresentacion.Sistema;
using WindowsPresentacion.Usuarios;

namespace WindowsPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "My First Application",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }       

        private void FechaHora(object sender, EventArgs e)
        {
            labelDate.Text = "Fecha: " + DateTime.Now.ToString();
        }

        private void VerPacientes(object sender, EventArgs e)
        {
            var pacientes = new Pacientes();
            pacientes.ShowDialog();
        }

        private void VerHabitaciones(object sender, EventArgs e)
        {
            var habitaciones = new Habitaciones();
            habitaciones.ShowDialog();
        }

        private void VerMedicos(object sender, EventArgs e)
        {
            var medicos = new Medicos();
            medicos.ShowDialog();
        }

        private void Salir(object sender, EventArgs e)
        {            
            this.Close();
            Environment.Exit(0);
        }
    }
}
