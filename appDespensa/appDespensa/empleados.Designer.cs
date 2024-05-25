namespace appDespensa
{
    partial class empleados
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtcarne = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtapellidoempleado = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.Label();
            this.txtnombreempleado = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARNÉ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Peru;
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(816, 593);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(231, 71);
            this.btnregresar.TabIndex = 26;
            this.btnregresar.Text = "REGRESAR MENU PRINCIPAL";
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btregresar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Peru;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(580, 593);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(231, 71);
            this.btneliminar.TabIndex = 25;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.Peru;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(108, 593);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(231, 71);
            this.btnagregar.TabIndex = 24;
            this.btnagregar.Text = "AGREGAR ";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtcarne
            // 
            this.txtcarne.Location = new System.Drawing.Point(45, 407);
            this.txtcarne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcarne.Multiline = true;
            this.txtcarne.Name = "txtcarne";
            this.txtcarne.Size = new System.Drawing.Size(316, 31);
            this.txtcarne.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "CARNÉ EMPLEADO";
            // 
            // txtapellidoempleado
            // 
            this.txtapellidoempleado.Location = new System.Drawing.Point(45, 329);
            this.txtapellidoempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtapellidoempleado.Multiline = true;
            this.txtapellidoempleado.Name = "txtapellidoempleado";
            this.txtapellidoempleado.Size = new System.Drawing.Size(316, 31);
            this.txtapellidoempleado.TabIndex = 20;
            // 
            // tbapellido
            // 
            this.tbapellido.AutoSize = true;
            this.tbapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbapellido.Location = new System.Drawing.Point(41, 300);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(218, 22);
            this.tbapellido.TabIndex = 19;
            this.tbapellido.Text = "APELLIDO EMPLEADO";
            // 
            // txtnombreempleado
            // 
            this.txtnombreempleado.Location = new System.Drawing.Point(45, 250);
            this.txtnombreempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnombreempleado.Multiline = true;
            this.txtnombreempleado.Name = "txtnombreempleado";
            this.txtnombreempleado.Size = new System.Drawing.Size(316, 31);
            this.txtnombreempleado.TabIndex = 18;
            // 
            // tbnombre
            // 
            this.tbnombre.AutoSize = true;
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.Location = new System.Drawing.Point(41, 222);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(207, 22);
            this.tbnombre.TabIndex = 17;
            this.tbnombre.Text = "NOMBRE EMPLEADO";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(45, 174);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(316, 31);
            this.txtid.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 31.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 56);
            this.label1.TabIndex = 14;
            this.label1.Text = "REGISTRO EMPLEADOS";
            // 
            // txtpuesto
            // 
            this.txtpuesto.Location = new System.Drawing.Point(45, 492);
            this.txtpuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpuesto.Multiline = true;
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(316, 31);
            this.txtpuesto.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "PUESTO";
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Peru;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(344, 593);
            this.btneditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(231, 71);
            this.btneditar.TabIndex = 29;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appDespensa.Properties.Resources.icons8_search_40;
            this.pictureBox1.Location = new System.Drawing.Point(477, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(531, 135);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Multiline = true;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(500, 38);
            this.txtbusqueda.TabIndex = 31;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.Peru;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.APELLIDO,
            this.CARNÉ,
            this.PUESTO});
            this.dgvEmpleados.Location = new System.Drawing.Point(481, 201);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(549, 322);
            this.dgvEmpleados.TabIndex = 33;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.Name = "APELLIDO";
            // 
            // CARNÉ
            // 
            this.CARNÉ.HeaderText = "CARNÉ";
            this.CARNÉ.Name = "CARNÉ";
            // 
            // PUESTO
            // 
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.Name = "PUESTO";
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appDespensa.Properties.Resources.pngtree_an_illustration_of_a_pantry_with_pots_and_dishes_picture_image_3491498;
            this.ClientSize = new System.Drawing.Size(1107, 713);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcarne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtapellidoempleado);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.txtnombreempleado);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtcarne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtapellidoempleado;
        private System.Windows.Forms.Label tbapellido;
        private System.Windows.Forms.TextBox txtnombreempleado;
        private System.Windows.Forms.Label tbnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARNÉ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
    }
}