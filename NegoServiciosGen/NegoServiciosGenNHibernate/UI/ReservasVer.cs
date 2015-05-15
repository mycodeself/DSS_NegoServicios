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
    public partial class ReservasVer : Form
    {
        public ReservasVer()
        {
            InitializeComponent();
        }

        private void ReservasVer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'negoServiciosGenNHibernateDataSet.Reserva' Puede moverla o quitarla según sea necesario.
            this.reservaTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Reserva);
            this.refreshData();
            comboBox1.SelectedIndex = 0;
        }
        public void refreshData()
        {
            this.reservaTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Reserva);
        }
        private void addUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                if (comboBox1.SelectedItem.ToString() == "idReserva")
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
    }
}
