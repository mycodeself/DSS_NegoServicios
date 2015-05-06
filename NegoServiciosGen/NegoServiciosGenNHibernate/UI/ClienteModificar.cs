using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ClienteModificar : Form
    {
        ClientesVer clientesVerForm;
        ClienteEN cliente;
        public ClienteModificar(ClientesVer form, ClienteEN cli)
        {
            InitializeComponent();
            clientesVerForm = form;
            cliente = cli;
        }

        private void ClienteModificar_Load(object sender, EventArgs e)
        {
            this.usuario.Text = cliente.Usuario;
            this.password.Text = cliente.Password;
            this.email.Text = cliente.Email;
            this.dni.Text = cliente.DNI;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            cliente.Usuario = this.usuario.Text;
            cliente.Password = this.password.Text;
            cliente.Email = this.email.Text;
            cliente.DNI = this.dni.Text;
            ClienteCAD cad = new ClienteCAD();
            cad.Modify(cliente);
            clientesVerForm.refreshData();
            this.Close();
        }
    }
}
