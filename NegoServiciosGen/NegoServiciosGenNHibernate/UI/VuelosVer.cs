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
    public partial class VuelosVer : Form
    {
        public VuelosVer()
        {
            InitializeComponent();
        }

        private void VerVuelos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'negoServiciosGenNHibernateDataSet.Vuelo' Puede moverla o quitarla según sea necesario.
            this.vueloTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Vuelo);
            this.refreshData();
            comboBox1.SelectedIndex = 0;
        }
        public void refreshData()
        {
            this.vueloTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Vuelo);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                if (comboBox1.SelectedItem.ToString() == "idVuelo")
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
                dataGridView1.DataSource = bs;
            }
            catch (EvaluateException ex)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                bs.Filter = comboBox1.SelectedItem.ToString() + " = null";
                dataGridView1.DataSource = bs;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VuelosAdd vAdd = new VuelosAdd(this);
            vAdd.Show();
        }
    }
}
