namespace NegoServiciosGenNHibernate.Interfaces
{
    partial class crear_cliente
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
            this.usuario = new System.Windows.Forms.Label();
            this.usuario_textbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.Label();
            this.nombre_textbox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Introducir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(12, 21);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(75, 20);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Usuario";
            this.usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usuario_textbox
            // 
            this.usuario_textbox.Location = new System.Drawing.Point(89, 21);
            this.usuario_textbox.Name = "usuario_textbox";
            this.usuario_textbox.Size = new System.Drawing.Size(100, 20);
            this.usuario_textbox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(12, 62);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(71, 17);
            this.password_textbox.TabIndex = 6;
            this.password_textbox.Text = "Contraseña";
            this.password_textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(12, 98);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(75, 17);
            this.email_textbox.TabIndex = 7;
            this.email_textbox.Text = "E-Mail";
            this.email_textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nombre_textbox
            // 
            this.nombre_textbox.Location = new System.Drawing.Point(12, 133);
            this.nombre_textbox.Name = "nombre_textbox";
            this.nombre_textbox.Size = new System.Drawing.Size(75, 20);
            this.nombre_textbox.TabIndex = 8;
            this.nombre_textbox.Text = "Nombre";
            this.nombre_textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 210);
            this.Controls.Add(this.nombre_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuario_textbox);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Crear Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox usuario_textbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label password_textbox;
        private System.Windows.Forms.Label email_textbox;
        private System.Windows.Forms.Label nombre_textbox;
    }
}