using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;
using NegoServiciosGenNHibernate.CEN.NegoServicios;

namespace NegoServiciosGenNHibernate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioCAD empleado = new UsuarioCAD();
            empleado.ReadByUsuario("empleado");
            UsuarioCEN cen = new UsuarioCEN();
            cen.Login(1, "123");
            this.textBox1.Text = "OK";

        }
    }
}
