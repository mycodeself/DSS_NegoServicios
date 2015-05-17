using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class AerolineasVer : Form
    {
        public AerolineasVer()
        {
            InitializeComponent();
        }

        private void AerolineasVer_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'negoServiciosGenNHibernateDataSet.Aerolinea' Puede moverla o quitarla según sea necesario.
            this.aerolineaTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Aerolinea);
            this.refreshData();
            comboBox1.SelectedIndex = 0;
        }

        public void refreshData()
        {
            this.aerolineaTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Aerolinea);
        }

        private void addUsuario_Click(object sender, EventArgs e)
        {
            AerolineaAdd addForm = new AerolineaAdd(this);
            addForm.Show();
        }

        private void delUsuario_Click(object sender, EventArgs e)
        {
            int id = ((int)((DataRowView)this.aerolineaBindingSource.Current).Row["idAerolinea"]);
            AerolineaCEN aeroCEN = new AerolineaCEN();
            aeroCEN.Destroy(id);
            MessageBox.Show("Usuario Borrado");
            this.aerolineaTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Aerolinea);
        }

        private void updUsuario_Click(object sender, EventArgs e)
        {
            int id = ((int)((DataRowView)this.aerolineaBindingSource.Current).Row["idAerolinea"]);
            AerolineaCAD cad = new AerolineaCAD();
            AerolineaEN aero = cad.ReadOID(id);
            AerolineaModificar aerolineaForm = new AerolineaModificar(this, aero);
            aerolineaForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView.DataSource;
                if (comboBox1.SelectedItem.ToString() == "idAerolinea")
                {
                    if (textBox1.Text == "")
                    {
                        bs.Filter = "nombre LIKE '%" + textBox1.Text + "'";//trampa para que no encuentre nada y asi me vuelva a sacar todas las tuplas
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
            catch (EvaluateException ex)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView.DataSource;
                bs.Filter = comboBox1.SelectedItem.ToString() + " = null";
                dataGridView.DataSource = bs;
            }
        }
    }
}
