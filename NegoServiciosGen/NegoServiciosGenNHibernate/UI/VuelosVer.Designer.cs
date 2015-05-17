namespace NegoServiciosGenNHibernate.UI
{
    partial class VuelosVer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negoServiciosGenNHibernateDataSet = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSet();
            this.vueloTableAdapter = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSetTableAdapters.VueloTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.vueloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(12, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Añadir vuelo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(108, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar vuelo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(203, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar vuelo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "idVuelo",
            "origen",
            "destino",
            "fecha_salida",
            "fecha_llegada",
            "hora_salida",
            "hora_llegada",
            "plazas"});
            this.comboBox1.Location = new System.Drawing.Point(475, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(663, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 21);
            this.button4.TabIndex = 14;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn.DataPropertyName = "idAerolinea";
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn.HeaderText = "idAerolinea";
            this.fKidAerolineaidAerolineaDataGridViewTextBoxColumn.Name = "fKidAerolineaidAerolineaDataGridViewTextBoxColumn";
            // 
            // VuelosVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 333);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VuelosVer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VerVuelos";
            this.Load += new System.EventHandler(this.VerVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NegoServiciosGenNHibernateDataSet negoServiciosGenNHibernateDataSet;
        private System.Windows.Forms.BindingSource vueloBindingSource;
        private NegoServiciosGenNHibernateDataSetTableAdapters.VueloTableAdapter vueloTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
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