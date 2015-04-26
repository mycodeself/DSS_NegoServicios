using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class MainEmpleado : Form
    {
        ClientesVer clientesForm;
        AerolineasVer aerolineasForm;

        public MainEmpleado()
        {
            InitializeComponent();
        }

        private void goClientes_Click(object sender, EventArgs e)
        {
            this.header.Text = "CLIENTES";
            this.header.Visible = true;
            if(aerolineasForm != null)
            {
                aerolineasForm.Close();
            }
            clientesForm = new ClientesVer();
            clientesForm.TopLevel = false;
            this.container.Controls.Add(clientesForm);
            clientesForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            clientesForm.Dock = DockStyle.Fill;
            clientesForm.Show();
        }

        private void goAerolineas_Click(object sender, EventArgs e)
        {
            this.header.Text = "AEROLINEAS";
            this.header.Visible = true;
            if (clientesForm != null)
            {
                clientesForm.Close();
            }
            aerolineasForm = new AerolineasVer();
            aerolineasForm.TopLevel = false;
            this.container.Controls.Add(aerolineasForm);
            aerolineasForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            aerolineasForm.Dock = DockStyle.Fill;
            aerolineasForm.Show();
        }

    }
}
