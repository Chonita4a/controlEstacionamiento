namespace controlEstacionamiento
{
    partial class Home
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
            this.btn_rep = new System.Windows.Forms.Button();
            this.btn_est = new System.Windows.Forms.Button();
            this.btn_sal = new System.Windows.Forms.Button();
            this.btn_tsal = new System.Windows.Forms.Button();
            this.btn_tent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rep
            // 
            this.btn_rep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rep.Location = new System.Drawing.Point(436, 163);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.Size = new System.Drawing.Size(259, 60);
            this.btn_rep.TabIndex = 3;
            this.btn_rep.Text = "Reporte de ventas";
            this.btn_rep.UseVisualStyleBackColor = true;
            this.btn_rep.Click += new System.EventHandler(this.btn_rep_Click);
            // 
            // btn_est
            // 
            this.btn_est.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_est.Location = new System.Drawing.Point(436, 262);
            this.btn_est.Name = "btn_est";
            this.btn_est.Size = new System.Drawing.Size(259, 62);
            this.btn_est.TabIndex = 4;
            this.btn_est.Text = "Estacionamientos";
            this.btn_est.UseVisualStyleBackColor = true;
            this.btn_est.Click += new System.EventHandler(this.btn_est_Click);
            // 
            // btn_sal
            // 
            this.btn_sal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sal.Location = new System.Drawing.Point(436, 361);
            this.btn_sal.Name = "btn_sal";
            this.btn_sal.Size = new System.Drawing.Size(259, 62);
            this.btn_sal.TabIndex = 5;
            this.btn_sal.Text = "Salir";
            this.btn_sal.UseVisualStyleBackColor = true;
            this.btn_sal.Click += new System.EventHandler(this.btn_sal_Click);
            // 
            // btn_tsal
            // 
            this.btn_tsal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tsal.BackColor = System.Drawing.Color.Silver;
            this.btn_tsal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tsal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_tsal.Image = global::controlEstacionamiento.Properties.Resources.ticket;
            this.btn_tsal.Location = new System.Drawing.Point(728, 53);
            this.btn_tsal.Name = "btn_tsal";
            this.btn_tsal.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.btn_tsal.Size = new System.Drawing.Size(393, 491);
            this.btn_tsal.TabIndex = 1;
            this.btn_tsal.Text = "SALIDA";
            this.btn_tsal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tsal.UseVisualStyleBackColor = false;
            this.btn_tsal.Click += new System.EventHandler(this.btn_tsal_Click);
            // 
            // btn_tent
            // 
            this.btn_tent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tent.BackColor = System.Drawing.Color.Silver;
            this.btn_tent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_tent.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_tent.Image = global::controlEstacionamiento.Properties.Resources.ticket;
            this.btn_tent.Location = new System.Drawing.Point(9, 53);
            this.btn_tent.Name = "btn_tent";
            this.btn_tent.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.btn_tent.Size = new System.Drawing.Size(393, 491);
            this.btn_tent.TabIndex = 0;
            this.btn_tent.Text = "ENTRADA";
            this.btn_tent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tent.UseVisualStyleBackColor = false;
            this.btn_tent.Click += new System.EventHandler(this.btn_tent_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1143, 613);
            this.Controls.Add(this.btn_sal);
            this.Controls.Add(this.btn_est);
            this.Controls.Add(this.btn_rep);
            this.Controls.Add(this.btn_tsal);
            this.Controls.Add(this.btn_tent);
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Control Estacionamiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tent;
        private System.Windows.Forms.Button btn_tsal;
        private System.Windows.Forms.Button btn_rep;
        private System.Windows.Forms.Button btn_est;
        private System.Windows.Forms.Button btn_sal;
    }
}