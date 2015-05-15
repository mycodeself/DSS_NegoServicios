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
        Reservas reservasForm;
        Vuelos vuelosForm;

        public MainEmpleado()
        {
            InitializeComponent();
        }

        private void goClientes_Click(object sender, EventArgs e)
        {
            if (clientesForm == null)
            {
                this.header.Text = "CLIENTES";
                this.header.Visible = true;
                if (aerolineasForm != null)
                {
                    aerolineasForm.Close();
                    aerolineasForm = null;
                }
                if (reservasForm != null)
                {
                    reservasForm.Close();
                    reservasForm = null;
                }
                if (vuelosForm != null)
                {
                    vuelosForm.Close();
                    reservasForm = null;
                }
                clientesForm = new ClientesVer();
                clientesForm.TopLevel = false;
                this.container.Controls.Add(clientesForm);
                clientesForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                clientesForm.Dock = DockStyle.Fill;
                clientesForm.Show();
            }
        }

        private void goAerolineas_Click(object sender, EventArgs e)
        {
            if (aerolineasForm == null)
            {
                this.header.Text = "AEROLINEAS";
                this.header.Visible = true;
                if (clientesForm != null)
                {
                    clientesForm.Close();
                    clientesForm = null;
                }
                if (reservasForm != null)
                {
                    reservasForm.Close();
                    reservasForm = null;
                }
                if (vuelosForm != null)
                {
                    vuelosForm.Close();
                    reservasForm = null;
                }
                aerolineasForm = new AerolineasVer();
                aerolineasForm.TopLevel = false;
                this.container.Controls.Add(aerolineasForm);
                aerolineasForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                aerolineasForm.Dock = DockStyle.Fill;
                aerolineasForm.Show();
            }
        }

        private void goVuelos_Click(object sender, EventArgs e)
        {
            if (vuelosForm == null)
            {
                this.header.Text = "VUELOS";
                this.header.Visible = true;
                if (clientesForm != null)
                {
                    clientesForm.Close();
                    clientesForm = null;
                }
                if (reservasForm != null)
                {
                    reservasForm.Close();
                    reservasForm = null;
                }
                if (aerolineasForm != null)
                {
                    aerolineasForm.Close();
                    aerolineasForm = null;
                }
                vuelosForm = new Vuelos();
                vuelosForm.TopLevel = false;
                this.container.Controls.Add(vuelosForm);
                vuelosForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                vuelosForm.Dock = DockStyle.Fill;
                vuelosForm.Show();
            }
        }

        private void verReservas_Click(object sender, EventArgs e)
        {
            if (reservasForm == null)
            {
                this.header.Text = "RESERVAS";
                this.header.Visible = true;
                if (clientesForm != null)
                {
                    clientesForm.Close();
                    clientesForm = null;
                }
                if (aerolineasForm != null)
                {
                    aerolineasForm.Close();
                    aerolineasForm = null;
                }
                if (vuelosForm != null)
                {
                    vuelosForm.Close();
                    reservasForm = null;
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
}
