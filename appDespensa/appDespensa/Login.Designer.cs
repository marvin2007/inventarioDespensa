namespace appDespensa
{
    partial class Login
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
            this.lb1login = new System.Windows.Forms.Label();
            this.lb2login = new System.Windows.Forms.Label();
            this.pblogin = new System.Windows.Forms.PictureBox();
            this.tb1Login = new System.Windows.Forms.TextBox();
            this.lb3login = new System.Windows.Forms.Label();
            this.tb2Login = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1login
            // 
            this.lb1login.AutoSize = true;
            this.lb1login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lb1login.Location = new System.Drawing.Point(200, 62);
            this.lb1login.Name = "lb1login";
            this.lb1login.Size = new System.Drawing.Size(673, 35);
            this.lb1login.TabIndex = 0;
            this.lb1login.Text = "SISTEMA ADMINISTRACION DE INVENTARIO";
            // 
            // lb2login
            // 
            this.lb2login.AutoSize = true;
            this.lb2login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2login.Location = new System.Drawing.Point(366, 301);
            this.lb2login.Name = "lb2login";
            this.lb2login.Size = new System.Drawing.Size(93, 26);
            this.lb2login.TabIndex = 1;
            this.lb2login.Text = "Usuario:";
            // 
            // pblogin
            // 
            this.pblogin.Image = global::appDespensa.Properties.Resources.icons8_user_100;
            this.pblogin.Location = new System.Drawing.Point(439, 123);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(142, 138);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogin.TabIndex = 2;
            this.pblogin.TabStop = false;
            // 
            // tb1Login
            // 
            this.tb1Login.Location = new System.Drawing.Point(371, 330);
            this.tb1Login.Multiline = true;
            this.tb1Login.Name = "tb1Login";
            this.tb1Login.Size = new System.Drawing.Size(283, 24);
            this.tb1Login.TabIndex = 3;
            this.tb1Login.TextChanged += new System.EventHandler(this.tb1Login_TextChanged);
            // 
            // lb3login
            // 
            this.lb3login.AutoSize = true;
            this.lb3login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3login.Location = new System.Drawing.Point(366, 366);
            this.lb3login.Name = "lb3login";
            this.lb3login.Size = new System.Drawing.Size(130, 26);
            this.lb3login.TabIndex = 4;
            this.lb3login.Text = "Contraseña:";
            // 
            // tb2Login
            // 
            this.tb2Login.Location = new System.Drawing.Point(371, 395);
            this.tb2Login.Multiline = true;
            this.tb2Login.Name = "tb2Login";
            this.tb2Login.PasswordChar = '*';
            this.tb2Login.Size = new System.Drawing.Size(283, 24);
            this.tb2Login.TabIndex = 5;
            this.tb2Login.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(452, 445);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(113, 60);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Ingresar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appDespensa.Properties.Resources.pngtree_an_illustration_of_a_pantry_with_pots_and_dishes_picture_image_3491498;
            this.ClientSize = new System.Drawing.Size(1075, 694);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tb2Login);
            this.Controls.Add(this.lb3login);
            this.Controls.Add(this.tb1Login);
            this.Controls.Add(this.pblogin);
            this.Controls.Add(this.lb2login);
            this.Controls.Add(this.lb1login);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1login;
        private System.Windows.Forms.Label lb2login;
        private System.Windows.Forms.PictureBox pblogin;
        private System.Windows.Forms.TextBox tb1Login;
        private System.Windows.Forms.Label lb3login;
        private System.Windows.Forms.TextBox tb2Login;
        private System.Windows.Forms.Button btLogin;
    }
}

