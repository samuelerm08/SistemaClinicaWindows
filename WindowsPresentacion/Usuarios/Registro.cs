using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades.Models.Clinica;

namespace WindowsPresentacion.Usuarios
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void Confirmar(object sender, EventArgs e)
        {
            var nuevoUsuario = new Usuario()
            {
                UserName = userName.Text,
                Password = password1.Text
            };

            var login = new Login();

            if (userName.Text.Trim() != string.Empty && password1.Text.Trim() != string.Empty && password2.Text != string.Empty)
            {
                if (password1.Text == password2.Text)
                {
                    valido.Text = "Las contraseñas coinciden";
                    valido.ForeColor = Color.Green;

                    DacUsuario.Insert(nuevoUsuario);
                    MessageBox.Show("Registro exitoso");
                    this.Hide();                    
                }
                else
                {
                    valido.Text = "Las contraseñas no coinciden";
                    valido.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar los campos correspondientes");
            }
        }
    }
}
