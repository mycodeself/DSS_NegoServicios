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
using NegoServiciosGenNHibernate.Enumerated.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ReservasAdd : Form
    {
        ReservasVer reservas_form;
        public ReservasAdd(ReservasVer form)
        {
            InitializeComponent();
            reservas_form = form;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmar_button_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaCEN cen = new ReservaCEN();
                string aux_estado=estado_textbox.Text,aux_id_cliente,aux_id_vuelo,aux_plazas,validacion;
                EstadoReservaEnum estado;
                try
                {
                    estado = (EstadoReservaEnum)Enum.Parse(typeof(EstadoReservaEnum), aux_estado);
                    aux_id_cliente = this.id_cliente_textbox.Text;
                    aux_id_vuelo = this.id_vuelo_textbox.Text;
                    aux_plazas = this.plazas_textbox.Text;
                    validacion = validar(aux_id_cliente, aux_id_vuelo, aux_plazas, estado);
                    if (validacion == "")
                    {
                        cen.New_(Convert.ToInt32(aux_id_cliente), Convert.ToInt32(aux_id_vuelo), Convert.ToInt32(aux_plazas), estado);
                        reservas_form.refreshData();
                    }
                    else
                    {
                        MessageBox.Show(validacion);
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Error, tipo de estado incorrecto :"+ex);
                }
            }
            catch (NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string validar(string id_cliente, string id_vuelo, string plazas, EstadoReservaEnum estado)
        {
            string validacion = "";
            ClienteCAD cad_cliente = new ClienteCAD();
            VueloCAD cad_vuelo = new VueloCAD();
            try
            {
                ClienteEN cliente = new ClienteEN(cad_cliente.ReadOIDDefault(Convert.ToInt32(id_cliente)));
                VueloEN vuelo = new VueloEN((cad_vuelo.ReadOIDDefault(Convert.ToInt32(id_vuelo))));
                if (Convert.ToInt32(plazas) > vuelo.Plazas)
                {
                    validacion = "Número de plazas a reservar incorrecto";
                }
                else
                {
                    vuelo.Plazas = vuelo.Plazas - Convert.ToInt32(plazas);
                    cad_vuelo.Modify(vuelo);
                }
            }
            catch(NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
            {
                validacion = "Cliente ID y Vuelo ID incorrectos:"+ex + "\n";
            }
            return validacion;
        }
    }
}
