using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BCrypt.Net;

namespace EjemploTabs_2021
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String passhasheada = BCrypt.Net.BCrypt.HashPassword(textBoxContraseña.Text, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(textBoxContraseña.Text + "  " + passhasheada);
            Conexion miConexion = new Conexion();
            Boolean resultado = miConexion.insertausuario(textBoxApellido.Text, passhasheada, textBoxDNI.Text, textBoxNombre.Text, textNumcuenta.Text, textBoxTelefono.Text);
            if (resultado)
            {
                MessageBox.Show("INSERTADO CORRECTAMENTE");
            }
            else {
                MessageBox.Show("Ha ocurrido un error inesperado y no se ha podido insertar. Pruebe mas tarde");
            }
        }

       
    }
}
