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
    public partial class modificarCliente2 : Form
    {
        private bd basedatos;
        private int posicion;//nombre de cliente a modificar
        public modificarCliente2()
        {
            InitializeComponent();
        }
        public modificarCliente2(bd basedatos,int posicion)
        {
            InitializeComponent();
            this.basedatos = basedatos;
            this.posicion = posicion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = basedatos.getClientes();
            if (usuario_textbox.Text != "")
            {
                lista[posicion].setNombre(usuario_textbox.Text);
            }
            if (dni_textbox.Text != "")
            {
                lista[posicion].setDni(dni_textbox.Text);
            }
            if (password_textbox.Text != "")
            {
                lista[posicion].setPassword(password_textbox.Text);
            }
            if (email_textbox.Text != "")
            {
                lista[posicion].setEmail(email_textbox.Text);
            }

            
            for (int i = 0; i < lista.Count; i++) // Loop with for.
            {
                MessageBox.Show("Cliente: " + i + " " + lista[i].getNombre() + " " + lista[i].getPassword() + " " + lista[i].getEmail() + " " + lista[i].getDni());

            }
        }
    }
}
