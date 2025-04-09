using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_P3_Rebeca
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int user = txbUsuario.Text;
            string pass = txbPassword.Text;

            var lista = cas.ObtenerUser();

            var validar = lista.FirstOrDefault(u => u.ID == user && u.Password == pass);
            if (validar != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Error critico");
            }
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
