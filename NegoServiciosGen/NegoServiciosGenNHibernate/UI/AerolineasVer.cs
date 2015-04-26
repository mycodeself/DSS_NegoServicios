using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
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
            this.error.Text = "id seleccionado: " + ((DataRowView)this.aerolineaBindingSource.Current).Row["idAerolinea"];
            this.aerolineaTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Aerolinea);
        }
    }
}
