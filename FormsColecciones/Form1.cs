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
            try
            {
                Cliente cliente = (Cliente)clientes[Indice++];

                if( cliente.Nombre == ""  )
                {
                    throw new ApplicationException("Se debe agregar un cliente");
                }


                txtbNombre.Text = cliente.Nombre;
                txtbTelfono.Text = cliente.Telefono;
                txtbEdad.Text = cliente.Edad;
                txtbDireccion.Text = cliente.Direccion;
            }            
            catch(ArgumentOutOfRangeException  error )
            {
                MessageBox.Show("No hay ningún cliente agregado \n" + error.Message);
            }
            catch(ApplicationException error   )
            {
                MessageBox.Show("No se deben almacenar campos vacíos\n" + error.Message );
                clientes.RemoveAt(Indice--);
            }

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
