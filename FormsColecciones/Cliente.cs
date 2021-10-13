using System;

namespace FormsColecciones
{
    class Cliente
    {
        private string nombre;
        private string telefono;
        private string edad;
        private string direccion;

        public Cliente(string nombre, string telefono, string edad, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Edad = edad;
            Direccion = direccion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
