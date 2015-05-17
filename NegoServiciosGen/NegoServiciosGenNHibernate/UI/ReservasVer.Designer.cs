namespace NegoServiciosGenNHibernate.UI
{
    partial class ReservasVer
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
            this.idReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidUsuarioidClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKidVueloidVueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negoServiciosGenNHibernateDataSet = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSet();
            this.reservaTableAdapter = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSetTableAdapters.ReservaTableAdapter();
            this.addUsuario = new System.Windows.Forms.Button();
            this.updUsuario = new System.Windows.Forms.Button();
            this.delUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservaDataGridViewTextBoxColumn,
            this.plazasDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.fKidUsuarioidClienteDataGridViewTextBoxColumn,
            this.fKidVueloidVueloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // idReservaDataGridViewTextBoxColumn
            // 
            this.idReservaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idReservaDataGridViewTextBoxColumn.DataPropertyName = "idReserva";
            this.idReservaDataGridViewTextBoxColumn.HeaderText = "idReserva";
            this.idReservaDataGridViewTextBoxColumn.Name = "idReservaDataGridViewTextBoxColumn";
            this.idReservaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plazasDataGridViewTextBoxColumn
            // 
            this.plazasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plazasDataGridViewTextBoxColumn.DataPropertyName = "plazas";
            this.plazasDataGridViewTextBoxColumn.HeaderText = "plazas";
            this.plazasDataGridViewTextBoxColumn.Name = "plazasDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // fKidUsuarioidClienteDataGridViewTextBoxColumn
            // 
            this.fKidUsuarioidClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fKidUsuarioidClienteDataGridViewTextBoxColumn.DataPropertyName = "FK_idUsuario_idCliente";
            this.fKidUsuarioidClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.fKidUsuarioidClienteDataGridViewTextBoxColumn.Name = "fKidUsuarioidClienteDataGridViewTextBoxColumn";
            // 
            // fKidVueloidVueloDataGridViewTextBoxColumn
            // 
            this.fKidVueloidVueloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fKidVueloidVueloDataGridViewTextBoxColumn.DataPropertyName = "FK_idVuelo_idVuelo";
            this.fKidVueloidVueloDataGridViewTextBoxColumn.HeaderText = "idVuelo";
            this.fKidVueloidVueloDataGridViewTextBoxColumn.Name = "fKidVueloidVueloDataGridViewTextBoxColumn";
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.negoServiciosGenNHibernateDataSet;
            // 
            // negoServiciosGenNHibernateDataSet
            // 
            this.negoServiciosGenNHibernateDataSet.DataSetName = "NegoServiciosGenNHibernateDataSet";
            this.negoServiciosGenNHibernateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // addUsuario
            // 
            this.addUsuario.AutoSize = true;
            this.addUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addUsuario.Location = new System.Drawing.Point(12, 269);
            this.addUsuario.Name = "addUsuario";
            this.addUsuario.Size = new System.Drawing.Size(84, 38);
            this.addUsuario.TabIndex = 4;
            this.addUsuario.Text = "Añadir usuario";
            this.addUsuario.UseVisualStyleBackColor = false;
            this.addUsuario.Click += new System.EventHandler(this.addUsuario_Click);
            // 
            // updUsuario
            // 
            this.updUsuario.AutoSize = true;
            this.updUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updUsuario.Location = new System.Drawing.Point(102, 269);
            this.updUsuario.Name = "updUsuario";
            this.updUsuario.Size = new System.Drawing.Size(97, 38);
            this.updUsuario.TabIndex = 6;
            this.updUsuario.Text = "Modificar usuario";
            this.updUsuario.UseVisualStyleBackColor = false;
            this.updUsuario.Click += new System.EventHandler(this.updUsuario_Click);
            // 
            // delUsuario
            // 
            this.delUsuario.AutoSize = true;
            this.delUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.delUsuario.Location = new System.Drawing.Point(205, 269);
            this.delUsuario.Name = "delUsuario";
            this.delUsuario.Size = new System.Drawing.Size(90, 38);
            this.delUsuario.TabIndex = 7;
            this.delUsuario.Text = "Eliminar usuario";
            this.delUsuario.UseVisualStyleBackColor = false;
            this.delUsuario.Click += new System.EventHandler(this.delUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "idReserva",
            "plazas",
            "estado"});
            this.comboBox1.Location = new System.Drawing.Point(454, 279);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(642, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 21);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReservasVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delUsuario);
            this.Controls.Add(this.updUsuario);
            this.Controls.Add(this.addUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReservasVer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ReservasVer";
            this.Load += new System.EventHandler(this.ReservasVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NegoServiciosGenNHibernateDataSet negoServiciosGenNHibernateDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private NegoServiciosGenNHibernateDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private System.Windows.Forms.Button addUsuario;
        private System.Windows.Forms.Button updUsuario;
        private System.Windows.Forms.Button delUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidUsuarioidClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKidVueloidVueloDataGridViewTextBoxColumn;
    }
}