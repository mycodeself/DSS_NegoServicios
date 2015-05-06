namespace NegoServiciosGenNHibernate.UI
{
    partial class Error
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
            this.Texto_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto_error
            // 
            this.Texto_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_error.Location = new System.Drawing.Point(12, 41);
            this.Texto_error.Name = "Texto_error";
            this.Texto_error.Size = new System.Drawing.Size(173, 30);
            this.Texto_error.TabIndex = 0;
            this.Texto_error.Text = "ERROR:";
            this.Texto_error.Click += new System.EventHandler(this.label1_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 122);
            this.Controls.Add(this.Texto_error);
            this.Name = "Error";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Texto_error;
    }
}