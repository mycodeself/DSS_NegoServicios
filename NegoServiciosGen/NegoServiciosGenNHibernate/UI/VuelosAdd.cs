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
using System.Text.RegularExpressions;

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
                    AerolineaCAD aux = new AerolineaCAD();
                    AerolineaEN aero = aux.ReadByNombre(Aerolinea_tb.Text);
                    try
                    {
                        cen.New_(aero.Id, Origen_tb.Text, Destino_tb.Text, Fsalida_date.Value, Fllegada_date.Value, Hsalida_date.Value, Hllegada_date.Value, Convert.ToInt32(Plazas_tb.Text), Convert.ToInt32(Precio_tb.Text));
                        vuelos.refreshData();
                    }
                    catch (FormatException ex)
                    {
                        errores = errores + " Las plazas y el precio solo pueden ser carácteres numéricos (0-9).";
                        MessageBox.Show(errores);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errores);
                }
            }
            catch (NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex2)
            {
                MessageBox.Show("Aerolinea no encontrada.");
            }

        }
        private String compruebaDatos()
        {
            Regex numeros=new Regex("^[0-9]");
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
                    s = s + "No se encuentra la aerolinea indicada.\n";
                }
                if (!numeros.IsMatch(Plazas_tb.Text) && Convert.ToInt32(Plazas_tb.Text) > 0)
                {
                    s = s + "Las plazas deben ser un número mayor que 0.\n";
                }
                if (!numeros.IsMatch(Precio_tb.Text) && Convert.ToInt32(Precio_tb.Text)>0)
                {
                    s = s + "El precio debe ser un numero mayor que 0.";
                }
            }

            return s;
        }

        private void VuelosAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
