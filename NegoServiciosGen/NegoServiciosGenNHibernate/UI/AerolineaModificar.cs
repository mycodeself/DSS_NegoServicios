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

namespace NegoServiciosGenNHibernate.UI
{
    public partial class AerolineaModificar : Form
    {
        AerolineaEN aerolineaEN;
        AerolineasVer aerolineasForm;
        public AerolineaModificar(AerolineasVer form, AerolineaEN aero)
        {
            InitializeComponent();
            this.aerolineaEN = aero;
            this.aerolineasForm = form;
        }

        private void AerolineaModificar_Load(object sender, EventArgs e)
        {
            this.aerolinea.Text = aerolineaEN.Nombre;
        }
        private void submit_Click(object sender, EventArgs e)
        {
            if (!aerolinea.Text.Equals(""))
            {
                aerolineaEN.Nombre = aerolinea.Text;
                AerolineaCAD cad = new AerolineaCAD();
                cad.Modify(aerolineaEN);
                aerolineasForm.refreshData();
                this.Close();
            }
            else
            {
                MessageBox.Show("El nombre de la aerolinea no puede estar vacio");
            }
        }

        private void error_Click(object sender, EventArgs e)
        {

        }

    }
}
