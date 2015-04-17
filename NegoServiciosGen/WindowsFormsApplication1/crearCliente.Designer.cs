namespace NegoServiciosGenNHibernate.Interfaces
{
    partial class crearCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.usuario_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.usuario_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dni_label = new System.Windows.Forms.Label();
            this.dni_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // usuario_label
            // 
            this.usuario_label.Location = new System.Drawing.Point(53, 51);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(64, 20);
            this.usuario_label.TabIndex = 1;
            this.usuario_label.Text = "Usuario";
            this.usuario_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_label
            // 
            this.password_label.Location = new System.Drawing.Point(53, 86);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(64, 20);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(53, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Crear Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(123, 125);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(100, 20);
            this.email_text.TabIndex = 5;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(123, 86);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(100, 20);
            this.password_text.TabIndex = 6;
            // 
            // usuario_text
            // 
            this.usuario_text.Location = new System.Drawing.Point(123, 51);
            this.usuario_text.Name = "usuario_text";
            this.usuario_text.Size = new System.Drawing.Size(100, 20);
            this.usuario_text.TabIndex = 7;
            this.usuario_text.TextChanged += new System.EventHandler(this.usuario_text_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dni_label
            // 
            this.dni_label.Location = new System.Drawing.Point(53, 163);
            this.dni_label.Name = "dni_label";
            this.dni_label.Size = new System.Drawing.Size(64, 20);
            this.dni_label.TabIndex = 9;
            this.dni_label.Text = "DNI";
            this.dni_label.Click += new System.EventHandler(this.dni_label_Click);
            // 
            // dni_text
            // 
            this.dni_text.Location = new System.Drawing.Point(123, 163);
            this.dni_text.Name = "dni_text";
            this.dni_text.Size = new System.Drawing.Size(100, 20);
            this.dni_text.TabIndex = 10;
            // 
            // crearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dni_text);
            this.Controls.Add(this.dni_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usuario_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.usuario_label);
            this.Controls.Add(this.label1);
            this.Name = "crearCliente";
            this.Text = "crearCliente";
            this.Load += new System.EventHandler(this.crearCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox usuario_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dni_label;
        private System.Windows.Forms.TextBox dni_text;
    }
}