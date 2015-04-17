using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CAD.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CEN.NegoServicios;

namespace NegoServiciosGenNHibernate.Interfaces
{
    public partial class crearCliente : Form
    {
        private bd basedatos;
        public crearCliente()
        {
            InitializeComponent();
        }
        public crearCliente(bd basedatos)
        {
            InitializeComponent();
            this.basedatos = basedatos;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void crearCliente_Load(object sender, EventArgs e)
        {

        }

        private void dni_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Cliente c = new Cliente(usuario_text.Text, password_text.Text, email_text.Text, dni_text.Text);
            basedatos.anyadirClientes(c);
            

            List<Cliente> lista=basedatos.getClientes();
            MessageBox.Show("insertado");
            for (int i = 0; i < lista.Count; i++) // Loop with for.
            {
                MessageBox.Show("Cliente " + i + lista[i].getNombre() + " " + lista[i].getPassword() + " " + lista[i].getEmail() + " " + lista[i].getDni());
                
            }
            //IList<ReservaEN> reserva=new List<ReservaEN>();
            //ClienteCEN c = new ClienteCEN();
            //c.New_(usuario_text.Text, password_text.Text, email_text.Text, dni_text.Text);
            //ClienteEN cliente = new ClienteEN(0, dni_text.Text,reserva,usuario_text.Text, password_text.Text, email_text.Text);
            //ClienteCAD c=new ClienteCAD();
            //c.New_(cliente);
           
        }

        private void usuario_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
