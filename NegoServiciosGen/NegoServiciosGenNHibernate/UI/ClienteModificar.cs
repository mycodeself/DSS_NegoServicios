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
    public partial class ClienteModificar : Form
    {
        ClientesVer clientesVerForm;
        ClienteEN cliente;
        public ClienteModificar(ClientesVer form, ClienteEN cli)
        {
            InitializeComponent();
            clientesVerForm = form;
            cliente = cli;
        }

        private void ClienteModificar_Load(object sender, EventArgs e)
        {
            this.usuario.Text = cliente.Usuario;
            this.password.Text = cliente.Password;
            this.email.Text = cliente.Email;
            this.dni.Text = cliente.DNI;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String errores = compruebaDatos();
            if (errores == "")
            {
                cliente.Usuario = this.usuario.Text;
                cliente.Password = this.password.Text;
                cliente.Email = this.email.Text;
                cliente.DNI = this.dni.Text;
                ClienteCAD cad = new ClienteCAD();
                cad.Modify(cliente);
                clientesVerForm.refreshData();
            }
            else
            {
                MessageBox.Show(errores);
            }

            this.Close();
        }
        private String compruebaDatos()
        {
            Regex nomb = new Regex("^[a-zA-Z0-9]");
            Regex correo = new Regex("(@)(.+)$");
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
