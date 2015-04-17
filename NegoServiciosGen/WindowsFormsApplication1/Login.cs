using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.Interfaces;


namespace NegoServiciosGenNHibernate.Interfaces
{
    public partial class login : Form
    {
        private bd basedatos;
        public login()
        {
            basedatos = new bd();
            InitializeComponent();

           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usuario_label_Click(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void entrar_button_Click(object sender, EventArgs e)
        {
            Empleados arrays = new Empleados();
            string[] empleados = arrays.getEmpleados();
            String[] contrasenias = arrays.getContrasenias();

            if (Array.IndexOf(empleados, textBox1.Text) != -1 && Array.IndexOf(contrasenias, textBox2.Text) != -1)
            {

                InterfazEmpleado interfaz = new InterfazEmpleado(this,basedatos);
                interfaz.Show();
                this.Hide();
                
            }
            else
            {
                
                MessageBox.Show("incorrecto");
            }
            
        }
    }
}
