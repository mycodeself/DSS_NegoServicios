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
            string user = userText.Text;
            string pass = passText.Text;
            UsuarioCEN usuarioCEN = new UsuarioCEN();
            if (validateLogin(user, pass))
            {
                if (usuarioCEN.Login(userText.Text, passText.Text))
                {
                    MainEmpleado emp = new MainEmpleado();
                    emp.Location = this.Location;
                    emp.StartPosition = FormStartPosition.Manual;
                    emp.FormClosing += delegate { this.Show(); };
                    emp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                }
            }
        }

        private bool validateLogin(string user, string pass)
        {
            if (user.Equals("") || pass.Equals(""))
            {
                MessageBox.Show("Debe introducir un usuario y una contraseña");
                return false;
            }
            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
