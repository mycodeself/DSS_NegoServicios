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
        public MainEmpleado()
        {
            InitializeComponent();
        }

        private void goClientes_Click(object sender, EventArgs e)
        {
            this.header.Text = "CLIENTES";
            this.header.Visible = true;
            ClientesVer cli = new ClientesVer();
            cli.TopLevel = false;
            this.container.Controls.Add(cli);
            cli.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cli.Dock = DockStyle.Fill;
            cli.Show();
        }

    }
}
