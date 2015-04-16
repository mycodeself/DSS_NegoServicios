namespace NegoServiciosGenNHibernate.Interfaces
{
    partial class eliminarCliente2
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
            this.usuario_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.email_escogido_label = new System.Windows.Forms.Label();
            this.usuario_escogido_label = new System.Windows.Forms.Label();
            this.dni_label = new System.Windows.Forms.Label();
            this.dni_escogida_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuario_label
            // 
            this.usuario_label.AutoSize = true;
            this.usuario_label.Location = new System.Drawing.Point(33, 56);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(43, 13);
            this.usuario_label.TabIndex = 0;
            this.usuario_label.Text = "Usuario";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(33, 103);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(36, 13);
            this.email_label.TabIndex = 2;
            this.email_label.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "¿Este es el cliente que deseas eliminar?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // email_escogido_label
            // 
            this.email_escogido_label.AutoSize = true;
            this.email_escogido_label.Location = new System.Drawing.Point(133, 103);
            this.email_escogido_label.Name = "email_escogido_label";
            this.email_escogido_label.Size = new System.Drawing.Size(35, 13);
            this.email_escogido_label.TabIndex = 9;
            this.email_escogido_label.Text = "label5";
            // 
            // usuario_escogido_label
            // 
            this.usuario_escogido_label.AutoSize = true;
            this.usuario_escogido_label.Location = new System.Drawing.Point(133, 56);
            this.usuario_escogido_label.Name = "usuario_escogido_label";
            this.usuario_escogido_label.Size = new System.Drawing.Size(35, 13);
            this.usuario_escogido_label.TabIndex = 11;
            this.usuario_escogido_label.Text = "label7";
            // 
            // dni_label
            // 
            this.dni_label.AutoSize = true;
            this.dni_label.Location = new System.Drawing.Point(33, 154);
            this.dni_label.Name = "dni_label";
            this.dni_label.Size = new System.Drawing.Size(23, 13);
            this.dni_label.TabIndex = 12;
            this.dni_label.Text = "DN";
            this.dni_label.Click += new System.EventHandler(this.label8_Click);
            // 
            // dni_escogida_label
            // 
            this.dni_escogida_label.AutoSize = true;
            this.dni_escogida_label.Location = new System.Drawing.Point(133, 154);
            this.dni_escogida_label.Name = "dni_escogida_label";
            this.dni_escogida_label.Size = new System.Drawing.Size(35, 13);
            this.dni_escogida_label.TabIndex = 13;
            this.dni_escogida_label.Text = "label9";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // eliminarCliente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dni_escogida_label);
            this.Controls.Add(this.dni_label);
            this.Controls.Add(this.usuario_escogido_label);
            this.Controls.Add(this.email_escogido_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.usuario_label);
            this.Name = "eliminarCliente2";
            this.Text = "eliminarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label email_escogido_label;
        private System.Windows.Forms.Label usuario_escogido_label;
        private System.Windows.Forms.Label dni_label;
        private System.Windows.Forms.Label dni_escogida_label;
        private System.Windows.Forms.TextBox textBox1;
    }
}