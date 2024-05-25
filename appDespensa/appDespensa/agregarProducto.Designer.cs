namespace appDespensa
{
    partial class agregarProducto
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombreagregar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidadagregar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecioagregar = new System.Windows.Forms.TextBox();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnagregar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.btregresar = new System.Windows.Forms.Button();
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 31.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO PRODUCTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOMBRE PRODUCTO";
            // 
            // txtnombreagregar
            // 
            this.txtnombreagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreagregar.Location = new System.Drawing.Point(70, 285);
            this.txtnombreagregar.Multiline = true;
            this.txtnombreagregar.Name = "txtnombreagregar";
            this.txtnombreagregar.Size = new System.Drawing.Size(316, 31);
            this.txtnombreagregar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "CANTIDAD PRODUCTO";
            // 
            // txtcantidadagregar
            // 
            this.txtcantidadagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadagregar.Location = new System.Drawing.Point(70, 361);
            this.txtcantidadagregar.Multiline = true;
            this.txtcantidadagregar.Name = "txtcantidadagregar";
            this.txtcantidadagregar.Size = new System.Drawing.Size(316, 31);
            this.txtcantidadagregar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "PRECIO UNIDAD";
            // 
            // txtprecioagregar
            // 
            this.txtprecioagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioagregar.Location = new System.Drawing.Point(70, 439);
            this.txtprecioagregar.Multiline = true;
            this.txtprecioagregar.Name = "txtprecioagregar";
            this.txtprecioagregar.Size = new System.Drawing.Size(316, 31);
            this.txtprecioagregar.TabIndex = 9;
            // 
            // dgvproductos
            // 
            this.dgvproductos.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.CANTIDAD,
            this.PRECIO_UNIDAD});
            this.dgvproductos.Location = new System.Drawing.Point(488, 169);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.Size = new System.Drawing.Size(553, 301);
            this.dgvproductos.TabIndex = 10;
            this.dgvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellClick);
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 125;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 125;
            // 
            // PRECIO_UNIDAD
            // 
            this.PRECIO_UNIDAD.HeaderText = "PRECIO_UNIDAD";
            this.PRECIO_UNIDAD.MinimumWidth = 6;
            this.PRECIO_UNIDAD.Name = "PRECIO_UNIDAD";
            this.PRECIO_UNIDAD.Width = 125;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Peru;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(70, 577);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(231, 72);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "AGREGAR ";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.Peru;
            this.bteliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.Location = new System.Drawing.Point(544, 577);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(231, 72);
            this.bteliminar.TabIndex = 12;
            this.bteliminar.Text = "ELIMINAR";
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // btregresar
            // 
            this.btregresar.BackColor = System.Drawing.Color.Peru;
            this.btregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btregresar.Location = new System.Drawing.Point(781, 577);
            this.btregresar.Name = "btregresar";
            this.btregresar.Size = new System.Drawing.Size(231, 72);
            this.btregresar.TabIndex = 13;
            this.btregresar.Text = "REGRESAR MENU PRINCIPAL";
            this.btregresar.UseVisualStyleBackColor = false;
            this.btregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbbusqueda.Location = new System.Drawing.Point(541, 124);
            this.tbbusqueda.Multiline = true;
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(500, 39);
            this.tbbusqueda.TabIndex = 14;
            this.tbbusqueda.TextChanged += new System.EventHandler(this.tbbusqueda_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appDespensa.Properties.Resources.icons8_search_40;
            this.pictureBox1.Location = new System.Drawing.Point(488, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(70, 198);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(316, 31);
            this.txtid.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID PRODUCTO";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Peru;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(307, 577);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(231, 72);
            this.btneditar.TabIndex = 18;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // agregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appDespensa.Properties.Resources.pngtree_an_illustration_of_a_pantry_with_pots_and_dishes_picture_image_3491498;
            this.ClientSize = new System.Drawing.Size(1103, 722);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbbusqueda);
            this.Controls.Add(this.btregresar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.txtprecioagregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcantidadagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombreagregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "agregarProducto";
            this.Text = "agregarProducto";
            this.Load += new System.EventHandler(this.agregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombreagregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidadagregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprecioagregar;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNIDAD;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button btregresar;
        private System.Windows.Forms.TextBox tbbusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneditar;
    }
}