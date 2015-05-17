namespace NegoServiciosGenNHibernate.UI
{
    partial class VuelosAdd
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
            this.Fsalida_label = new System.Windows.Forms.Label();
            this.Llegada_Label = new System.Windows.Forms.Label();
            this.Origen_label = new System.Windows.Forms.Label();
            this.Destino_label = new System.Windows.Forms.Label();
            this.Hsalida_label = new System.Windows.Forms.Label();
            this.Hllegada_label = new System.Windows.Forms.Label();
            this.Fsalida_date = new System.Windows.Forms.DateTimePicker();
            this.Fllegada_date = new System.Windows.Forms.DateTimePicker();
            this.Hsalida_date = new System.Windows.Forms.DateTimePicker();
            this.Hllegada_date = new System.Windows.Forms.DateTimePicker();
            this.Origen_tb = new System.Windows.Forms.TextBox();
            this.Destino_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Aerolinea_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Precio_tb = new System.Windows.Forms.TextBox();
            this.Plazas_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Fsalida_label
            // 
            this.Fsalida_label.AutoSize = true;
            this.Fsalida_label.Location = new System.Drawing.Point(3, 92);
            this.Fsalida_label.Name = "Fsalida_label";
            this.Fsalida_label.Size = new System.Drawing.Size(69, 13);
            this.Fsalida_label.TabIndex = 0;
            this.Fsalida_label.Text = "Fecha Salida";
            // 
            // Llegada_Label
            // 
            this.Llegada_Label.AutoSize = true;
            this.Llegada_Label.Location = new System.Drawing.Point(3, 131);
            this.Llegada_Label.Name = "Llegada_Label";
            this.Llegada_Label.Size = new System.Drawing.Size(78, 13);
            this.Llegada_Label.TabIndex = 1;
            this.Llegada_Label.Text = "Fecha Llegada";
            // 
            // Origen_label
            // 
            this.Origen_label.AutoSize = true;
            this.Origen_label.Location = new System.Drawing.Point(4, 21);
            this.Origen_label.Name = "Origen_label";
            this.Origen_label.Size = new System.Drawing.Size(38, 13);
            this.Origen_label.TabIndex = 2;
            this.Origen_label.Text = "Origen";
            // 
            // Destino_label
            // 
            this.Destino_label.AutoSize = true;
            this.Destino_label.Location = new System.Drawing.Point(4, 60);
            this.Destino_label.Name = "Destino_label";
            this.Destino_label.Size = new System.Drawing.Size(43, 13);
            this.Destino_label.TabIndex = 3;
            this.Destino_label.Text = "Destino";
            // 
            // Hsalida_label
            // 
            this.Hsalida_label.AutoSize = true;
            this.Hsalida_label.Location = new System.Drawing.Point(3, 169);
            this.Hsalida_label.Name = "Hsalida_label";
            this.Hsalida_label.Size = new System.Drawing.Size(60, 13);
            this.Hsalida_label.TabIndex = 4;
            this.Hsalida_label.Text = "Hora salida";
            // 
            // Hllegada_label
            // 
            this.Hllegada_label.AutoSize = true;
            this.Hllegada_label.Location = new System.Drawing.Point(3, 209);
            this.Hllegada_label.Name = "Hllegada_label";
            this.Hllegada_label.Size = new System.Drawing.Size(71, 13);
            this.Hllegada_label.TabIndex = 5;
            this.Hllegada_label.Text = "Hora Llegada";
            // 
            // Fsalida_date
            // 
            this.Fsalida_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fsalida_date.Location = new System.Drawing.Point(90, 92);
            this.Fsalida_date.Name = "Fsalida_date";
            this.Fsalida_date.Size = new System.Drawing.Size(200, 20);
            this.Fsalida_date.TabIndex = 6;
            // 
            // Fllegada_date
            // 
            this.Fllegada_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fllegada_date.Location = new System.Drawing.Point(90, 125);
            this.Fllegada_date.Name = "Fllegada_date";
            this.Fllegada_date.Size = new System.Drawing.Size(200, 20);
            this.Fllegada_date.TabIndex = 7;
            // 
            // Hsalida_date
            // 
            this.Hsalida_date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hsalida_date.Location = new System.Drawing.Point(90, 163);
            this.Hsalida_date.Name = "Hsalida_date";
            this.Hsalida_date.Size = new System.Drawing.Size(200, 20);
            this.Hsalida_date.TabIndex = 8;
            this.Hsalida_date.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // Hllegada_date
            // 
            this.Hllegada_date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hllegada_date.Location = new System.Drawing.Point(90, 202);
            this.Hllegada_date.Name = "Hllegada_date";
            this.Hllegada_date.Size = new System.Drawing.Size(200, 20);
            this.Hllegada_date.TabIndex = 9;
            this.Hllegada_date.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged_1);
            // 
            // Origen_tb
            // 
            this.Origen_tb.Location = new System.Drawing.Point(90, 14);
            this.Origen_tb.Name = "Origen_tb";
            this.Origen_tb.Size = new System.Drawing.Size(100, 20);
            this.Origen_tb.TabIndex = 10;
            // 
            // Destino_tb
            // 
            this.Destino_tb.Location = new System.Drawing.Point(90, 53);
            this.Destino_tb.Name = "Destino_tb";
            this.Destino_tb.Size = new System.Drawing.Size(100, 20);
            this.Destino_tb.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Aerolinea";
            // 
            // Aerolinea_tb
            // 
            this.Aerolinea_tb.Location = new System.Drawing.Point(90, 239);
            this.Aerolinea_tb.Name = "Aerolinea_tb";
            this.Aerolinea_tb.Size = new System.Drawing.Size(100, 20);
            this.Aerolinea_tb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Plazas";
            // 
            // Precio_tb
            // 
            this.Precio_tb.Location = new System.Drawing.Point(90, 310);
            this.Precio_tb.Name = "Precio_tb";
            this.Precio_tb.Size = new System.Drawing.Size(100, 20);
            this.Precio_tb.TabIndex = 17;
            // 
            // Plazas_tb
            // 
            this.Plazas_tb.Location = new System.Drawing.Point(90, 274);
            this.Plazas_tb.Name = "Plazas_tb";
            this.Plazas_tb.Size = new System.Drawing.Size(100, 20);
            this.Plazas_tb.TabIndex = 18;
            // 
            // VuelosAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 398);
            this.Controls.Add(this.Plazas_tb);
            this.Controls.Add(this.Precio_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aerolinea_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Destino_tb);
            this.Controls.Add(this.Origen_tb);
            this.Controls.Add(this.Hllegada_date);
            this.Controls.Add(this.Hsalida_date);
            this.Controls.Add(this.Fllegada_date);
            this.Controls.Add(this.Fsalida_date);
            this.Controls.Add(this.Hllegada_label);
            this.Controls.Add(this.Hsalida_label);
            this.Controls.Add(this.Destino_label);
            this.Controls.Add(this.Origen_label);
            this.Controls.Add(this.Llegada_Label);
            this.Controls.Add(this.Fsalida_label);
            this.Name = "VuelosAdd";
            this.Text = "Añadir Vuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fsalida_label;
        private System.Windows.Forms.Label Llegada_Label;
        private System.Windows.Forms.Label Origen_label;
        private System.Windows.Forms.Label Destino_label;
        private System.Windows.Forms.Label Hsalida_label;
        private System.Windows.Forms.Label Hllegada_label;
        private System.Windows.Forms.DateTimePicker Fsalida_date;
        private System.Windows.Forms.DateTimePicker Fllegada_date;
        private System.Windows.Forms.DateTimePicker Hsalida_date;
        private System.Windows.Forms.DateTimePicker Hllegada_date;
        private System.Windows.Forms.TextBox Origen_tb;
        private System.Windows.Forms.TextBox Destino_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Aerolinea_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Precio_tb;
        private System.Windows.Forms.TextBox Plazas_tb;
    }
}