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
            this.plazas_label = new System.Windows.Forms.Label();
            this.estado_label = new System.Windows.Forms.Label();
            this.plazas_textbox = new System.Windows.Forms.TextBox();
            this.estados_textbox = new System.Windows.Forms.TextBox();
            this.estado_button = new System.Windows.Forms.Button();
            this.plazas_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plazas_label
            // 
            this.plazas_label.AutoSize = true;
            this.plazas_label.Location = new System.Drawing.Point(111, 9);
            this.plazas_label.Name = "plazas_label";
            this.plazas_label.Size = new System.Drawing.Size(38, 13);
            this.plazas_label.TabIndex = 0;
            this.plazas_label.Text = "Plazas";
            // 
            // estado_label
            // 
            this.estado_label.AutoSize = true;
            this.estado_label.Location = new System.Drawing.Point(111, 75);
            this.estado_label.Name = "estado_label";
            this.estado_label.Size = new System.Drawing.Size(40, 13);
            this.estado_label.TabIndex = 1;
            this.estado_label.Text = "Estado";
            // 
            // plazas_textbox
            // 
            this.plazas_textbox.Location = new System.Drawing.Point(76, 25);
            this.plazas_textbox.Name = "plazas_textbox";
            this.plazas_textbox.Size = new System.Drawing.Size(100, 20);
            this.plazas_textbox.TabIndex = 2;
            // 
            // estados_textbox
            // 
            this.estados_textbox.Location = new System.Drawing.Point(76, 91);
            this.estados_textbox.Name = "estados_textbox";
            this.estados_textbox.Size = new System.Drawing.Size(100, 20);
            this.estados_textbox.TabIndex = 3;
            // 
            // estado_button
            // 
            this.estado_button.Location = new System.Drawing.Point(12, 134);
            this.estado_button.Name = "estado_button";
            this.estado_button.Size = new System.Drawing.Size(75, 53);
            this.estado_button.TabIndex = 5;
            this.estado_button.Text = "Cambiar Estado";
            this.estado_button.UseVisualStyleBackColor = true;
            this.estado_button.Click += new System.EventHandler(this.estado_button_Click);
            // 
            // plazas_button
            // 
            this.plazas_button.Location = new System.Drawing.Point(169, 134);
            this.plazas_button.Name = "plazas_button";
            this.plazas_button.Size = new System.Drawing.Size(75, 53);
            this.plazas_button.TabIndex = 6;
            this.plazas_button.Text = "Cambiar Plazas";
            this.plazas_button.UseVisualStyleBackColor = true;
            this.plazas_button.Click += new System.EventHandler(this.plazas_button_Click);
            // 
            // ReservasModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 199);
            this.Controls.Add(this.plazas_button);
            this.Controls.Add(this.estado_button);
            this.Controls.Add(this.estados_textbox);
            this.Controls.Add(this.plazas_textbox);
            this.Controls.Add(this.estado_label);
            this.Controls.Add(this.plazas_label);
            this.Name = "ReservasModificar";
            this.Text = "ReservasModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plazas_label;
        private System.Windows.Forms.Label estado_label;
        private System.Windows.Forms.TextBox plazas_textbox;
        private System.Windows.Forms.TextBox estados_textbox;
        private System.Windows.Forms.Button estado_button;
        private System.Windows.Forms.Button plazas_button;
    }
}