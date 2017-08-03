namespace ApoInfo
{
    partial class frm_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_result1_1 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_result2_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result1_2 = new System.Windows.Forms.Label();
            this.lbl_result2_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_result1_1
            // 
            this.lbl_result1_1.AutoSize = true;
            this.lbl_result1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result1_1.Location = new System.Drawing.Point(138, 219);
            this.lbl_result1_1.Name = "lbl_result1_1";
            this.lbl_result1_1.Size = new System.Drawing.Size(72, 37);
            this.lbl_result1_1.TabIndex = 0;
            this.lbl_result1_1.Text = "N/A";
            // 
            // btn_get
            // 
            this.btn_get.FlatAppearance.BorderSize = 2;
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_get.ForeColor = System.Drawing.Color.Black;
            this.btn_get.Location = new System.Drawing.Point(12, 12);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(115, 28);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Aktualisieren";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lbl_result2_1
            // 
            this.lbl_result2_1.AutoSize = true;
            this.lbl_result2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result2_1.Location = new System.Drawing.Point(142, 540);
            this.lbl_result2_1.Name = "lbl_result2_1";
            this.lbl_result2_1.Size = new System.Drawing.Size(72, 37);
            this.lbl_result2_1.TabIndex = 2;
            this.lbl_result2_1.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1130, 82);
            this.label1.TabIndex = 3;
            this.label1.Text = "9 - 9 Uhr (Durchgehend, 24 Std.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(878, 82);
            this.label2.TabIndex = 4;
            this.label2.Text = "9 - 22 Uhr (Gleicher Tag):";
            // 
            // lbl_result1_2
            // 
            this.lbl_result1_2.AutoSize = true;
            this.lbl_result1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result1_2.Location = new System.Drawing.Point(138, 286);
            this.lbl_result1_2.Name = "lbl_result1_2";
            this.lbl_result1_2.Size = new System.Drawing.Size(72, 37);
            this.lbl_result1_2.TabIndex = 5;
            this.lbl_result1_2.Text = "N/A";
            // 
            // lbl_result2_2
            // 
            this.lbl_result2_2.AutoSize = true;
            this.lbl_result2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result2_2.Location = new System.Drawing.Point(142, 603);
            this.lbl_result2_2.Name = "lbl_result2_2";
            this.lbl_result2_2.Size = new System.Drawing.Size(72, 37);
            this.lbl_result2_2.TabIndex = 6;
            this.lbl_result2_2.Text = "N/A";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 726);
            this.Controls.Add(this.lbl_result2_2);
            this.Controls.Add(this.lbl_result1_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_result2_1);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.lbl_result1_1);
            this.Name = "frm_main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_result1_1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lbl_result2_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_result1_2;
        private System.Windows.Forms.Label lbl_result2_2;
    }
}

