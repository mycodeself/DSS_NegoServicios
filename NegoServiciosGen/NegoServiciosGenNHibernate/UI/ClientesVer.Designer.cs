namespace NegoServiciosGenNHibernate.UI
{
    partial class ClientesVer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.negoServiciosGenNHibernateDataSet = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSet();
            this.addUsuario = new System.Windows.Forms.Button();
            this.delUsuario = new System.Windows.Forms.Button();
            this.updUsuario = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.usuarioDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.clienteBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(740, 277);
            this.dataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "idUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn2.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.negoServiciosGenNHibernateDataSet;
            // 
            // negoServiciosGenNHibernateDataSet
            // 
            this.negoServiciosGenNHibernateDataSet.DataSetName = "NegoServiciosGenNHibernateDataSet";
            this.negoServiciosGenNHibernateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addUsuario
            // 
            this.addUsuario.AutoSize = true;
            this.addUsuario.Location = new System.Drawing.Point(12, 283);
            this.addUsuario.Name = "addUsuario";
            this.addUsuario.Size = new System.Drawing.Size(84, 38);
            this.addUsuario.TabIndex = 3;
            this.addUsuario.Text = "Añadir usuario";
            this.addUsuario.UseVisualStyleBackColor = true;
            this.addUsuario.Click += new System.EventHandler(this.addUsuario_Click);
            // 
            // delUsuario
            // 
            this.delUsuario.AutoSize = true;
            this.delUsuario.Location = new System.Drawing.Point(205, 283);
            this.delUsuario.Name = "delUsuario";
            this.delUsuario.Size = new System.Drawing.Size(90, 38);
            this.delUsuario.TabIndex = 4;
            this.delUsuario.Text = "Eliminar usuario";
            this.delUsuario.UseVisualStyleBackColor = true;
            this.delUsuario.Click += new System.EventHandler(this.delUsuario_Click);
            // 
            // updUsuario
            // 
            this.updUsuario.AutoSize = true;
            this.updUsuario.Location = new System.Drawing.Point(102, 283);
            this.updUsuario.Name = "updUsuario";
            this.updUsuario.Size = new System.Drawing.Size(97, 38);
            this.updUsuario.TabIndex = 5;
            this.updUsuario.Text = "Modificar usuario";
            this.updUsuario.UseVisualStyleBackColor = true;
            this.updUsuario.Click += new System.EventHandler(this.updUsuario_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(302, 294);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(29, 13);
            this.error.TabIndex = 6;
            this.error.Text = "Error";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ClientesVer
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
            this.Name = "ClientesVer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "VerClientes";
            this.Load += new System.EventHandler(this.VerClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addUsuario;
        private System.Windows.Forms.Button delUsuario;
        private System.Windows.Forms.Button updUsuario;
        private System.Windows.Forms.Label error;
        private NegoServiciosGenNHibernateDataSet negoServiciosGenNHibernateDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private NegoServiciosGenNHibernateDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;



      
    }
}