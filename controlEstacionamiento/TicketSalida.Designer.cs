namespace controlEstacionamiento
{
    partial class TicketSalida
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_tper = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::controlEstacionamiento.Properties.Resources.lectura1;
            this.pictureBox1.Location = new System.Drawing.Point(41, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 260);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_tper
            // 
            this.dtp_tper.CustomFormat = "dd/M/yyyy hh:mm:ss";
            this.dtp_tper.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tper.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_tper.Location = new System.Drawing.Point(82, 310);
            this.dtp_tper.MaxDate = new System.DateTime(2100, 5, 19, 0, 0, 0, 0);
            this.dtp_tper.MinDate = new System.DateTime(2000, 5, 19, 0, 0, 0, 0);
            this.dtp_tper.Name = "dtp_tper";
            this.dtp_tper.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_tper.Size = new System.Drawing.Size(207, 20);
            this.dtp_tper.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generar Ticket Perdido";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_cod
            // 
            this.txt_cod.BackColor = System.Drawing.Color.Silver;
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.Location = new System.Drawing.Point(41, 358);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(486, 80);
            this.txt_cod.TabIndex = 3;
            // 
            // TicketSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(555, 466);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_tper);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "TicketSalida";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketSalida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_tper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cod;
    }
}