using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CEN.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ClienteAdd : Form
    {
        private AerolineaVer verClientesForm;
        public ClienteAdd(AerolineaVer form)
        {
            InitializeComponent();
            this.verClientesForm = form;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteCEN cen = new ClienteCEN();
                cen.New_(this.usuario.Text, this.password.Text, this.email.Text, this.dni.Text);
                verClientesForm.refreshData();
                this.Close();
            }
            catch(NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
            {
                this.error.Text = ex.Message;
            }
        }

    }
}
