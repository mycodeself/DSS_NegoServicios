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
    public partial class modificarCliente1 : Form
    {
        private bd basedatos;
        public modificarCliente1()
        {
            InitializeComponent();
        }
        public modificarCliente1(bd basedatos)
        {
            InitializeComponent();
            this.basedatos = basedatos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool contador = false;
            List<Cliente> lista=basedatos.getClientes();
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
                        modificarCliente2 m = new modificarCliente2(basedatos, i);
                        m.Show();
                        this.Hide();
                        break;
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
