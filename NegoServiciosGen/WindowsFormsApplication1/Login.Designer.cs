namespace NegoServiciosGenNHibernate.Interfaces
{
    partial class login
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
            this.password_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.entrar_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuario_label
            // 
            this.usuario_label.Location = new System.Drawing.Point(33, 52);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(87, 20);
            this.usuario_label.TabIndex = 0;
            this.usuario_label.Text = "Usuario";
            this.usuario_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usuario_label.Click += new System.EventHandler(this.usuario_label_Click);
            // 
            // password_label
            // 
            this.password_label.Location = new System.Drawing.Point(33, 97);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(87, 20);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // entrar_button
            // 
            this.entrar_button.Location = new System.Drawing.Point(220, 142);
            this.entrar_button.Name = "entrar_button";
            this.entrar_button.Size = new System.Drawing.Size(75, 23);
            this.entrar_button.TabIndex = 4;
            this.entrar_button.Text = "Entrar";
            this.entrar_button.UseVisualStyleBackColor = true;
            this.entrar_button.Click += new System.EventHandler(this.entrar_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(123, 9);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(40, 13);
            this.login_label.TabIndex = 5;
            this.login_label.Text = "LOGIN";
            this.login_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 177);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.entrar_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.usuario_label);
            this.Name = "login";
            this.Text = "NegoServicios Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button entrar_button;
        private System.Windows.Forms.Label login_label;
    }
}