using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using NegoServiciosGenNHibernate.Enumerated.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ReservasAdd : Form
    {
        public ReservasAdd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmar_button_Click(object sender, EventArgs e)
        {
            try
            {
                ReservaCEN cen = new ReservaCEN();
                string aux_estado=estado_textbox.Text,aux_id_cliente,aux_id_vuelo,aux_plazas;
                EstadoReservaEnum estado;
                estado = (EstadoReservaEnum)Enum.Parse(typeof(EstadoReservaEnum), aux_estado);
                aux_id_cliente = this.id_cliente_textbox.Text;
                aux_id_vuelo = this.id_vuelo_textbox.Text;
                aux_plazas = this.plazas_textbox.Text;
                cen.New_(Convert.ToInt32(aux_id_cliente),Convert.ToInt32(aux_id_vuelo),Convert.ToInt32(aux_plazas),estado);
            }
            catch (NegoServiciosGenNHibernate.Exceptions.DataLayerException ex)
            {
                //TODO
            }
        }
    }
}
