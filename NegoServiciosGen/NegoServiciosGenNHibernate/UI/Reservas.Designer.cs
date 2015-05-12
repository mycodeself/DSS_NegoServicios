namespace NegoServiciosGenNHibernate.UI
{
    partial class Reservas
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
            this.Reserva_label1 = new System.Windows.Forms.Label();
            this.reserva_id_box = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(638, 176);
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
            // Reserva_label1
            // 
            this.Reserva_label1.AutoSize = true;
            this.Reserva_label1.Location = new System.Drawing.Point(12, 18);
            this.Reserva_label1.Name = "Reserva_label1";
            this.Reserva_label1.Size = new System.Drawing.Size(58, 13);
            this.Reserva_label1.TabIndex = 1;
            this.Reserva_label1.Text = "ReservaID";
            // 
            // reserva_id_box
            // 
            this.reserva_id_box.Location = new System.Drawing.Point(89, 15);
            this.reserva_id_box.Name = "reserva_id_box";
            this.reserva_id_box.Size = new System.Drawing.Size(113, 20);
            this.reserva_id_box.TabIndex = 2;
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 275);
            this.Controls.Add(this.reserva_id_box);
            this.Controls.Add(this.Reserva_label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reservas";
            this.Text = "Reservas";
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
        private System.Windows.Forms.Label Reserva_label1;
        private System.Windows.Forms.TextBox reserva_id_box;
    }
}