namespace BasicCrud
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            this.btnRestaura = new System.Windows.Forms.Button();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.autosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAutos = new BasicCrud.dataSetAutos();
            this.autosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogo_autosDataSet = new BasicCrud.catalogo_autosDataSet();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.autosTableAdapter = new BasicCrud.catalogo_autosDataSetTableAdapters.autosTableAdapter();
            this.autosTableAdapter1 = new BasicCrud.dataSetAutosTableAdapters.autosTableAdapter();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.img_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogo_autosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de autos";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::BasicCrud.Properties.Resources.edit1;
            this.btnModificar.Location = new System.Drawing.Point(78, 36);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(40, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Image = global::BasicCrud.Properties.Resources.delete1;
            this.btnBorrar.Location = new System.Drawing.Point(139, 36);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(40, 40);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btExportar
            // 
            this.btExportar.BackColor = System.Drawing.Color.White;
            this.btExportar.Image = global::BasicCrud.Properties.Resources.save1;
            this.btExportar.Location = new System.Drawing.Point(200, 36);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(40, 40);
            this.btExportar.TabIndex = 4;
            this.btExportar.UseVisualStyleBackColor = false;
            // 
            // btnRestaura
            // 
            this.btnRestaura.Image = global::BasicCrud.Properties.Resources.close1;
            this.btnRestaura.Location = new System.Drawing.Point(741, 47);
            this.btnRestaura.Name = "btnRestaura";
            this.btnRestaura.Size = new System.Drawing.Size(26, 23);
            this.btnRestaura.TabIndex = 5;
            this.btnRestaura.UseVisualStyleBackColor = true;
            this.btnRestaura.Click += new System.EventHandler(this.btnRestaura_Click);
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "ID",
            "Marca",
            "Modelo",
            "Año",
            "Precio",
            "Fecha venta"});
            this.cmbFiltrar.Location = new System.Drawing.Point(446, 47);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(139, 21);
            this.cmbFiltrar.TabIndex = 6;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(591, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(144, 20);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Buscar);
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.AllowUserToDeleteRows = false;
            this.dgvAutos.AllowUserToResizeRows = false;
            this.dgvAutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.id,
            this.marca,
            this.modelo,
            this.anio,
            this.precio,
            this.fecha_venta,
            this.imagen,
            this.img_path});
            this.dgvAutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAutos.Location = new System.Drawing.Point(16, 85);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.ReadOnly = true;
            this.dgvAutos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.dgvAutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutos.RowTemplate.Height = 80;
            this.dgvAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAutos.Size = new System.Drawing.Size(753, 238);
            this.dgvAutos.TabIndex = 8;
            this.dgvAutos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // autosBindingSource1
            // 
            this.autosBindingSource1.DataMember = "autos";
            this.autosBindingSource1.DataSource = this.dataSetAutos;
            // 
            // dataSetAutos
            // 
            this.dataSetAutos.DataSetName = "dataSetAutos";
            this.dataSetAutos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::BasicCrud.Properties.Resources.add1;
            this.btnAgregar.Location = new System.Drawing.Point(18, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // autosTableAdapter
            // 
            this.autosTableAdapter.ClearBeforeFill = true;
            // 
            // autosTableAdapter1
            // 
            this.autosTableAdapter1.ClearBeforeFill = true;
            // 
            // select
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.select.DefaultCellStyle = dataGridViewCellStyle1;
            this.select.FalseValue = "false";
            this.select.FillWeight = 25F;
            this.select.HeaderText = "Select";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.TrueValue = "true";
            // 
            // id
            // 
            this.id.FillWeight = 16.35624F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.FillWeight = 43.05952F;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.FillWeight = 41.16062F;
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // anio
            // 
            this.anio.FillWeight = 29.98644F;
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.FillWeight = 29.98644F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // fecha_venta
            // 
            this.fecha_venta.FillWeight = 78.10255F;
            this.fecha_venta.HeaderText = "Fecha Venta";
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.ReadOnly = true;
            // 
            // imagen
            // 
            this.imagen.FillWeight = 52.71596F;
            this.imagen.HeaderText = "Imagen";
            this.imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // img_path
            // 
            this.img_path.HeaderText = "img_path";
            this.img_path.Name = "img_path";
            this.img_path.ReadOnly = true;
            this.img_path.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 334);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.btnRestaura);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Concesionaria de Autos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogo_autosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Button btnRestaura;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvAutos;
        private catalogo_autosDataSet catalogo_autosDataSet;
        private System.Windows.Forms.BindingSource autosBindingSource;
        private catalogo_autosDataSetTableAdapters.autosTableAdapter autosTableAdapter;
        private dataSetAutos dataSetAutos;
        private System.Windows.Forms.BindingSource autosBindingSource1;
        private dataSetAutosTableAdapters.autosTableAdapter autosTableAdapter1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venta;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn img_path;
    }
}

