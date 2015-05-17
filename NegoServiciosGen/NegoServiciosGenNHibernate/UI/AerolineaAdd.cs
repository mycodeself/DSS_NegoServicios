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
    public partial class AerolineaAdd : Form
    {
        private AerolineasVer aerolineaForm;
        public AerolineaAdd(AerolineasVer aeroForm)
        {
            InitializeComponent();
            this.aerolineaForm = aeroForm;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                AerolineaCEN cen = new AerolineaCEN();
                cen.New_(aerolinea.Text);
                aerolineaForm.refreshData();
                this.Close();
            }
            catch (NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
