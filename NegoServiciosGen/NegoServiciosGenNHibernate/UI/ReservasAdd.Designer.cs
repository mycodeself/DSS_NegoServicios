namespace NegoServiciosGenNHibernate.UI
{
    partial class ReservasAdd
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
            this.idCliente = new System.Windows.Forms.Label();
            this.id_cliente_textbox = new System.Windows.Forms.TextBox();
            this.ID_Vuelo = new System.Windows.Forms.Label();
            this.id_vuelo_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plazas_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.estado_textbox = new System.Windows.Forms.TextBox();
            this.confirmar_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idCliente
            // 
            this.idCliente.AutoSize = true;
            this.idCliente.Location = new System.Drawing.Point(71, 9);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(53, 13);
            this.idCliente.TabIndex = 0;
            this.idCliente.Text = "ID Cliente";
            // 
            // id_cliente_textbox
            // 
            this.id_cliente_textbox.Location = new System.Drawing.Point(51, 25);
            this.id_cliente_textbox.Name = "id_cliente_textbox";
            this.id_cliente_textbox.Size = new System.Drawing.Size(100, 20);
            this.id_cliente_textbox.TabIndex = 1;
            this.id_cliente_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID_Vuelo
            // 
            this.ID_Vuelo.AutoSize = true;
            this.ID_Vuelo.Location = new System.Drawing.Point(71, 57);
            this.ID_Vuelo.Name = "ID_Vuelo";
            this.ID_Vuelo.Size = new System.Drawing.Size(51, 13);
            this.ID_Vuelo.TabIndex = 2;
            this.ID_Vuelo.Text = "ID_Vuelo";
            // 
            // id_vuelo_textbox
            // 
            this.id_vuelo_textbox.Location = new System.Drawing.Point(51, 73);
            this.id_vuelo_textbox.Name = "id_vuelo_textbox";
            this.id_vuelo_textbox.Size = new System.Drawing.Size(100, 20);
            this.id_vuelo_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plazas";
            // 
            // plazas_textbox
            // 
            this.plazas_textbox.Location = new System.Drawing.Point(51, 121);
            this.plazas_textbox.Name = "plazas_textbox";
            this.plazas_textbox.Size = new System.Drawing.Size(100, 20);
            this.plazas_textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado";
            // 
            // estado_textbox
            // 
            this.estado_textbox.Location = new System.Drawing.Point(51, 172);
            this.estado_textbox.Name = "estado_textbox";
            this.estado_textbox.Size = new System.Drawing.Size(100, 20);
            this.estado_textbox.TabIndex = 7;
            // 
            // confirmar_button
            // 
            this.confirmar_button.Location = new System.Drawing.Point(60, 209);
            this.confirmar_button.Name = "confirmar_button";
            this.confirmar_button.Size = new System.Drawing.Size(75, 23);
            this.confirmar_button.TabIndex = 8;
            this.confirmar_button.Text = "Confirmar";
            this.confirmar_button.UseVisualStyleBackColor = true;
            this.confirmar_button.Click += new System.EventHandler(this.confirmar_button_Click);
            // 
            // ReservasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 244);
            this.Controls.Add(this.confirmar_button);
            this.Controls.Add(this.estado_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plazas_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_vuelo_textbox);
            this.Controls.Add(this.ID_Vuelo);
            this.Controls.Add(this.id_cliente_textbox);
            this.Controls.Add(this.idCliente);
            this.Name = "ReservasAdd";
            this.Text = "ReservasAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idCliente;
        private System.Windows.Forms.TextBox id_cliente_textbox;
        private System.Windows.Forms.Label ID_Vuelo;
        private System.Windows.Forms.TextBox id_vuelo_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plazas_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox estado_textbox;
        private System.Windows.Forms.Button confirmar_button;
    }
}