using System;
using System.Collections;
using System.Windows.Forms;

namespace FormsColecciones
{
    public partial class Form1 : Form
    {
        private ArrayList clientes;
        private int indice;

        public int Indice
        {
            get => indice;
            set
            {
                if (value < 0 || value >= clientes.Count)
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }

            }
        }

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
        

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            Cliente cliente = (Cliente)clientes[Indice++];
            txtbNombre.Text = cliente.Nombre;
            txtbTelfono.Text = cliente.Telefono;
            txtbEdad.Text = cliente.Edad;
            txtbDireccion.Text = cliente.Direccion ;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)clientes[Indice--];
            txtbNombre.Text = cliente.Nombre;
            txtbTelfono.Text = cliente.Telefono;
            txtbEdad.Text = cliente.Edad;
            txtbDireccion.Text = cliente.Direccion;

        }
    }
}
