namespace EEXI.WinForm
{
    partial class Form01
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tB01_Deadweight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB03_ResEEDIRefLine = new System.Windows.Forms.TextBox();
            this.tB04_ResRequiredEEXI = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bCalc = new System.Windows.Forms.Button();
            this.tB02_GrossTonnage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(22, 86);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(113, 25);
            this.label01.TabIndex = 0;
            this.label01.Text = "Ship Type";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(22, 138);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(138, 25);
            this.label02.TabIndex = 1;
            this.label02.Text = "Deadweight";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(415, 138);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(71, 25);
            this.label03.TabIndex = 2;
            this.label03.Text = "tonns";
            this.label03.Click += new System.EventHandler(this.label03_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(24, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(321, 33);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Calculation Required EEXI";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bulk carrier",
            "Gas carrier",
            "Tanker",
            "Containership",
            "General cargo ship",
            "Refrigerated cargo carrier",
            "Combination carrier",
            "Ro-ro cargo ship",
            "Ro-ro cargo ship (vehicle carrier)",
            "Ro-ro passenger ship",
            "LNG carrier",
            "Cruise passenger ship having non-conventional propulsion"});
            this.comboBox1.Location = new System.Drawing.Point(179, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(463, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // tB01_Deadweight
            // 
            this.tB01_Deadweight.Location = new System.Drawing.Point(197, 135);
            this.tB01_Deadweight.Name = "tB01_Deadweight";
            this.tB01_Deadweight.Size = new System.Drawing.Size(199, 33);
            this.tB01_Deadweight.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "EEDI Reference line value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Required EEXI";
            // 
            // tB03_ResEEDIRefLine
            // 
            this.tB03_ResEEDIRefLine.Location = new System.Drawing.Point(384, 232);
            this.tB03_ResEEDIRefLine.Name = "tB03_ResEEDIRefLine";
            this.tB03_ResEEDIRefLine.Size = new System.Drawing.Size(179, 33);
            this.tB03_ResEEDIRefLine.TabIndex = 7;
            this.tB03_ResEEDIRefLine.TextChanged += new System.EventHandler(this.tB03_ResEEDIRefLine_TextChanged);
            // 
            // tB04_ResRequiredEEXI
            // 
            this.tB04_ResRequiredEEXI.Location = new System.Drawing.Point(384, 294);
            this.tB04_ResRequiredEEXI.Name = "tB04_ResRequiredEEXI";
            this.tB04_ResRequiredEEXI.Size = new System.Drawing.Size(179, 33);
            this.tB04_ResRequiredEEXI.TabIndex = 8;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(66, 370);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(210, 46);
            this.bClear.TabIndex = 10;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bCalc
            // 
            this.bCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bCalc.Location = new System.Drawing.Point(339, 370);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(224, 46);
            this.bCalc.TabIndex = 9;
            this.bCalc.Text = "Calculate";
            this.bCalc.UseVisualStyleBackColor = false;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // tB02_GrossTonnage
            // 
            this.tB02_GrossTonnage.Location = new System.Drawing.Point(197, 174);
            this.tB02_GrossTonnage.Name = "tB02_GrossTonnage";
            this.tB02_GrossTonnage.Size = new System.Drawing.Size(199, 33);
            this.tB02_GrossTonnage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gross tonnage";
            // 
            // Form01
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(654, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB02_GrossTonnage);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tB04_ResRequiredEEXI);
            this.Controls.Add(this.tB03_ResEEDIRefLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB01_Deadweight);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label03);
            this.Controls.Add(this.label02);
            this.Controls.Add(this.label01);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form01";
            this.Text = "Required EEXI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label01;
        private Label label02;
        private Label label03;
        private Label labelName;
        private ComboBox comboBox1;
        private TextBox tB01_Deadweight;
        private Label label2;
        private Label label3;
        private TextBox tB03_ResEEDIRefLine;
        private TextBox tB04_ResRequiredEEXI;
        private Button bClear;
        private Button bCalc;
        private TextBox tB02_GrossTonnage;
        private Label label1;
    }
}