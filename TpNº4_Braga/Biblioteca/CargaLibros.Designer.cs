namespace Biblioteca
{
    partial class CargaLibros
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxPaginas = new System.Windows.Forms.TextBox();
            this.textBoxEdicion = new System.Windows.Forms.TextBox();
            this.textBoxEditorial = new System.Windows.Forms.TextBox();
            this.textBoxLugar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerFECHAedicion = new System.Windows.Forms.DateTimePicker();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.DGVLibro = new System.Windows.Forms.DataGridView();
            this.títuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidaddePáginasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEdicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paginas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Edicion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Editorial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(16, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lugar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(16, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "( ciudad y pais )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(16, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Fecha Edicion";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(144, 62);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(290, 20);
            this.textBoxTitulo.TabIndex = 10;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(144, 123);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(290, 20);
            this.textBoxISBN.TabIndex = 11;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(144, 91);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(290, 20);
            this.textBoxAutor.TabIndex = 12;
            // 
            // textBoxPaginas
            // 
            this.textBoxPaginas.Location = new System.Drawing.Point(144, 155);
            this.textBoxPaginas.Name = "textBoxPaginas";
            this.textBoxPaginas.Size = new System.Drawing.Size(290, 20);
            this.textBoxPaginas.TabIndex = 13;
            // 
            // textBoxEdicion
            // 
            this.textBoxEdicion.Location = new System.Drawing.Point(144, 192);
            this.textBoxEdicion.Name = "textBoxEdicion";
            this.textBoxEdicion.Size = new System.Drawing.Size(290, 20);
            this.textBoxEdicion.TabIndex = 14;
            // 
            // textBoxEditorial
            // 
            this.textBoxEditorial.Location = new System.Drawing.Point(144, 226);
            this.textBoxEditorial.Name = "textBoxEditorial";
            this.textBoxEditorial.Size = new System.Drawing.Size(290, 20);
            this.textBoxEditorial.TabIndex = 15;
            // 
            // textBoxLugar
            // 
            this.textBoxLugar.Location = new System.Drawing.Point(144, 269);
            this.textBoxLugar.Name = "textBoxLugar";
            this.textBoxLugar.Size = new System.Drawing.Size(290, 20);
            this.textBoxLugar.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(174, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ingrese los datos del libro";
            // 
            // dateTimePickerFECHAedicion
            // 
            this.dateTimePickerFECHAedicion.Location = new System.Drawing.Point(144, 323);
            this.dateTimePickerFECHAedicion.MaxDate = new System.DateTime(2021, 5, 29, 0, 0, 0, 0);
            this.dateTimePickerFECHAedicion.Name = "dateTimePickerFECHAedicion";
            this.dateTimePickerFECHAedicion.Size = new System.Drawing.Size(290, 20);
            this.dateTimePickerFECHAedicion.TabIndex = 20;
            this.dateTimePickerFECHAedicion.Value = new System.DateTime(2021, 5, 25, 23, 59, 59, 0);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Location = new System.Drawing.Point(465, 309);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(149, 34);
            this.buttonguardar.TabIndex = 21;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DGVLibro
            // 
            this.DGVLibro.AutoGenerateColumns = false;
            this.DGVLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.títuloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.cantidaddePáginasDataGridViewTextBoxColumn,
            this.edicionDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn,
            this.fechaEdicionDataGridViewTextBoxColumn});
            this.DGVLibro.DataSource = this.libroBindingSource;
            this.DGVLibro.Location = new System.Drawing.Point(465, 62);
            this.DGVLibro.Name = "DGVLibro";
            this.DGVLibro.ReadOnly = true;
            this.DGVLibro.Size = new System.Drawing.Size(845, 231);
            this.DGVLibro.TabIndex = 22;
            // 
            // títuloDataGridViewTextBoxColumn
            // 
            this.títuloDataGridViewTextBoxColumn.DataPropertyName = "Título";
            this.títuloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.títuloDataGridViewTextBoxColumn.Name = "títuloDataGridViewTextBoxColumn";
            this.títuloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidaddePáginasDataGridViewTextBoxColumn
            // 
            this.cantidaddePáginasDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_de_Páginas";
            this.cantidaddePáginasDataGridViewTextBoxColumn.HeaderText = "Cantidad_de_Páginas";
            this.cantidaddePáginasDataGridViewTextBoxColumn.Name = "cantidaddePáginasDataGridViewTextBoxColumn";
            this.cantidaddePáginasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edicionDataGridViewTextBoxColumn
            // 
            this.edicionDataGridViewTextBoxColumn.DataPropertyName = "Edicion";
            this.edicionDataGridViewTextBoxColumn.HeaderText = "Edicion";
            this.edicionDataGridViewTextBoxColumn.Name = "edicionDataGridViewTextBoxColumn";
            this.edicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            this.lugarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEdicionDataGridViewTextBoxColumn
            // 
            this.fechaEdicionDataGridViewTextBoxColumn.DataPropertyName = "FechaEdicion";
            this.fechaEdicionDataGridViewTextBoxColumn.HeaderText = "FechaEdicion";
            this.fechaEdicionDataGridViewTextBoxColumn.Name = "fechaEdicionDataGridViewTextBoxColumn";
            this.fechaEdicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(Biblioteca.Libro);
            // 
            // libroBindingSource1
            // 
            this.libroBindingSource1.DataSource = typeof(Biblioteca.Libro);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(815, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 34);
            this.button3.TabIndex = 24;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1005, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 34);
            this.button4.TabIndex = 25;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CargaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1351, 400);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DGVLibro);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.dateTimePickerFECHAedicion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxLugar);
            this.Controls.Add(this.textBoxEditorial);
            this.Controls.Add(this.textBoxEdicion);
            this.Controls.Add(this.textBoxPaginas);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CargaLibros";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.CargaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxPaginas;
        private System.Windows.Forms.TextBox textBoxEdicion;
        private System.Windows.Forms.TextBox textBoxEditorial;
        private System.Windows.Forms.TextBox textBoxLugar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerFECHAedicion;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.DataGridView DGVLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn títuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidaddePáginasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEdicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private System.Windows.Forms.BindingSource libroBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

