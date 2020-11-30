namespace TransportingSolution
{
    partial class frmMain
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
            this.lblSourceNum = new System.Windows.Forms.Label();
            this.lblDrainNum = new System.Windows.Forms.Label();
            this.nudSourceNum = new System.Windows.Forms.NumericUpDown();
            this.nudDrainNum = new System.Windows.Forms.NumericUpDown();
            this.dgvTransport = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSourceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrainNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSourceNum
            // 
            this.lblSourceNum.AutoSize = true;
            this.lblSourceNum.Location = new System.Drawing.Point(13, 31);
            this.lblSourceNum.Name = "lblSourceNum";
            this.lblSourceNum.Size = new System.Drawing.Size(116, 13);
            this.lblSourceNum.TabIndex = 0;
            this.lblSourceNum.Text = "Források (sorok) száma";
            // 
            // lblDrainNum
            // 
            this.lblDrainNum.AutoSize = true;
            this.lblDrainNum.Location = new System.Drawing.Point(13, 64);
            this.lblDrainNum.Name = "lblDrainNum";
            this.lblDrainNum.Size = new System.Drawing.Size(124, 13);
            this.lblDrainNum.TabIndex = 1;
            this.lblDrainNum.Text = "Nyelők (oszlopok) száma";
            // 
            // nudSourceNum
            // 
            this.nudSourceNum.Location = new System.Drawing.Point(149, 29);
            this.nudSourceNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSourceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSourceNum.Name = "nudSourceNum";
            this.nudSourceNum.Size = new System.Drawing.Size(41, 20);
            this.nudSourceNum.TabIndex = 2;
            this.nudSourceNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSourceNum.ValueChanged += new System.EventHandler(this.nudSourceNum_ValueChanged);
            // 
            // nudDrainNum
            // 
            this.nudDrainNum.Location = new System.Drawing.Point(149, 62);
            this.nudDrainNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDrainNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDrainNum.Name = "nudDrainNum";
            this.nudDrainNum.Size = new System.Drawing.Size(41, 20);
            this.nudDrainNum.TabIndex = 3;
            this.nudDrainNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDrainNum.ValueChanged += new System.EventHandler(this.nudDrainNum_ValueChanged);
            // 
            // dgvTransport
            // 
            this.dgvTransport.AllowUserToAddRows = false;
            this.dgvTransport.AllowUserToDeleteRows = false;
            this.dgvTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransport.Location = new System.Drawing.Point(16, 140);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.Size = new System.Drawing.Size(848, 305);
            this.dgvTransport.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(376, 43);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(134, 38);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 524);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dgvTransport);
            this.Controls.Add(this.nudDrainNum);
            this.Controls.Add(this.nudSourceNum);
            this.Controls.Add(this.lblDrainNum);
            this.Controls.Add(this.lblSourceNum);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSourceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrainNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSourceNum;
        private System.Windows.Forms.Label lblDrainNum;
        private System.Windows.Forms.NumericUpDown nudSourceNum;
        private System.Windows.Forms.NumericUpDown nudDrainNum;
        private System.Windows.Forms.DataGridView dgvTransport;
        private System.Windows.Forms.Button btnCalc;
    }
}

