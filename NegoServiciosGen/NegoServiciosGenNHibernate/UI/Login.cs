using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorText.Text = "";
            errorText.Visible = true;
            UsuarioCEN usuarioCEN = new UsuarioCEN();
            if (usuarioCEN.Login(userText.Text, passText.Text))
            {
                MainEmpleado emp = new MainEmpleado();
                emp.Location = this.Location;
                emp.StartPosition = FormStartPosition.Manual;
                emp.FormClosing += delegate { this.Show(); };
                emp.Show();
                this.Close();
            }
            else
            {
                errorText.Text += "Error";
            }
        }
    }
}
