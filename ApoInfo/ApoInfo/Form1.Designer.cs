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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lbl_result1_1 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_result2_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_result1_2 = new System.Windows.Forms.Label();
            this.lbl_result2_2 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.tmr_hideCursor = new System.Windows.Forms.Timer(this.components);
            this.pnl_first1 = new System.Windows.Forms.Panel();
            this.pnl_second1 = new System.Windows.Forms.Panel();
            this.pbx_apota = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_result1_1 = new System.Windows.Forms.Panel();
            this.pnl_result1_2 = new System.Windows.Forms.Panel();
            this.pnl_result2_1 = new System.Windows.Forms.Panel();
            this.pnl_result2_2 = new System.Windows.Forms.Panel();
            this.trm_updateData = new System.Windows.Forms.Timer(this.components);
            this.lbl_info = new System.Windows.Forms.Label();
            this.pbx_appqr = new System.Windows.Forms.PictureBox();
            this.tmr_updateOnce = new System.Windows.Forms.Timer(this.components);
            this.lbl_neterror = new System.Windows.Forms.Label();
            this.tmr_updateDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnl_first1.SuspendLayout();
            this.pnl_second1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_apota)).BeginInit();
            this.pnl_result1_1.SuspendLayout();
            this.pnl_result1_2.SuspendLayout();
            this.pnl_result2_1.SuspendLayout();
            this.pnl_result2_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_appqr)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_result1_1
            // 
            this.lbl_result1_1.AutoSize = true;
            this.lbl_result1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result1_1.Location = new System.Drawing.Point(143, 10);
            this.lbl_result1_1.Name = "lbl_result1_1";
            this.lbl_result1_1.Size = new System.Drawing.Size(72, 37);
            this.lbl_result1_1.TabIndex = 0;
            this.lbl_result1_1.Text = "N/A";
            // 
            // btn_get
            // 
            this.btn_get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get.FlatAppearance.BorderSize = 2;
            this.btn_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_get.ForeColor = System.Drawing.Color.Black;
            this.btn_get.Location = new System.Drawing.Point(521, -1);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(115, 28);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Aktualisieren";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Visible = false;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lbl_result2_1
            // 
            this.lbl_result2_1.AutoSize = true;
            this.lbl_result2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result2_1.Location = new System.Drawing.Point(144, 16);
            this.lbl_result2_1.Name = "lbl_result2_1";
            this.lbl_result2_1.Size = new System.Drawing.Size(72, 37);
            this.lbl_result2_1.TabIndex = 2;
            this.lbl_result2_1.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1246, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "9 - 9 Uhr (Durchgehend, 24 Std.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(966, 91);
            this.label2.TabIndex = 4;
            this.label2.Text = "9 - 22 Uhr (Gleicher Tag):";
            // 
            // lbl_result1_2
            // 
            this.lbl_result1_2.AutoSize = true;
            this.lbl_result1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result1_2.Location = new System.Drawing.Point(152, 11);
            this.lbl_result1_2.Name = "lbl_result1_2";
            this.lbl_result1_2.Size = new System.Drawing.Size(72, 37);
            this.lbl_result1_2.TabIndex = 5;
            this.lbl_result1_2.Text = "N/A";
            // 
            // lbl_result2_2
            // 
            this.lbl_result2_2.AutoSize = true;
            this.lbl_result2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_result2_2.Location = new System.Drawing.Point(153, 16);
            this.lbl_result2_2.Name = "lbl_result2_2";
            this.lbl_result2_2.Size = new System.Drawing.Size(72, 37);
            this.lbl_result2_2.TabIndex = 6;
            this.lbl_result2_2.Text = "N/A";
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(1479, 21);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(170, 15);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "Oldenburg, den dd.MM.yy";
            this.lbl_date.UseMnemonic = false;
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // tmr_hideCursor
            // 
            this.tmr_hideCursor.Enabled = true;
            this.tmr_hideCursor.Interval = 1000;
            this.tmr_hideCursor.Tick += new System.EventHandler(this.tmr_hideCursor_Tick);
            // 
            // pnl_first1
            // 
            this.pnl_first1.BackColor = System.Drawing.Color.Red;
            this.pnl_first1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_first1.Controls.Add(this.label1);
            this.pnl_first1.Location = new System.Drawing.Point(57, 91);
            this.pnl_first1.Name = "pnl_first1";
            this.pnl_first1.Size = new System.Drawing.Size(1259, 123);
            this.pnl_first1.TabIndex = 8;
            // 
            // pnl_second1
            // 
            this.pnl_second1.BackColor = System.Drawing.Color.Red;
            this.pnl_second1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_second1.Controls.Add(this.label2);
            this.pnl_second1.Location = new System.Drawing.Point(57, 389);
            this.pnl_second1.Name = "pnl_second1";
            this.pnl_second1.Size = new System.Drawing.Size(1259, 126);
            this.pnl_second1.TabIndex = 9;
            // 
            // pbx_apota
            // 
            this.pbx_apota.Image = ((System.Drawing.Image)(resources.GetObject("pbx_apota.Image")));
            this.pbx_apota.Location = new System.Drawing.Point(26, 12);
            this.pbx_apota.Name = "pbx_apota";
            this.pbx_apota.Size = new System.Drawing.Size(163, 129);
            this.pbx_apota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_apota.TabIndex = 10;
            this.pbx_apota.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(172, 29);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(451, 82);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "NOTDIENST";
            // 
            // pnl_result1_1
            // 
            this.pnl_result1_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_result1_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_result1_1.Controls.Add(this.lbl_result1_1);
            this.pnl_result1_1.Location = new System.Drawing.Point(57, 220);
            this.pnl_result1_1.Name = "pnl_result1_1";
            this.pnl_result1_1.Size = new System.Drawing.Size(635, 163);
            this.pnl_result1_1.TabIndex = 11;
            // 
            // pnl_result1_2
            // 
            this.pnl_result1_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_result1_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_result1_2.Controls.Add(this.lbl_result1_2);
            this.pnl_result1_2.Location = new System.Drawing.Point(698, 220);
            this.pnl_result1_2.Name = "pnl_result1_2";
            this.pnl_result1_2.Size = new System.Drawing.Size(618, 163);
            this.pnl_result1_2.TabIndex = 12;
            // 
            // pnl_result2_1
            // 
            this.pnl_result2_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_result2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_result2_1.Controls.Add(this.lbl_result2_1);
            this.pnl_result2_1.Location = new System.Drawing.Point(57, 521);
            this.pnl_result2_1.Name = "pnl_result2_1";
            this.pnl_result2_1.Size = new System.Drawing.Size(635, 163);
            this.pnl_result2_1.TabIndex = 13;
            // 
            // pnl_result2_2
            // 
            this.pnl_result2_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_result2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_result2_2.Controls.Add(this.lbl_result2_2);
            this.pnl_result2_2.Location = new System.Drawing.Point(698, 521);
            this.pnl_result2_2.Name = "pnl_result2_2";
            this.pnl_result2_2.Size = new System.Drawing.Size(618, 163);
            this.pnl_result2_2.TabIndex = 14;
            // 
            // trm_updateData
            // 
            this.trm_updateData.Enabled = true;
            this.trm_updateData.Interval = 1800000;
            this.trm_updateData.Tick += new System.EventHandler(this.trm_updateData_Tick);
            // 
            // lbl_info
            // 
            this.lbl_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(142, 698);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(1204, 20);
            this.lbl_info.TabIndex = 15;
            this.lbl_info.Text = "Es informiert Sie Ihre Apotheke Donnerschwee. Unsere Öffnungszeiten: Mo. bis Fr. " +
    "8:30 - 20:00 Uhr und Sa. 9:00 bis 13:00 Uhr. Telefon: 0441 31727";
            this.lbl_info.UseMnemonic = false;
            // 
            // pbx_appqr
            // 
            this.pbx_appqr.Image = ((System.Drawing.Image)(resources.GetObject("pbx_appqr.Image")));
            this.pbx_appqr.Location = new System.Drawing.Point(898, 7);
            this.pbx_appqr.Name = "pbx_appqr";
            this.pbx_appqr.Size = new System.Drawing.Size(352, 129);
            this.pbx_appqr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_appqr.TabIndex = 16;
            this.pbx_appqr.TabStop = false;
            // 
            // tmr_updateOnce
            // 
            this.tmr_updateOnce.Enabled = true;
            this.tmr_updateOnce.Interval = 1000;
            this.tmr_updateOnce.Tick += new System.EventHandler(this.tmr_updateOnce_Tick);
            // 
            // lbl_neterror
            // 
            this.lbl_neterror.AutoSize = true;
            this.lbl_neterror.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_neterror.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_neterror.Location = new System.Drawing.Point(203, 118);
            this.lbl_neterror.Name = "lbl_neterror";
            this.lbl_neterror.Size = new System.Drawing.Size(909, 20);
            this.lbl_neterror.TabIndex = 17;
            this.lbl_neterror.Text = "Hinweiß: Die Aktuallität der Daten ist temporär nicht garantiert! Für aktuelle In" +
    "fos bitte \'Meine Apotheke\' nutzen.";
            this.lbl_neterror.UseMnemonic = false;
            this.lbl_neterror.Visible = false;
            // 
            // tmr_updateDateTime
            // 
            this.tmr_updateDateTime.Enabled = true;
            this.tmr_updateDateTime.Interval = 60000;
            this.tmr_updateDateTime.Tick += new System.EventHandler(this.tmr_updateDateTime_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 729);
            this.Controls.Add(this.lbl_neterror);
            this.Controls.Add(this.pbx_appqr);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.pnl_result2_2);
            this.Controls.Add(this.pnl_result2_1);
            this.Controls.Add(this.pnl_result1_2);
            this.Controls.Add(this.pnl_result1_1);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pbx_apota);
            this.Controls.Add(this.pnl_second1);
            this.Controls.Add(this.pnl_first1);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_get);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.Text = "Oldenburger-Apotheken.de/Notdienst";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_main_MouseMove);
            this.pnl_first1.ResumeLayout(false);
            this.pnl_first1.PerformLayout();
            this.pnl_second1.ResumeLayout(false);
            this.pnl_second1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_apota)).EndInit();
            this.pnl_result1_1.ResumeLayout(false);
            this.pnl_result1_1.PerformLayout();
            this.pnl_result1_2.ResumeLayout(false);
            this.pnl_result1_2.PerformLayout();
            this.pnl_result2_1.ResumeLayout(false);
            this.pnl_result2_1.PerformLayout();
            this.pnl_result2_2.ResumeLayout(false);
            this.pnl_result2_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_appqr)).EndInit();
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
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Timer tmr_hideCursor;
        private System.Windows.Forms.Panel pnl_first1;
        private System.Windows.Forms.Panel pnl_second1;
        private System.Windows.Forms.PictureBox pbx_apota;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_result1_1;
        private System.Windows.Forms.Panel pnl_result1_2;
        private System.Windows.Forms.Panel pnl_result2_1;
        private System.Windows.Forms.Panel pnl_result2_2;
        private System.Windows.Forms.Timer trm_updateData;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.PictureBox pbx_appqr;
        private System.Windows.Forms.Timer tmr_updateOnce;
        private System.Windows.Forms.Label lbl_neterror;
        private System.Windows.Forms.Timer tmr_updateDateTime;
    }
}

