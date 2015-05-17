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
using System.Text.RegularExpressions;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class VuelosModificar : Form
    {
        VuelosVer form;
        VueloEN vuelo;
        public VuelosModificar(VuelosVer f,int id_vuelo)
        {
            InitializeComponent();
            form = f;
            VueloCAD cad = new VueloCAD();
            vuelo = cad.ReadOID(id_vuelo);
            origen_textbox.Text = vuelo.Origen;
            destino_textbox.Text = vuelo.Destino;
            salida_textbox.Value = vuelo.Fecha_salida.Value;
            llegada_textbox.Value = vuelo.Fecha_llegada.Value;
            hsalida_textbox.Value = vuelo.Hora_salida.Value;
            hllegada_textbox.Value = vuelo.Hora_llegada.Value;
            aerolinea_textbox.Text = vuelo.Aerolinea.Nombre;
            plazas_textbox.Text = Convert.ToString(vuelo.Plazas);
            precio_textbox.Text = Convert.ToString(vuelo.Precio_plaza);
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
                    AerolineaEN aero = aux.ReadByNombre(aerolinea_textbox.Text);
                    cen.Modify(aero.Id, origen_textbox.Text, destino_textbox.Text, salida_textbox.Value, llegada_textbox.Value, hsalida_textbox.Value, hllegada_textbox.Value, Convert.ToInt32(plazas_textbox.Text), Convert.ToInt32(precio_textbox.Text));
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
            Regex numeros = new Regex("^[0-9]+$");
            AerolineaCAD aerolineas = new AerolineaCAD();
            String s = "";


            if (origen_textbox.Text == "" || destino_textbox.Text == "")
            {
                s = s + "Debe rellenar origen y destino.";
            }
            else
            {
                if (salida_textbox.Value > llegada_textbox.Value)
                {
                    s = s + "La fecha de salida no puede ser posterior a la de llegada.\n";
                }
                try
                {
                    aerolineas.ReadByNombre(aerolinea_textbox.Text);
                }
                catch (NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
                {
                    s = s + "No se encuentra la aerolinea indicada.\n";
                }
                if (!numeros.IsMatch(plazas_textbox.Text) && Convert.ToInt32(plazas_textbox.Text) > 0)
                {
                    s = s + "Las plazas deben ser un número mayor que 0.\n";
                }
                if (!numeros.IsMatch(precio_textbox.Text) && Convert.ToInt32(precio_textbox.Text) > 0)
                {
                    s = s + "El precio debe ser un numero mayor que 0.";
                }

            }
            return s;
        }
    }
}
