using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NegoServiciosGenNHibernate.Interfaces
{
    
    public partial class InterfazEmpleado : Form
    {
        login l;
        private bd basedatos;
        public InterfazEmpleado(login log)
        {
            InitializeComponent();
            l = log;
        }
        public InterfazEmpleado(login log, bd basedatos)
        {
            InitializeComponent();
            l = log;
            this.basedatos = basedatos;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void interfazEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            l.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            crearCliente interfaz = new crearCliente(basedatos);
            interfaz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modificarCliente1 m = new modificarCliente1(basedatos);
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminarCliente1 elim = new eliminarCliente1(basedatos);
            elim.Show();
        }

        private void InterfazEmpleado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
