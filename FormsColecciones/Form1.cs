using System;
using System.Collections;
using System.Windows.Forms;

namespace FormsColecciones
{
    public partial class Form1 : Form
    {
        ArrayList clientes;

        public Form1()
        {
            InitializeComponent();
            clientes = new ArrayList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clientes.Add(new Cliente(txtbNombre.Text, txtbTelfono.Text, txtbEdad.Text, txtbDireccion.Text));
            txtbNombre.Clear();
            txtbTelfono.Clear();
            txtbEdad.Clear();
            txtbDireccion.Clear();
        }
    }
}
