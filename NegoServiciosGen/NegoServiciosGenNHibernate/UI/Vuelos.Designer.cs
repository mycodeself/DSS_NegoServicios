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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.negoServiciosGenNHibernateDataSet = new NegoServiciosGenNHibernate.NegoServiciosGenNHibernateDataSet();
            this.negoServiciosGenNHibernateDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vuelos_label = new System.Windows.Forms.Label();
            this.vuelos_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.negoServiciosGenNHibernateDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // negoServiciosGenNHibernateDataSet
            // 
            this.negoServiciosGenNHibernateDataSet.DataSetName = "NegoServiciosGenNHibernateDataSet";
            this.negoServiciosGenNHibernateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // negoServiciosGenNHibernateDataSetBindingSource
            // 
            this.negoServiciosGenNHibernateDataSetBindingSource.DataSource = this.negoServiciosGenNHibernateDataSet;
            this.negoServiciosGenNHibernateDataSetBindingSource.Position = 0;
            // 
            // Vuelos_label
            // 
            this.Vuelos_label.AutoSize = true;
            this.Vuelos_label.Location = new System.Drawing.Point(12, 20);
            this.Vuelos_label.Name = "Vuelos_label";
            this.Vuelos_label.Size = new System.Drawing.Size(48, 13);
            this.Vuelos_label.TabIndex = 1;
            this.Vuelos_label.Text = "ID Vuelo";
            // 
            // vuelos_textbox
            // 
            this.vuelos_textbox.Location = new System.Drawing.Point(83, 17);
            this.vuelos_textbox.Name = "vuelos_textbox";
            this.vuelos_textbox.Size = new System.Drawing.Size(100, 20);
            this.vuelos_textbox.TabIndex = 2;
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 261);
            this.Controls.Add(this.vuelos_textbox);
            this.Controls.Add(this.Vuelos_label);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negoServiciosGenNHibernateDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource negoServiciosGenNHibernateDataSetBindingSource;
        private NegoServiciosGenNHibernateDataSet negoServiciosGenNHibernateDataSet;
        private System.Windows.Forms.Label Vuelos_label;
        private System.Windows.Forms.TextBox vuelos_textbox;
    }
}