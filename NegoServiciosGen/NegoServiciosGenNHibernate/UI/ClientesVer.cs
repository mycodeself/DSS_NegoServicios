using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ClientesVer : Form
    {
        public ClientesVer()
        {
            InitializeComponent();

        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'negoServiciosGenNHibernateDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Cliente);

            this.refreshData();
        }

        private void updUsuario_Click(object sender, EventArgs e)
        {
            int id = ((int)((DataRowView)this.clienteBindingSource.Current).Row["idUsuario"]);
            ClienteCAD cad = new ClienteCAD();
            ClienteEN cliente = cad.ReadOIDDefault(id);
            ClienteModificar modificarForm = new ClienteModificar(this, cliente);
            modificarForm.Show();
        }

        private void delUsuario_Click(object sender, EventArgs e)
        {
            int id = ((int)((DataRowView)this.clienteBindingSource.Current).Row["idUsuario"]);
            ClienteCEN cliCEN = new ClienteCEN();
            cliCEN.Destroy(id);
            this.error.Text = "id seleccionado: "+((DataRowView)this.clienteBindingSource.Current).Row["idUsuario"];
            this.clienteTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Cliente);
        }
        public void refreshData()
        {
            this.clienteTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Cliente);
        }

        private void addUsuario_Click(object sender, EventArgs e)
        {
            ClienteAdd addForm = new ClienteAdd(this);
            addForm.Show();
        }

    }
}
