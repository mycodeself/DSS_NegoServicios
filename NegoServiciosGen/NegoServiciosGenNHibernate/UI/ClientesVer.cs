using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ClientesVer : Form
    {
        public ClientesVer()
        {
            InitializeComponent();

        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'negoServiciosGenNHibernateDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Cliente);
            this.refreshData();
            comboBox1.SelectedIndex = 0;
        }

        private void updUsuario_Click(object sender, EventArgs e)
        {
            int id = ((int)((DataRowView)this.clienteBindingSource.Current).Row["idUsuario"]);
            ClienteCAD cad = new ClienteCAD();
            ClienteEN cliente = cad.ReadOIDDefault(id);
            ClienteModificar modificarForm = new ClienteModificar(this, cliente);
            modificarForm.Show();
        }

        private void delUsuario_Click(object sender, EventArgs e)
        {
            int id = ((int)((DataRowView)this.clienteBindingSource.Current).Row["idUsuario"]);
            ClienteCEN cliCEN = new ClienteCEN();
            cliCEN.Destroy(id);
            MessageBox.Show("id seleccionado: " + ((DataRowView)this.clienteBindingSource.Current).Row["idUsuario"]);
            this.clienteTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Cliente);
        }
        public void refreshData()
        {
            this.clienteTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Cliente);
        }

        private void addUsuario_Click(object sender, EventArgs e)
        {
            ClienteAdd addForm = new ClienteAdd(this);
            addForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView.DataSource;
                if (comboBox1.SelectedItem.ToString() == "IdUsuario")
                {
                    if (textBox1.Text == "")
                    {
                        bs.Filter = "usuario LIKE '%" + textBox1.Text + "'";//trampa para que no encuentre nada y asi me vuelva a sacar todas las tuplas
                    }
                    else
                    {
                        bs.Filter = comboBox1.SelectedItem.ToString() + " = '" + textBox1.Text + "'";
                    }
                }
                else
                {
                    bs.Filter = comboBox1.SelectedItem.ToString() + " LIKE '%" + textBox1.Text + "'";
                }
                dataGridView.DataSource = bs;
            }
            catch(EvaluateException ex)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView.DataSource;
                bs.Filter = comboBox1.SelectedItem.ToString() + " = null";
                dataGridView.DataSource = bs;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
