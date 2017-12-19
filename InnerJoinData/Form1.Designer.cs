namespace InnerJoinData
{
    partial class Form1
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSPL = new System.Windows.Forms.Button();
            this.dgvQuery = new System.Windows.Forms.DataGridView();
            this.dgvSPL = new System.Windows.Forms.DataGridView();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.tbSPL = new System.Windows.Forms.TextBox();
            this.panelProses = new System.Windows.Forms.Panel();
            this.tbJKL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pbProses = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvProses = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPL)).BeginInit();
            this.panelProses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(336, 34);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSPL
            // 
            this.btnSPL.Location = new System.Drawing.Point(750, 35);
            this.btnSPL.Name = "btnSPL";
            this.btnSPL.Size = new System.Drawing.Size(75, 23);
            this.btnSPL.TabIndex = 1;
            this.btnSPL.Text = "spl";
            this.btnSPL.UseVisualStyleBackColor = true;
            this.btnSPL.Click += new System.EventHandler(this.btnSPL_Click);
            // 
            // dgvQuery
            // 
            this.dgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuery.Location = new System.Drawing.Point(13, 62);
            this.dgvQuery.Name = "dgvQuery";
            this.dgvQuery.Size = new System.Drawing.Size(398, 280);
            this.dgvQuery.TabIndex = 2;
            // 
            // dgvSPL
            // 
            this.dgvSPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPL.Location = new System.Drawing.Point(427, 62);
            this.dgvSPL.Name = "dgvSPL";
            this.dgvSPL.Size = new System.Drawing.Size(398, 280);
            this.dgvSPL.TabIndex = 3;
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(13, 36);
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(317, 20);
            this.tbQuery.TabIndex = 4;
            // 
            // tbSPL
            // 
            this.tbSPL.Location = new System.Drawing.Point(427, 37);
            this.tbSPL.Name = "tbSPL";
            this.tbSPL.Size = new System.Drawing.Size(317, 20);
            this.tbSPL.TabIndex = 6;
            // 
            // panelProses
            // 
            this.panelProses.Controls.Add(this.tbJKL);
            this.panelProses.Controls.Add(this.label1);
            this.panelProses.Controls.Add(this.button4);
            this.panelProses.Controls.Add(this.pbProses);
            this.panelProses.Controls.Add(this.button3);
            this.panelProses.Controls.Add(this.button1);
            this.panelProses.Controls.Add(this.comboBox2);
            this.panelProses.Controls.Add(this.comboBox1);
            this.panelProses.Controls.Add(this.dgvProses);
            this.panelProses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProses.Location = new System.Drawing.Point(0, 0);
            this.panelProses.Name = "panelProses";
            this.panelProses.Size = new System.Drawing.Size(835, 412);
            this.panelProses.TabIndex = 7;
            this.panelProses.Visible = false;
            // 
            // tbJKL
            // 
            this.tbJKL.Location = new System.Drawing.Point(527, 15);
            this.tbJKL.Name = "tbJKL";
            this.tbJKL.Size = new System.Drawing.Size(64, 20);
            this.tbJKL.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jumlah Karyawan Lembur";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "Export";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pbProses
            // 
            this.pbProses.Location = new System.Drawing.Point(12, 383);
            this.pbProses.Name = "pbProses";
            this.pbProses.Size = new System.Drawing.Size(730, 23);
            this.pbProses.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(748, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dgvProses
            // 
            this.dgvProses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProses.Location = new System.Drawing.Point(12, 62);
            this.dgvProses.Name = "dgvProses";
            this.dgvProses.Size = new System.Drawing.Size(811, 314);
            this.dgvProses.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Proccess";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 412);
            this.Controls.Add(this.panelProses);
            this.Controls.Add(this.tbSPL);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.dgvSPL);
            this.Controls.Add(this.dgvQuery);
            this.Controls.Add(this.btnSPL);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPL)).EndInit();
            this.panelProses.ResumeLayout(false);
            this.panelProses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnSPL;
        private System.Windows.Forms.DataGridView dgvQuery;
        private System.Windows.Forms.DataGridView dgvSPL;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.TextBox tbSPL;
        private System.Windows.Forms.Panel panelProses;
        private System.Windows.Forms.DataGridView dgvProses;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar pbProses;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbJKL;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

