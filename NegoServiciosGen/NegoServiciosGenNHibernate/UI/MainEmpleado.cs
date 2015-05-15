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
        VuelosVer vuelosForm;
        ReservasVer reservasForm;

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
                else if (vuelosForm != null)
                {
                    vuelosForm.Close();
                    vuelosForm = null;
                }
                else if (reservasForm != null)
                {
                    reservasForm.Close();
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
                else if (vuelosForm != null)
                {
                    vuelosForm.Close();
                    vuelosForm = null;
                }
                else if (reservasForm != null)
                {
                    reservasForm.Close();
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

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goVuelos_Click(object sender, EventArgs e)
        {
            if (vuelosForm == null)
            {
                this.header.Text = "VUELOS";
                this.header.Visible = true;
                if (aerolineasForm != null)
                {
                    aerolineasForm.Close();
                    aerolineasForm = null;
                }
                else if (clientesForm != null)
                {
                    clientesForm.Close();
                    clientesForm = null;
                }
                else if (reservasForm != null)
                {
                    reservasForm.Close();
                    reservasForm = null;
                }
                vuelosForm = new VuelosVer();
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
                if(aerolineasForm!=null)
                {
                    aerolineasForm.Close();
                    aerolineasForm = null;
                }
                else if (vuelosForm != null)
                {
                    vuelosForm.Close();
                    vuelosForm = null;
                }
                else if (clientesForm != null)
                {
                    clientesForm.Close();
                    clientesForm = null;
                }
                reservasForm = new ReservasVer();
                reservasForm.TopLevel = false;
                
                this.container.Controls.Add(reservasForm);
                reservasForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                reservasForm.Dock = DockStyle.Fill;
                reservasForm.Show();

            }


        }

    }
}
