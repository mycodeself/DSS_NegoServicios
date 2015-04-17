using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NegoServiciosGenNHibernate.Interfaces
{
    public partial class eliminarCliente1 : Form
    {
        private bd basedatos;
        public eliminarCliente1()
        {
            InitializeComponent();
        }
        public eliminarCliente1(bd basedatos)
        {
            InitializeComponent();
            this.basedatos = basedatos;
        }

        private void eliminarCliente1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool contador = false;
            List<Cliente> lista = basedatos.getClientes();
            if (lista.Count == 0)
            {
                MessageBox.Show("No hay clientes");
            }
            else
            {
                for (int i = 0; i < lista.Count; i++) // Loop with for.
                {
                    if (textBox1.Text == lista[i].getNombre())
                    {
                        contador = true;
                        MessageBox.Show("Cliente: " + lista[i].getNombre() + " eliminado");
                        basedatos.eliminarCliente(lista[i]);
                        for (int j = 0; j < lista.Count; j++) // Loop with for.
                        {
                            MessageBox.Show("Cliente: " + j + " " + lista[j].getNombre() + " " + lista[j].getPassword() + " " + lista[j].getEmail() + " " + lista[j].getDni());
                        }
                        
                    }
                }
                if (contador == false)
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
        }
    }
}
