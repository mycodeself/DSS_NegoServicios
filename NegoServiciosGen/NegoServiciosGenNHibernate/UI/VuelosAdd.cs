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
    public partial class VuelosAdd : Form
    {
        private DateTime? FSalida_tb;
        private VuelosVer vuelos;
        public VuelosAdd(VuelosVer v)
        {
            InitializeComponent();
            vuelos = v;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String errores = compruebaDatos();
                if (errores == "")
                {
                    VueloCEN cen = new VueloCEN();
                    AerolineaCAD aux= new AerolineaCAD();
                    AerolineaEN aero=aux.ReadByNombre(Aerolinea_tb.Text);
                    cen.New_(aero.Id, Origen_tb.Text, Destino_tb.Text, Fsalida_date.Value,Fllegada_date.Value,Hsalida_date.Value, Hllegada_date.Value,Convert.ToInt32(Plazas_tb.Text),Convert.ToInt32(Precio_tb.Text));
                    vuelos.refreshData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errores);
                }
            }
            catch(NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private String compruebaDatos()
        {

            AerolineaCAD aerolineas = new AerolineaCAD();
            String s = "";


            if (Origen_tb.Text == "" || Destino_tb.Text == "")
            {
                s = s + "Debe rellenar origen y destino.";
            }
            else
            {
                if (Fsalida_date.Value > Fllegada_date.Value)
                {
                    s = s + "La fecha de salida no puede ser posterior a la de llegada.\n";
                }
                try
                {
                    aerolineas.ReadByNombre(Aerolinea_tb.Text);
                }
                catch (NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
                {
                    s = s + "No se encuentra la aerolinea indicada.";
                }
            }

            return s;
        }
    }
}
