namespace NegoServiciosGenNHibernate.UI
{
    partial class MainEmpleado
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
            this.goClientes = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.goAerolineas = new System.Windows.Forms.Button();
            this.goVuelos = new System.Windows.Forms.Button();
            this.verReservas = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goClientes
            // 
            this.goClientes.Location = new System.Drawing.Point(85, 12);
            this.goClientes.Name = "goClientes";
            this.goClientes.Size = new System.Drawing.Size(127, 73);
            this.goClientes.TabIndex = 0;
            this.goClientes.Text = "Clientes";
            this.goClientes.UseVisualStyleBackColor = true;
            this.goClientes.Click += new System.EventHandler(this.goClientes_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(12, 150);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(756, 451);
            this.container.TabIndex = 1;
            // 
            // goAerolineas
            // 
            this.goAerolineas.Location = new System.Drawing.Point(239, 12);
            this.goAerolineas.Name = "goAerolineas";
            this.goAerolineas.Size = new System.Drawing.Size(127, 73);
            this.goAerolineas.TabIndex = 2;
            this.goAerolineas.Text = "Aerolineas";
            this.goAerolineas.UseVisualStyleBackColor = true;
            // 
            // goVuelos
            // 
            this.goVuelos.Location = new System.Drawing.Point(393, 12);
            this.goVuelos.Name = "goVuelos";
            this.goVuelos.Size = new System.Drawing.Size(127, 73);
            this.goVuelos.TabIndex = 3;
            this.goVuelos.Text = "Vuelos";
            this.goVuelos.UseVisualStyleBackColor = true;
            // 
            // verReservas
            // 
            this.verReservas.Location = new System.Drawing.Point(547, 12);
            this.verReservas.Name = "verReservas";
            this.verReservas.Size = new System.Drawing.Size(127, 73);
            this.verReservas.TabIndex = 4;
            this.verReservas.Text = "Reservas";
            this.verReservas.UseVisualStyleBackColor = true;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(39, 101);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(112, 31);
            this.header.TabIndex = 5;
            this.header.Text = "TITULO";
            this.header.Visible = false;
            // 
            // MainEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 613);
            this.Controls.Add(this.header);
            this.Controls.Add(this.verReservas);
            this.Controls.Add(this.goVuelos);
            this.Controls.Add(this.goAerolineas);
            this.Controls.Add(this.container);
            this.Controls.Add(this.goClientes);
            this.Name = "MainEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NegoServicios - Booking aereo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goClientes;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button goAerolineas;
        private System.Windows.Forms.Button goVuelos;
        private System.Windows.Forms.Button verReservas;
        private System.Windows.Forms.Label header;

    }
}