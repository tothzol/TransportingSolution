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
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProblem = new System.Windows.Forms.TabPage();
            this.tpSolution = new System.Windows.Forms.TabPage();
            this.lblZValue = new System.Windows.Forms.Label();
            this.lblSolutionType = new System.Windows.Forms.Label();
            this.dgvSolution = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSourceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrainNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpProblem.SuspendLayout();
            this.tpSolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).BeginInit();
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
            this.lblDrainNum.Location = new System.Drawing.Point(236, 31);
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
            this.nudDrainNum.Location = new System.Drawing.Point(372, 29);
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
            this.dgvTransport.Location = new System.Drawing.Point(3, 16);
            this.dgvTransport.Name = "dgvTransport";
            this.dgvTransport.Size = new System.Drawing.Size(848, 305);
            this.dgvTransport.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(471, 18);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(134, 38);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Számolás";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(698, 18);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 38);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Nullázás";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProblem);
            this.tabControl1.Controls.Add(this.tpSolution);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 394);
            this.tabControl1.TabIndex = 7;
            // 
            // tpProblem
            // 
            this.tpProblem.Controls.Add(this.dgvTransport);
            this.tpProblem.Location = new System.Drawing.Point(4, 22);
            this.tpProblem.Name = "tpProblem";
            this.tpProblem.Padding = new System.Windows.Forms.Padding(3);
            this.tpProblem.Size = new System.Drawing.Size(874, 368);
            this.tpProblem.TabIndex = 0;
            this.tpProblem.Text = "Probléma";
            this.tpProblem.UseVisualStyleBackColor = true;
            // 
            // tpSolution
            // 
            this.tpSolution.Controls.Add(this.lblZValue);
            this.tpSolution.Controls.Add(this.lblSolutionType);
            this.tpSolution.Controls.Add(this.dgvSolution);
            this.tpSolution.Location = new System.Drawing.Point(4, 22);
            this.tpSolution.Name = "tpSolution";
            this.tpSolution.Padding = new System.Windows.Forms.Padding(3);
            this.tpSolution.Size = new System.Drawing.Size(874, 368);
            this.tpSolution.TabIndex = 1;
            this.tpSolution.Text = "Megoldás";
            this.tpSolution.UseVisualStyleBackColor = true;
            // 
            // lblZValue
            // 
            this.lblZValue.AutoSize = true;
            this.lblZValue.Location = new System.Drawing.Point(436, 339);
            this.lblZValue.Name = "lblZValue";
            this.lblZValue.Size = new System.Drawing.Size(35, 13);
            this.lblZValue.TabIndex = 7;
            this.lblZValue.Text = "label1";
            // 
            // lblSolutionType
            // 
            this.lblSolutionType.AutoSize = true;
            this.lblSolutionType.Location = new System.Drawing.Point(57, 340);
            this.lblSolutionType.Name = "lblSolutionType";
            this.lblSolutionType.Size = new System.Drawing.Size(35, 13);
            this.lblSolutionType.TabIndex = 6;
            this.lblSolutionType.Text = "label1";
            // 
            // dgvSolution
            // 
            this.dgvSolution.AllowUserToAddRows = false;
            this.dgvSolution.AllowUserToDeleteRows = false;
            this.dgvSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolution.Location = new System.Drawing.Point(6, 19);
            this.dgvSolution.Name = "dgvSolution";
            this.dgvSolution.Size = new System.Drawing.Size(848, 305);
            this.dgvSolution.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.nudDrainNum);
            this.Controls.Add(this.nudSourceNum);
            this.Controls.Add(this.lblDrainNum);
            this.Controls.Add(this.lblSourceNum);
            this.Name = "frmMain";
            this.Text = "Transport";
            ((System.ComponentModel.ISupportInitialize)(this.nudSourceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrainNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransport)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpProblem.ResumeLayout(false);
            this.tpSolution.ResumeLayout(false);
            this.tpSolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).EndInit();
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
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProblem;
        private System.Windows.Forms.TabPage tpSolution;
        private System.Windows.Forms.DataGridView dgvSolution;
        private System.Windows.Forms.Label lblZValue;
        private System.Windows.Forms.Label lblSolutionType;
    }
}

