﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.Enumerated.NegoServicios;
using NegoServiciosGenNHibernate.EN.NegoServicios;
using NegoServiciosGenNHibernate.CAD.NegoServicios;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ReservasModificar : Form
    {
        ReservasVer reserva_form;
        ReservaEN reserva;
        public ReservasModificar(ReservasVer form,int reserva_id)
        {
            InitializeComponent();
            reserva_form = form;
            ReservaCAD cad = new ReservaCAD();
            reserva = cad.ReadOID(reserva_id);
        }

        private void estado_button_Click(object sender, EventArgs e)
        {
            string aux_estado = estados_textbox.Text;
            try
            {
                EstadoReservaEnum estado = (EstadoReservaEnum)Enum.Parse(typeof(EstadoReservaEnum), aux_estado);
                reserva.Estado = estado;
                ReservaCAD cad = new ReservaCAD();
                cad.Modify(reserva);
                reserva_form.refreshData();
                this.Close();
            }
            catch(ArgumentException ex){
                MessageBox.Show("Estado Incorrecto :"+ex.Message);
            }
        }

        private void plazas_button_Click(object sender, EventArgs e)
        {
            int plazas = Convert.ToInt32(plazas_textbox.Text);
            int p_totales = reserva.Plazas;

            if (p_totales<plazas)
            {
                MessageBox.Show("Error, número de plazas incorrecto");
            }
            else
            {
                reserva.Plazas = plazas;
                ReservaCAD cad = new ReservaCAD();
                cad.Modify(reserva);
                reserva_form.refreshData();
                this.Close();
            }
        }
    }
}
