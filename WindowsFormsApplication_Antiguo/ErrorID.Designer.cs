namespace NegoServiciosGenNHibernate.Interfaces
{
    partial class ErrorID
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
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(88, 25);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(114, 13);
            this.error_label.TabIndex = 0;
            this.error_label.Text = "ERROR DE SISTEMA";
            // 
            // ErrorID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 69);
            this.Controls.Add(this.error_label);
            this.Name = "ErrorID";
            this.Text = "ErrorID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label error_label;
    }
}