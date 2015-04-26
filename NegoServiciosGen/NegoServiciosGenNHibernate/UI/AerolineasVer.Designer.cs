namespace NegoServiciosGenNHibernate.UI
{
    partial class AerolineasVer
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idAerolineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerolineaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negoServiciosGenNHibernateDataSet = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSet();
            this.aerolineaTableAdapter = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSetTableAdapters.AerolineaTableAdapter();
            this.error = new System.Windows.Forms.Label();
            this.updUsuario = new System.Windows.Forms.Button();
            this.delUsuario = new System.Windows.Forms.Button();
            this.addUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAerolineaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.aerolineaBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(740, 271);
            this.dataGridView.TabIndex = 0;
            // 
            // idAerolineaDataGridViewTextBoxColumn
            // 
            this.idAerolineaDataGridViewTextBoxColumn.DataPropertyName = "idAerolinea";
            this.idAerolineaDataGridViewTextBoxColumn.HeaderText = "idAerolinea";
            this.idAerolineaDataGridViewTextBoxColumn.Name = "idAerolineaDataGridViewTextBoxColumn";
            this.idAerolineaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAerolineaDataGridViewTextBoxColumn.Width = 349;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 348;
            // 
            // aerolineaBindingSource
            // 
            this.aerolineaBindingSource.DataMember = "Aerolinea";
            this.aerolineaBindingSource.DataSource = this.negoServiciosGenNHibernateDataSet;
            // 
            // negoServiciosGenNHibernateDataSet
            // 
            this.negoServiciosGenNHibernateDataSet.DataSetName = "NegoServiciosGenNHibernateDataSet";
            this.negoServiciosGenNHibernateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aerolineaTableAdapter
            // 
            this.aerolineaTableAdapter.ClearBeforeFill = true;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(337, 296);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(29, 13);
            this.error.TabIndex = 10;
            this.error.Text = "Error";
            // 
            // updUsuario
            // 
            this.updUsuario.AutoSize = true;
            this.updUsuario.Location = new System.Drawing.Point(120, 283);
            this.updUsuario.Name = "updUsuario";
            this.updUsuario.Size = new System.Drawing.Size(106, 38);
            this.updUsuario.TabIndex = 9;
            this.updUsuario.Text = "Modificar aerolinea";
            this.updUsuario.UseVisualStyleBackColor = true;
            // 
            // delUsuario
            // 
            this.delUsuario.AutoSize = true;
            this.delUsuario.Location = new System.Drawing.Point(232, 283);
            this.delUsuario.Name = "delUsuario";
            this.delUsuario.Size = new System.Drawing.Size(99, 38);
            this.delUsuario.TabIndex = 8;
            this.delUsuario.Text = "Eliminar aerolinea";
            this.delUsuario.UseVisualStyleBackColor = true;
            this.delUsuario.Click += new System.EventHandler(this.delUsuario_Click);
            // 
            // addUsuario
            // 
            this.addUsuario.AutoSize = true;
            this.addUsuario.Location = new System.Drawing.Point(21, 283);
            this.addUsuario.Name = "addUsuario";
            this.addUsuario.Size = new System.Drawing.Size(93, 38);
            this.addUsuario.TabIndex = 7;
            this.addUsuario.Text = "Añadir aerolinea";
            this.addUsuario.UseVisualStyleBackColor = true;
            this.addUsuario.Click += new System.EventHandler(this.addUsuario_Click);
            // 
            // AerolineasVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(740, 333);
            this.ControlBox = false;
            this.Controls.Add(this.error);
            this.Controls.Add(this.updUsuario);
            this.Controls.Add(this.delUsuario);
            this.Controls.Add(this.addUsuario);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AerolineasVer";
            this.Text = "AerolineasVer";
            this.Load += new System.EventHandler(this.AerolineasVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aerolineaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private NegoServiciosGenNHibernateDataSet negoServiciosGenNHibernateDataSet;
        private System.Windows.Forms.BindingSource aerolineaBindingSource;
        private NegoServiciosGenNHibernateDataSetTableAdapters.AerolineaTableAdapter aerolineaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAerolineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button updUsuario;
        private System.Windows.Forms.Button delUsuario;
        private System.Windows.Forms.Button addUsuario;
    }
}