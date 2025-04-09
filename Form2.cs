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
    public partial class LBLBienvenida : Form
    {
        Acciones acc = new Acciones();
        public LBLBienvenida()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            tablacasas.DataSource = null;
            tablacasas.DataSource = acc.
        }
    }
}
