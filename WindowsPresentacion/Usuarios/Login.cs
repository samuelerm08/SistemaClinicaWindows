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
using Datos;
using Entidades.Data;
using Entidades.Models.Clinica;

namespace WindowsPresentacion.Usuarios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private readonly DbClinicaContext context = new DbClinicaContext();
        private Usuario u = new Usuario();

        private void Registrar(object sender, EventArgs e)
        {                     
            var registro = new Registro();
            registro.ShowDialog();
        }

        private void Ingreso(object sender, EventArgs e)
        {
            var usuarioValido = DacUsuario.Validate(userText.Text, passwordText.Text);

            if (usuarioValido != null)
            {
                MessageBox.Show("Ingreso Exitoso");
            }
            else
                MessageBox.Show("Usuario invalido, volver a intentar");

            userText.ResetText();
            passwordText.ResetText();
        }          
    }
}
