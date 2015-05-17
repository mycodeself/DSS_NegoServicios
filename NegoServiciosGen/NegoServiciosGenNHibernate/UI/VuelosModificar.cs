using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class VuelosModificar : Form
    {
        VuelosVer form;
        VueloEN vuelo;
        public VuelosModificar(VuelosVer f,VueloEN vuelo_a_modificar)
        {
            InitializeComponent();
            form = f;
            vuelo = vuelo_a_modificar;
        }

        private void VuelosModificar_Load(object sender, EventArgs e)
        {

        }

        private void Confirmar_button_Click(object sender, EventArgs e)
        {
            try
            {
                String errores=comprobar();
                if (errores == "")
                {
                    VueloCEN cen = new VueloCEN();
                    AerolineaCAD aux = new AerolineaCAD();
                    AerolineaEN aero = aux.ReadByNombre(Aerolinea_tb.Text);
                    //TODO Modify
                    form.refreshData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errores);
                }
            }
            catch (NegoServiciosGenNHibernate.Exceptions.DataLayerException)
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private String comprobar()
        {
            String resultado = "";

            return resultado;
        }
    }
}
