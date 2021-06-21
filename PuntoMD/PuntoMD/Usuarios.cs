using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

using System.Data.SqlClient;

namespace PuntoMD
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeloInserta inserta = new ModeloInserta();
            var validInserta = inserta.insertaUsuario(txtnombre.Text, textlogin.Text, txtpass.Text, comboBox1.Text);
            panel5.Visible = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }
    }
}
