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
        int i = 0;
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)clientes[i++];
            txtbNombre.Text = cliente.Nombre;
            txtbTelfono.Text = cliente.Telefono;
            txtbEdad.Text = cliente.Edad;
            txtbDireccion.Text = cliente.Direccion ;
        }
    }
}
