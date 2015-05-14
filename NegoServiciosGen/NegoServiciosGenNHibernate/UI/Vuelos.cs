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
    public partial class Vuelos : Form
    {
        public Vuelos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'negoServiciosGenNHibernateDataSet.Vuelo' table. You can move, or remove it, as needed.
            this.vueloTableAdapter.Fill(this.negoServiciosGenNHibernateDataSet.Vuelo);

        }
    }
}
