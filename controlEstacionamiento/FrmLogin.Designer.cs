namespace controlEstacionamiento
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ini = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.txt_pas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // btn_ini
            // 
            this.btn_ini.Location = new System.Drawing.Point(256, 115);
            this.btn_ini.Name = "btn_ini";
            this.btn_ini.Size = new System.Drawing.Size(90, 30);
            this.btn_ini.TabIndex = 2;
            this.btn_ini.Tag = "";
            this.btn_ini.Text = "INGRESAR";
            this.btn_ini.UseVisualStyleBackColor = true;
            this.btn_ini.Click += new System.EventHandler(this.btn_ini_Click);
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(399, 115);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(90, 30);
            this.btn_can.TabIndex = 3;
            this.btn_can.Tag = "";
            this.btn_can.Text = "SALIR";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // txt_usu
            // 
            this.txt_usu.Location = new System.Drawing.Point(357, 37);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(159, 20);
            this.txt_usu.TabIndex = 4;
            this.txt_usu.Tag = "";
            // 
            // txt_pas
            // 
            this.txt_pas.Location = new System.Drawing.Point(357, 72);
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.PasswordChar = '*';
            this.txt_pas.Size = new System.Drawing.Size(159, 20);
            this.txt_pas.TabIndex = 5;
            this.txt_pas.Tag = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::controlEstacionamiento.Properties.Resources.logotipo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(550, 170);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_ini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesion Gladiator Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ini;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.TextBox txt_pas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

