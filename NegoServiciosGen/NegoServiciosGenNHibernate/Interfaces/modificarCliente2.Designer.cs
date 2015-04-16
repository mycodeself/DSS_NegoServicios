namespace NegoServiciosGenNHibernate.Interfaces
{
    partial class modificarCliente2
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
            this.button1 = new System.Windows.Forms.Button();
            this.usuario_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario_textbox = new System.Windows.Forms.TextBox();
            this.dni_label = new System.Windows.Forms.Label();
            this.dni_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // usuario_label
            // 
            this.usuario_label.AutoSize = true;
            this.usuario_label.Location = new System.Drawing.Point(22, 56);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(43, 13);
            this.usuario_label.TabIndex = 1;
            this.usuario_label.Text = "Usuario";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(22, 99);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(22, 144);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(36, 13);
            this.email_label.TabIndex = 3;
            this.email_label.Text = "E-Mail";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(98, 99);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(100, 20);
            this.password_textbox.TabIndex = 4;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(98, 144);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(100, 20);
            this.email_textbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datos Cliente";
            // 
            // usuario_textbox
            // 
            this.usuario_textbox.Location = new System.Drawing.Point(98, 53);
            this.usuario_textbox.Name = "usuario_textbox";
            this.usuario_textbox.Size = new System.Drawing.Size(100, 20);
            this.usuario_textbox.TabIndex = 7;
            // 
            // dni_label
            // 
            this.dni_label.AutoSize = true;
            this.dni_label.Location = new System.Drawing.Point(22, 191);
            this.dni_label.Name = "dni_label";
            this.dni_label.Size = new System.Drawing.Size(26, 13);
            this.dni_label.TabIndex = 8;
            this.dni_label.Text = "DNI";
            // 
            // dni_textbox
            // 
            this.dni_textbox.Location = new System.Drawing.Point(98, 188);
            this.dni_textbox.Name = "dni_textbox";
            this.dni_textbox.Size = new System.Drawing.Size(100, 20);
            this.dni_textbox.TabIndex = 9;
            // 
            // modificarCliente2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dni_textbox);
            this.Controls.Add(this.dni_label);
            this.Controls.Add(this.usuario_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.usuario_label);
            this.Controls.Add(this.button1);
            this.Name = "modificarCliente2";
            this.Text = "modificarCliente2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuario_textbox;
        private System.Windows.Forms.Label dni_label;
        private System.Windows.Forms.TextBox dni_textbox;
    }
}