﻿namespace BasicCrud.PL
{
    partial class FormAuto
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogo_autosDataSet = new BasicCrud.catalogo_autosDataSet();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.txtAnio = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.autosTableAdapter = new BasicCrud.catalogo_autosDataSetTableAdapters.autosTableAdapter();
            this.picBoxAutoImg = new System.Windows.Forms.PictureBox();
            this.btnPickImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogo_autosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAutoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registrar/Modificar Auto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha venta:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(135, 70);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(145, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // autosBindingSource
            // 
            this.autosBindingSource.DataMember = "autos";
            this.autosBindingSource.DataSource = this.catalogo_autosDataSet;
            // 
            // catalogo_autosDataSet
            // 
            this.catalogo_autosDataSet.DataSetName = "catalogo_autosDataSet";
            this.catalogo_autosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(135, 109);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(145, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Mask", global::BasicCrud.Properties.Settings.Default, "preccio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPrecio.Location = new System.Drawing.Point(135, 184);
            this.txtPrecio.Mask = global::BasicCrud.Properties.Settings.Default.preccio;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(145, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(135, 147);
            this.txtAnio.Mask = "9999";
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(145, 20);
            this.txtAnio.TabIndex = 11;
            this.txtAnio.ValidatingType = typeof(int);
            this.txtAnio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ValidarAño);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtFechaVenta
            // 
            this.dtFechaVenta.Location = new System.Drawing.Point(135, 224);
            this.dtFechaVenta.Name = "dtFechaVenta";
            this.dtFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaVenta.TabIndex = 14;
            // 
            // autosTableAdapter
            // 
            this.autosTableAdapter.ClearBeforeFill = true;
            // 
            // picBoxAutoImg
            // 
            this.picBoxAutoImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAutoImg.Location = new System.Drawing.Point(335, 70);
            this.picBoxAutoImg.Name = "picBoxAutoImg";
            this.picBoxAutoImg.Size = new System.Drawing.Size(169, 134);
            this.picBoxAutoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAutoImg.TabIndex = 15;
            this.picBoxAutoImg.TabStop = false;
            // 
            // btnPickImg
            // 
            this.btnPickImg.Location = new System.Drawing.Point(429, 220);
            this.btnPickImg.Name = "btnPickImg";
            this.btnPickImg.Size = new System.Drawing.Size(75, 23);
            this.btnPickImg.TabIndex = 16;
            this.btnPickImg.Text = "Buscar...";
            this.btnPickImg.UseVisualStyleBackColor = true;
            this.btnPickImg.Click += new System.EventHandler(this.btnPickImg_Click);
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 383);
            this.Controls.Add(this.btnPickImg);
            this.Controls.Add(this.picBoxAutoImg);
            this.Controls.Add(this.dtFechaVenta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormAuto";
            this.Text = "FormAuto";
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogo_autosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAutoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.MaskedTextBox txtAnio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtFechaVenta;
        private catalogo_autosDataSet catalogo_autosDataSet;
        private System.Windows.Forms.BindingSource autosBindingSource;
        private catalogo_autosDataSetTableAdapters.autosTableAdapter autosTableAdapter;
        private System.Windows.Forms.PictureBox picBoxAutoImg;
        private System.Windows.Forms.Button btnPickImg;
    }
}