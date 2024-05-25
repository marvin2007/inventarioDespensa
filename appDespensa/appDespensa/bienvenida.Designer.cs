namespace appDespensa
{
    partial class bienvenida
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
            this.lb1 = new System.Windows.Forms.Label();
            this.btagregarProducto = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btcerrarsesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.SystemColors.Control;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(373, 85);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(332, 37);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "MENU DE USUARIO";
            // 
            // btagregarProducto
            // 
            this.btagregarProducto.BackColor = System.Drawing.Color.Peru;
            this.btagregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btagregarProducto.Location = new System.Drawing.Point(125, 248);
            this.btagregarProducto.Name = "btagregarProducto";
            this.btagregarProducto.Size = new System.Drawing.Size(231, 72);
            this.btagregarProducto.TabIndex = 1;
            this.btagregarProducto.Text = "AGREGAR PRODUCTO";
            this.btagregarProducto.UseVisualStyleBackColor = false;
            this.btagregarProducto.Click += new System.EventHandler(this.btagregarProducto_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.BackColor = System.Drawing.Color.Peru;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.Location = new System.Drawing.Point(125, 395);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(231, 72);
            this.btnempleados.TabIndex = 2;
            this.btnempleados.Text = "AGREGAR EMPLEADOS";
            this.btnempleados.UseVisualStyleBackColor = false;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::appDespensa.Properties.Resources.black_line_drawing_online_supermarket_e_commerce_online_shopping_icon_113479_wh12002;
            this.pictureBox1.Location = new System.Drawing.Point(649, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Peru;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Image = global::appDespensa.Properties.Resources.icons8_exit_40;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(939, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(180, 72);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btcerrarsesion
            // 
            this.btcerrarsesion.BackColor = System.Drawing.Color.Peru;
            this.btcerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcerrarsesion.Location = new System.Drawing.Point(21, 12);
            this.btcerrarsesion.Name = "btcerrarsesion";
            this.btcerrarsesion.Size = new System.Drawing.Size(180, 72);
            this.btcerrarsesion.TabIndex = 6;
            this.btcerrarsesion.Text = "CERRAR SESION";
            this.btcerrarsesion.UseVisualStyleBackColor = false;
            this.btcerrarsesion.Click += new System.EventHandler(this.button2_Click);
            // 
            // bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appDespensa.Properties.Resources.pngtree_an_illustration_of_a_pantry_with_pots_and_dishes_picture_image_3491498;
            this.ClientSize = new System.Drawing.Size(1131, 721);
            this.Controls.Add(this.btcerrarsesion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnempleados);
            this.Controls.Add(this.btagregarProducto);
            this.Controls.Add(this.lb1);
            this.Name = "bienvenida";
            this.Text = "bienvenida";
            this.Load += new System.EventHandler(this.bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btagregarProducto;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btcerrarsesion;
    }
}