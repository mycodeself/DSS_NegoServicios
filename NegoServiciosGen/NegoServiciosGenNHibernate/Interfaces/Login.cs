using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CAD.NegoServicios;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.Interfaces;

namespace NegoServiciosGenNHibernate.Interfaces
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            String user;
            String pass;
            user = this.textBox1.Text;
            pass = this.textBox2.Text;

            UsuarioCEN usuarioCEN = new UsuarioCEN();
            if (usuarioCEN.Login(user, pass))
            {
                InterfazEmpleado ui = new InterfazEmpleado();
                ui.Show();
            }
        }

    }
}
