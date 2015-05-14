using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NegoServiciosGenNHibernate.UI
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'negoServiciosGenNHibernateDataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Reserva);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
