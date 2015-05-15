namespace NegoServiciosGenNHibernate.UI
{
    partial class Vuelos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_vuelos = new System.Windows.Forms.DataGridView();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negoServiciosGenNHibernateDataSet = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSet();
            this.vueloTableAdapter = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSetTableAdapters.VueloTableAdapter();
            this.label_vuelo = new System.Windows.Forms.Label();
            this.id_vuelo_textbox = new System.Windows.Forms.TextBox();
            this.idVueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechasalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechallegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horallegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioplazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vuelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_vuelos
            // 
            this.dataGridView_vuelos.AutoGenerateColumns = false;
            this.dataGridView_vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_vuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVueloDataGridViewTextBoxColumn,
            this.origenDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.fechasalidaDataGridViewTextBoxColumn,
            this.fechallegadaDataGridViewTextBoxColumn,
            this.horasalidaDataGridViewTextBoxColumn,
            this.horallegadaDataGridViewTextBoxColumn,
            this.plazasDataGridViewTextBoxColumn,
            this.precioplazaDataGridViewTextBoxColumn,
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn});
            this.dataGridView_vuelos.DataSource = this.vueloBindingSource;
            this.dataGridView_vuelos.Location = new System.Drawing.Point(12, 58);
            this.dataGridView_vuelos.Name = "dataGridView_vuelos";
            this.dataGridView_vuelos.Size = new System.Drawing.Size(1042, 250);
            this.dataGridView_vuelos.TabIndex = 0;
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataMember = "Vuelo";
            this.vueloBindingSource.DataSource = this.negoServiciosGenNHibernateDataSet;
            // 
            // negoServiciosGenNHibernateDataSet
            // 
            this.negoServiciosGenNHibernateDataSet.DataSetName = "NegoServiciosGenNHibernateDataSet";
            this.negoServiciosGenNHibernateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueloTableAdapter
            // 
            this.vueloTableAdapter.ClearBeforeFill = true;
            // 
            // label_vuelo
            // 
            this.label_vuelo.AutoSize = true;
            this.label_vuelo.Location = new System.Drawing.Point(9, 20);
            this.label_vuelo.Name = "label_vuelo";
            this.label_vuelo.Size = new System.Drawing.Size(101, 13);
            this.label_vuelo.TabIndex = 1;
            this.label_vuelo.Text = "Introduzca ID Vuelo";
            // 
            // id_vuelo_textbox
            // 
            this.id_vuelo_textbox.Location = new System.Drawing.Point(135, 17);
            this.id_vuelo_textbox.Name = "id_vuelo_textbox";
            this.id_vuelo_textbox.Size = new System.Drawing.Size(100, 20);
            this.id_vuelo_textbox.TabIndex = 2;
            // 
            // idVueloDataGridViewTextBoxColumn
            // 
            this.idVueloDataGridViewTextBoxColumn.DataPropertyName = "idVuelo";
            this.idVueloDataGridViewTextBoxColumn.HeaderText = "idVuelo";
            this.idVueloDataGridViewTextBoxColumn.Name = "idVueloDataGridViewTextBoxColumn";
            this.idVueloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // origenDataGridViewTextBoxColumn
            // 
            this.origenDataGridViewTextBoxColumn.DataPropertyName = "origen";
            this.origenDataGridViewTextBoxColumn.HeaderText = "origen";
            this.origenDataGridViewTextBoxColumn.Name = "origenDataGridViewTextBoxColumn";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // fechasalidaDataGridViewTextBoxColumn
            // 
            this.fechasalidaDataGridViewTextBoxColumn.DataPropertyName = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.HeaderText = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.Name = "fechasalidaDataGridViewTextBoxColumn";
            // 
            // fechallegadaDataGridViewTextBoxColumn
            // 
            this.fechallegadaDataGridViewTextBoxColumn.DataPropertyName = "fecha_llegada";
            this.fechallegadaDataGridViewTextBoxColumn.HeaderText = "fecha_llegada";
            this.fechallegadaDataGridViewTextBoxColumn.Name = "fechallegadaDataGridViewTextBoxColumn";
            // 
            // horasalidaDataGridViewTextBoxColumn
            // 
            this.horasalidaDataGridViewTextBoxColumn.DataPropertyName = "hora_salida";
            this.horasalidaDataGridViewTextBoxColumn.HeaderText = "hora_salida";
            this.horasalidaDataGridViewTextBoxColumn.Name = "horasalidaDataGridViewTextBoxColumn";
            // 
            // horallegadaDataGridViewTextBoxColumn
            // 
            this.horallegadaDataGridViewTextBoxColumn.DataPropertyName = "hora_llegada";
            this.horallegadaDataGridViewTextBoxColumn.HeaderText = "hora_llegada";
            this.horallegadaDataGridViewTextBoxColumn.Name = "horallegadaDataGridViewTextBoxColumn";
            // 
            // plazasDataGridViewTextBoxColumn
            // 
            this.plazasDataGridViewTextBoxColumn.DataPropertyName = "plazas";
            this.plazasDataGridViewTextBoxColumn.HeaderText = "plazas";
            this.plazasDataGridViewTextBoxColumn.Name = "plazasDataGridViewTextBoxColumn";
            // 
            // precioplazaDataGridViewTextBoxColumn
            // 
            this.precioplazaDataGridViewTextBoxColumn.DataPropertyName = "precio_plaza";
            this.precioplazaDataGridViewTextBoxColumn.HeaderText = "precio_plaza";
            this.precioplazaDataGridViewTextBoxColumn.Name = "precioplazaDataGridViewTextBoxColumn";
            // 
            // fKidAerolineaidAerolineaDataGridViewTextBoxColumn
            // 
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn.DataPropertyName = "FK_idAerolinea_idAerolinea";
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn.HeaderText = "idAerolinea";
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn.Name = "fKidAerolineaidAerolineaDataGridViewTextBoxColumn";
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 309);
            this.Controls.Add(this.id_vuelo_textbox);
            this.Controls.Add(this.label_vuelo);
            this.Controls.Add(this.dataGridView_vuelos);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vuelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_vuelos;
        private NegoServiciosGenNHibernateDataSet negoServiciosGenNHibernateDataSet;
        private System.Windows.Forms.BindingSource vueloBindingSource;
        private NegoServiciosGenNHibernateDataSetTableAdapters.VueloTableAdapter vueloTableAdapter;
        private System.Windows.Forms.Label label_vuelo;
        private System.Windows.Forms.TextBox id_vuelo_textbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVueloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechallegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horallegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioplazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidAerolineaidAerolineaDataGridViewTextBoxColumn;
    }
}