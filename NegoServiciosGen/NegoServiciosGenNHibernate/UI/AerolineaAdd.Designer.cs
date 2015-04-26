namespace NegoServiciosGenNHibernate.UI
{
    partial class AerolineaAdd
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
            this.aerolinea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aerolinea
            // 
            this.aerolinea.Location = new System.Drawing.Point(104, 77);
            this.aerolinea.Name = "aerolinea";
            this.aerolinea.Size = new System.Drawing.Size(100, 20);
            this.aerolinea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de aerolinea";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(117, 139);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Confirmar";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.SystemColors.Control;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(137, 114);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(29, 13);
            this.error.TabIndex = 3;
            this.error.Text = "Error";
            // 
            // AerolineaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 210);
            this.Controls.Add(this.error);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aerolinea);
            this.Name = "AerolineaAdd";
            this.Text = "Añadir aerolinea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aerolinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label error;
    }
}