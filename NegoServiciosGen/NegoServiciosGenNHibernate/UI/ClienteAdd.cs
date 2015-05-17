using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NegoServiciosGenNHibernate.CEN.NegoServicios;
using System.Text.RegularExpressions;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class ClienteAdd : Form
    {
        private ClientesVer verClientesForm;
        public ClienteAdd(ClientesVer form)
        {
            InitializeComponent();
            this.verClientesForm = form;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                String errores = compruebaDatos();
                if (errores == "")
                {
                    ClienteCEN cen = new ClienteCEN();
                    cen.New_(this.usuario.Text, this.password.Text, this.email.Text, this.dni.Text);
                    verClientesForm.refreshData();
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
            Regex nomb = new Regex("^[a-zA-Z0-9]");
            Regex correo= new Regex ("(@)(.+)$");
            String s = "";

            if (usuario.Text == "" || password.Text == "" || email.Text == "" || dni.TextLength == 0)
            {
                s = s + "Rellene todos los campos.";
            }
            else
            {
                if (!nomb.IsMatch(usuario.Text))
                {
                    s = s + "Nombre de Usuario incorrecto. Utilice solo carácteres alfanuméricos.\n";
                }
                if (!correo.IsMatch(email.Text))
                {
                    s = s + "Formato de direccion de correo invalido.\n";
                }
                if (dni.TextLength > 9)
                {
                    s = s + "Formato de DNI/NIF invalido.";
                }
            }
            return s;
                
        }

    }
}
