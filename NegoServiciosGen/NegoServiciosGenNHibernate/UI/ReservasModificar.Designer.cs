namespace NegoServiciosGenNHibernate.UI
{
    partial class ReservasModificar
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
            this.Plazas_label = new System.Windows.Forms.Label();
            this.plazas_textbox = new System.Windows.Forms.TextBox();
            this.Estado_label = new System.Windows.Forms.Label();
            this.estado_textbox = new System.Windows.Forms.TextBox();
            this.Confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Plazas_label
            // 
            this.Plazas_label.AutoSize = true;
            this.Plazas_label.Location = new System.Drawing.Point(57, 9);
            this.Plazas_label.Name = "Plazas_label";
            this.Plazas_label.Size = new System.Drawing.Size(38, 13);
            this.Plazas_label.TabIndex = 0;
            this.Plazas_label.Text = "Plazas";
            // 
            // plazas_textbox
            // 
            this.plazas_textbox.Location = new System.Drawing.Point(37, 25);
            this.plazas_textbox.Name = "plazas_textbox";
            this.plazas_textbox.Size = new System.Drawing.Size(100, 20);
            this.plazas_textbox.TabIndex = 1;
            // 
            // Estado_label
            // 
            this.Estado_label.AutoSize = true;
            this.Estado_label.Location = new System.Drawing.Point(57, 60);
            this.Estado_label.Name = "Estado_label";
            this.Estado_label.Size = new System.Drawing.Size(40, 13);
            this.Estado_label.TabIndex = 2;
            this.Estado_label.Text = "Estado";
            // 
            // estado_textbox
            // 
            this.estado_textbox.Location = new System.Drawing.Point(37, 76);
            this.estado_textbox.Name = "estado_textbox";
            this.estado_textbox.Size = new System.Drawing.Size(100, 20);
            this.estado_textbox.TabIndex = 3;
            this.estado_textbox.TextChanged += new System.EventHandler(this.estado_textbox_TextChanged);
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(49, 111);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Confirmar.TabIndex = 4;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            // 
            // ReservasModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 144);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.estado_textbox);
            this.Controls.Add(this.Estado_label);
            this.Controls.Add(this.plazas_textbox);
            this.Controls.Add(this.Plazas_label);
            this.Name = "ReservasModificar";
            this.Text = "ReservasModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plazas_label;
        private System.Windows.Forms.TextBox plazas_textbox;
        private System.Windows.Forms.Label Estado_label;
        private System.Windows.Forms.TextBox estado_textbox;
        private System.Windows.Forms.Button Confirmar;
    }
}